using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.DB
{
    public class AdminQueries
    {
        static MySqlConnection connection;

        public static void registerAdmin(String name, String email, DateTime bod, String pfpPath, String phoneNumber, String hash, String salt)
        {
            String adminInfoInsert = "INSERT INTO AdminInformation(Name, BirthDate, ProfilePicturePath,SupervisorID) " +
                                        "VALUES (@Name, @BirthDate, @ProfilePicturePath,@SuperID);";

            String adminContactInsert = "INSERT INTO AdminContactInformation(ID, Email, PhoneNumber) " +
                                        "VALUES (@AdminID, @Email, @PhoneNumber);";

            String adminSecurityInsert = "INSERT INTO AdminSecurityInformation(ID, PasswordSalt, PasswordHash) " +
                                        "VALUES (@AdminID, @PasswordSalt, @PasswordHash);";

            String adminLockoutInsert = "INSERT INTO AdminLockoutInformation(ID) " +
                                        "VALUES (@AdminID);";

            using (connection = new MySqlConnection(dbSecret.connectionString))
            {
                connection.Open();
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        long adminID;
                        using (var adminInfoCommand = new MySqlCommand(adminInfoInsert, connection, transaction))
                        {
                            adminInfoCommand.Parameters.AddWithValue("@Name", name);
                            adminInfoCommand.Parameters.AddWithValue("@BirthDate", bod);
                            adminInfoCommand.Parameters.AddWithValue("@ProfilePicturePath", pfpPath);
                            adminInfoCommand.Parameters.AddWithValue("@SuperID", 1);

                            adminInfoCommand.ExecuteNonQuery();

                            adminID = adminInfoCommand.LastInsertedId;
                        }

                        using (var secondCommand = new MySqlCommand(adminContactInsert, connection, transaction))
                        {
                            secondCommand.Parameters.AddWithValue("@AdminID", adminID);
                            secondCommand.Parameters.AddWithValue("@Email", email);
                            secondCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                            secondCommand.ExecuteNonQuery();
                        }

                        using (var thirdCommand = new MySqlCommand(adminSecurityInsert, connection, transaction))
                        {
                            thirdCommand.Parameters.AddWithValue("@AdminID", adminID);
                            thirdCommand.Parameters.AddWithValue("@PasswordSalt", salt);
                            thirdCommand.Parameters.AddWithValue("@PasswordHash", hash);

                            thirdCommand.ExecuteNonQuery();
                        }

                        using (var fourthCommand = new MySqlCommand(adminLockoutInsert, connection, transaction))
                        {
                            fourthCommand.Parameters.AddWithValue("@AdminID", adminID);

                            fourthCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
