using DatabaseSystemsProject.Models;
using DatabaseSystemsProject.Utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.DB
{
	public class StudentQueries
	{

		static MySqlConnection connection;


		public static void registerStudent(String name, String email, DateTime bod, String pfpPath, String phoneNumber, String hash, String salt)
		{
			String studentInfoInsert = "INSERT INTO StudentInformation(Name, BirthDate, ProfilePicturePath) " +
										"VALUES (@Name, @BirthDate, @ProfilePicturePath);";

			String studentContactInsert = "INSERT INTO StudentContactInformation(ID, Email, PhoneNumber) " +
										"VALUES (@StudentID, @Email, @PhoneNumber);";

			String studentSecurityInsert = "INSERT INTO StudentSecurityInformation(ID, PasswordSalt, PasswordHash) " +
										"VALUES (@StudentID, @PasswordSalt, @PasswordHash);";

			String studentLockoutInsert = "INSERT INTO StudentLockoutInformation(ID) " +
										"VALUES (@StudentID);";
			String userEmails = "INSERT INTO UserEmails(Email, UserType)" +
				"VALUES(@mail, @type)";
			using (connection = new MySqlConnection(dbSecret.connectionString))
			{
				connection.Open();
				try
				{
					using (var transaction = connection.BeginTransaction())
					{
						long studentID;
						using (var studentInfoCommand = new MySqlCommand(studentInfoInsert, connection, transaction))
						{
							studentInfoCommand.Parameters.AddWithValue("@Name", name);
							studentInfoCommand.Parameters.AddWithValue("@BirthDate", bod);
							studentInfoCommand.Parameters.AddWithValue("@ProfilePicturePath", pfpPath);

							studentInfoCommand.ExecuteNonQuery();

							studentID = studentInfoCommand.LastInsertedId;
						}

						using (var secondCommand = new MySqlCommand(studentContactInsert, connection, transaction))
						{
							secondCommand.Parameters.AddWithValue("@StudentID", studentID);
							secondCommand.Parameters.AddWithValue("@Email", email);
							secondCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

							secondCommand.ExecuteNonQuery();
						}

						using (var thirdCommand = new MySqlCommand(studentSecurityInsert, connection, transaction))
						{
							thirdCommand.Parameters.AddWithValue("@StudentID", studentID);
							thirdCommand.Parameters.AddWithValue("@PasswordSalt", salt);
							thirdCommand.Parameters.AddWithValue("@PasswordHash", hash);

							thirdCommand.ExecuteNonQuery();
						}

						using (var fourthCommand = new MySqlCommand(studentLockoutInsert, connection, transaction))
						{
							fourthCommand.Parameters.AddWithValue("@StudentID", studentID);

							fourthCommand.ExecuteNonQuery();
						}

                        using (var fifthCommand = new MySqlCommand(userEmails, connection, transaction))
                        {
                            fifthCommand.Parameters.AddWithValue("@mail", email);
                            fifthCommand.Parameters.AddWithValue("@type", 1);

                            fifthCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();


						MessageBox.Show(studentID.ToString());
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"An error occurred: {ex.Message}");
				}
			}
		}


		public static long loginStudent(String email, String password)
		{
			string query = "SELECT sci.ID, ssi.PasswordSalt, ssi.PasswordHash " +
				   "FROM StudentContactInformation sci " +
				   "JOIN StudentSecurityInformation ssi ON sci.ID = ssi.ID " +
				   "WHERE sci.Email = @Email";

			byte[] storedSalt = null;
			byte[] storedHash = null;
			long studentID = 0;

			using (var connection = new MySqlConnection(dbSecret.connectionString)) {

				connection.Open();
				using (var command = new MySqlCommand(query, connection)) {

					command.Parameters.AddWithValue("@Email", email);

					using (var reader = command.ExecuteReader()) {
						if (reader.Read()) {

							studentID = reader.GetInt64("ID");
							storedSalt = PasswordEncryption.HexStringToByteArray(reader.GetString("PasswordSalt"));
							storedHash = PasswordEncryption.HexStringToByteArray(reader.GetString("PasswordHash"));
						}
					}
				}
			}

			byte[] enteredHash = PasswordEncryption.HashPassword(password, storedSalt);

			if (PasswordEncryption.CompareByteArrays(enteredHash, storedHash))
			{ 
				return studentID;
			}
		

			return -1;

		}

		public static List <Student> getAllStudents()
		{
            var students = new List<Student>();
            string query = "SELECT s.ID, s.Name, c.Email, c.PhoneNumber FROM StudentInformation s JOIN StudentContactInformation c ON s.ID = c.ID";
            using (var conn = new MySqlConnection(dbSecret.connectionString))
            {
                conn.Open();
                using (var cmm = new MySqlCommand(query, conn))
                {

                    using (var reader = cmm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
							var student = new Student
							{
								Id = reader.GetInt64("ID"),
								name = reader.GetString("Name"),
								email = reader.GetString("Email"),
								pno = reader.GetString("PhoneNumber")
							};

                            students.Add(student);
                        }
                    }
                }

            }

            return students;
        }

        public static List<Student> getCourseStudents(long courseid)
        {
            var students = new List<Student>();
            String query = "SELECT s.Name, s.ID, c.PhoneNumber, c.Email " +
				"FROM StudentInformation s " +
				"JOIN StudentEnrollment e ON s.ID = e.StudentID " +
				"JOIN StudentContactInformation c ON c.ID = s.ID " +
				"WHERE e.CourseID = @courseid";

            using (var conn = new MySqlConnection(dbSecret.connectionString))
            {
                conn.Open();
                using (var cmm = new MySqlCommand(query, conn))
                {
					cmm.Parameters.AddWithValue("@courseid", courseid);
                    using (var reader = cmm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student = new Student
                            {
                                Id = reader.GetInt64("ID"),
                                name = reader.GetString("Name"),
                                email = reader.GetString("Email"),
                                pno = reader.GetString("PhoneNumber")
                            };

                            students.Add(student);
                        }
                    }
                }

            }

            return students;
        }
    }
}
