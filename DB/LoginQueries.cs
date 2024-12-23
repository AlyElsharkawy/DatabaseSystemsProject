using DatabaseSystemsProject.Models;
using DatabaseSystemsProject.Utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.DB
{
    public class LoginQueries
    {
        static public int type(String email)
        {
            String query = "SELECT ID, UserType, Email FROM UserEmails WHERE Email = @mail";
            int typeID = -1;
            using (var conn = new MySqlConnection(dbSecret.connectionString))
            {
                conn.Open();
                using (var cmm = new MySqlCommand(query, conn))
                {
                    cmm.Parameters.AddWithValue("@mail", email);
                    using (var reader = cmm.ExecuteReader())
                    {
                        while (reader.Read())
                        { 
                            typeID = reader.GetInt32("UserType");
                        }
                    }
                }

            }

            return typeID;
        }
        
        static public long authenticate(int myType, String email, String pass)
        {
            String query = "";
            switch (myType)
            {
                case 1:
                    query = "SELECT sci.ID, ssi.PasswordSalt, ssi.PasswordHash " +
                       "FROM StudentContactInformation sci " +
                       "JOIN StudentSecurityInformation ssi ON sci.ID = ssi.ID " +
                       "WHERE sci.Email = @mail";
                        break;
                case 2:
                    query = "SELECT aci.ID, asi.PasswordSalt, asi.PasswordHash " +
                       "FROM AdminContactInformation aci " +
                       "JOIN AdminSecurityInformation asi ON aci.ID = asi.ID " +
                       "WHERE aci.Email = @mail";
                        break;
                case 3:
                    query = "SELECT ici.ID, isi.PasswordSalt, isi.PasswordHash " +
                       "FROM InstructorContactInformation ici " +
                       "JOIN InstructorSecurityInformation isi ON ici.ID = isi.ID " +
                       "WHERE ici.Email = @mail";
                        break;
            }

            byte[] storedSalt = null;
            byte[] storedHash = null;
            long id = -1;
            using (var conn = new MySqlConnection(dbSecret.connectionString))
            {
                conn.Open();
                using (var cmm = new MySqlCommand(query, conn))
                {
                    cmm.Parameters.AddWithValue("@mail", email);
                    using (var reader = cmm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader.GetInt64("ID");
                            storedSalt = PasswordEncryption.HexStringToByteArray(reader.GetString("PasswordSalt"));
                            storedHash = PasswordEncryption.HexStringToByteArray(reader.GetString("PasswordHash"));
                        }
                    }
                }
            }

            byte[] enteredHash = PasswordEncryption.HashPassword(pass, storedSalt);

            if (PasswordEncryption.CompareByteArrays(enteredHash, storedHash))
            {
                return id;
            }

            return -1;

        }
    }
}
