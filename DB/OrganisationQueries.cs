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
                    String organisationInfoInsert = "INSERT INTO OrganisationInformation(Name, Description, ProfilePicturePath) " +
                                        "VALUES (@Name, @Description, @ProfilePicturePath);";
                    using (var transaction = connection.BeginTransaction())
                    {
                        using (var organistionInfoCommand = new MySqlCommand(organisationInfoInsert, connection, transaction))
                        {
                            organistionInfoCommand.Parameters.AddWithValue("@Name", name);
                            organistionInfoCommand.Parameters.AddWithValue("@BirthDate", description);
                            organistionInfoCommand.Parameters.AddWithValue("@ProfilePicturePath", path);

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
    }
}
