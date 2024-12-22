using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.DB
{
    public class InstructorQueries
    {
        static MySqlConnection connection;


        public static void registerInstructor(String name, String email, DateTime bod, String pfpPath, String phoneNumber, String hash, String salt, long orgID)
        {
            String instructorInfoInsert = "INSERT INTO InstructorInformation(Name, BirthDate, ProfilePicturePath,AdminID) " +
                                        "VALUES (@Name, @BirthDate, @ProfilePicturePath,@AdminID);";

            String instructorContactInsert = "INSERT INTO InstructorContactInformation(ID, Email, PhoneNumber) " +
                                        "VALUES (@InstructorID, @Email, @PhoneNumber);";

            String instructorSecurityInsert = "INSERT INTO InstructorSecurityInformation(ID, PasswordSalt, PasswordHash) " +
                                        "VALUES (@InstructorID, @PasswordSalt, @PasswordHash);";

            String instructorLockoutInsert = "INSERT INTO InstructorLockoutInformation(ID) " +
                                        "VALUES (@InstructorID);";

            String instructorOrganization = "INSERT INTO OrganizationInstructors(ID,InstructorID) " +
                                             "VALUES(@OrgID,@InstructorID)";

			using (connection = new MySqlConnection(dbSecret.connectionString))
            {
                connection.Open();
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        long instructorID;
                        using (var instructorInfoCommand = new MySqlCommand(instructorInfoInsert, connection, transaction))
                        {
                            instructorInfoCommand.Parameters.AddWithValue("@Name", name);
                            instructorInfoCommand.Parameters.AddWithValue("@BirthDate", bod);
                            instructorInfoCommand.Parameters.AddWithValue("@ProfilePicturePath", pfpPath);
                            instructorInfoCommand.Parameters.AddWithValue("@AdminID", 1);

                            instructorInfoCommand.ExecuteNonQuery();

                            instructorID = instructorInfoCommand.LastInsertedId;
                        }

                        using (var secondCommand = new MySqlCommand(instructorContactInsert, connection, transaction))
                        {
                            secondCommand.Parameters.AddWithValue("@instructorID", instructorID);
                            secondCommand.Parameters.AddWithValue("@Email", email);
                            secondCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                            secondCommand.ExecuteNonQuery();
                        }

                        using (var thirdCommand = new MySqlCommand(instructorSecurityInsert, connection, transaction))
                        {
                            thirdCommand.Parameters.AddWithValue("@instructorID", instructorID);
                            thirdCommand.Parameters.AddWithValue("@PasswordSalt", salt);
                            thirdCommand.Parameters.AddWithValue("@PasswordHash", hash);

                            thirdCommand.ExecuteNonQuery();
                        }

                        using (var fourthCommand = new MySqlCommand(instructorLockoutInsert, connection, transaction))
                        {
                            fourthCommand.Parameters.AddWithValue("@instructorID", instructorID);

                            fourthCommand.ExecuteNonQuery();
                        }

                        if (orgID != -1)
                        {
                            using (var fifthCommand = new MySqlCommand(instructorOrganization, connection, transaction))
                            {
                                fifthCommand.Parameters.AddWithValue("@OrgID", orgID);
                                fifthCommand.Parameters.AddWithValue("@InstructorID", instructorID);

                                fifthCommand.ExecuteNonQuery();
                            }
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
