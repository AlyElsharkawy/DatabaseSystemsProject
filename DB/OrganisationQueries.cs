using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Windows.Forms;
using DatabaseSystemsProject.Models;

namespace DatabaseSystemsProject.DB
{
    public class OrganisationQueries
    {

        static MySqlConnection connection;

        public static void registerOrganisation(String name, String description, String path)
        {
            using (connection = new MySqlConnection(dbSecret.connectionString))
            {
                connection.Open();
                try
                {
                    String organisationInfoInsert = "INSERT INTO Organizations(NAME, Description, BackgroundImagePath, AdminID) " +
                                        "VALUES (@Name, @Description, @ProfilePicturePath, @AdminID);";
                    using (var transaction = connection.BeginTransaction())
                    {
                        using (var organistionInfoCommand = new MySqlCommand(organisationInfoInsert, connection, transaction))
                        {
                            organistionInfoCommand.Parameters.AddWithValue("@Name", name);
                            organistionInfoCommand.Parameters.AddWithValue("@Description", description);
                            organistionInfoCommand.Parameters.AddWithValue("@ProfilePicturePath", path);
                            organistionInfoCommand.Parameters.AddWithValue("@AdminID", 1);
                            organistionInfoCommand.ExecuteNonQuery();

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

        public static List<Organization> getAllOrgs()
        {
            List<Organization> orgs = new List<Organization>();

            String query = "SELECT ID, NAME FROM Organizations";

            using (var conn = new MySqlConnection(dbSecret.connectionString))
            {
                conn.Open();
                using (var cmm = new MySqlCommand(query, conn))
                {
                    using (var reader = cmm.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            var org = new Organization { ID = reader.GetInt32("ID"), Name = reader.GetString("NAME") };
                            orgs.Add(org);
                        }
                    }
                }

            }

            return orgs;
        }
    }
}
