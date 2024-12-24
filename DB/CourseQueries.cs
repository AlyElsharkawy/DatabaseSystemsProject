using DatabaseSystemsProject.Models;
using DatabaseSystemsProject.UI.Instructor.Course.Creation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using DatabaseSystemsProject.UI.Student.Courses.MyCourses;
using Org.BouncyCastle.Ocsp;

namespace DatabaseSystemsProject.DB
{
	public class CourseQueries
	{
        static MySqlConnection connection;
        public static long CreateCourse(String name,decimal price,String thumbPath,String description, long instructorID)
		{
			String courseInsert = "INSERT INTO CourseInformation(Name, Description, ThumbnailPath, Cost) " +
				"VALUES (@Name, @Description, @Thumbnail, @Cost);";

			String relInsert = "INSERT INTO CourseInstructors(CourseID, InstructorID) " +
				"VALUES(@courseID, @instructorID) ";

			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				connection.Open();
				try
				{
					using (var trans = connection.BeginTransaction())
					{
						long id;
						using (var command = new MySqlCommand(courseInsert, connection))
						{

							command.Parameters.AddWithValue("@Name", name);
							command.Parameters.AddWithValue("@Description", description);
							command.Parameters.AddWithValue("@Cost", price);
							command.Parameters.AddWithValue("@Thumbnail", thumbPath);

							command.ExecuteNonQuery();

							id = command.LastInsertedId;
						}

                        using (var seccommand = new MySqlCommand(relInsert, connection))
                        {

                            seccommand.Parameters.AddWithValue("@courseID", id);
                            seccommand.Parameters.AddWithValue("@instructorID", instructorID);

                            seccommand.ExecuteNonQuery();

                        }
                        trans.Commit();
						return id;
					}
				}
				catch (Exception ex) {

					Console.WriteLine(ex.Message);
					return -1;
				}
			}
		}

        public static List<Course> getAllCourses()
        {
            var courses = new List<Course>();
            string query = "SELECT c.ID, c.Name, c.Description, c.ThumbnailPath, c.Cost " +
                "FROM CourseInformation c ";
            using (var conn = new MySqlConnection(dbSecret.connectionString))
            {
                conn.Open();
                using (var cmm = new MySqlCommand(query, conn))
                {
                    using (var reader = cmm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var course = new Course
                            {
                                Id = reader.GetInt64("ID"),
                                Name = reader.GetString("Name"),
                                Description = reader.GetString("Description"),
                                thumbPath = reader.GetString("ThumbnailPath"),
                                price = reader.GetDecimal("Cost")
                            };

                            courses.Add(course);
                        }
                    }
                }

            }

            return courses;
        }
        public static List<Course> getUnenrolledStudentCourses(long studentID)
		{
			var courses = new List<Course>();
			string query = "SELECT c.ID, c.Name, c.Description, c.ThumbnailPath, c.Cost " +
				"FROM CourseInformation c " +
				"LEFT JOIN StudentEnrollment se " +
				"ON c.ID = se.CourseID AND se.StudentID = @StudentID " +
				"WHERE se.CourseID IS NULL;";
			using (var conn = new MySqlConnection(dbSecret.connectionString)) { 
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn)) {
					cmm.Parameters.AddWithValue("@StudentID", studentID);
					using (var reader = cmm.ExecuteReader()) {
						while (reader.Read()) {
							var course = new Course
							{
								Id = reader.GetInt64("ID"),
								Name = reader.GetString("Name"),
								Description = reader.GetString("Description"),
								thumbPath = reader.GetString("ThumbnailPath"),
								price = reader.GetDecimal("Cost")
							};

							courses.Add(course);
						}
					}
				}
			
			}

			return courses;
		}
	
		public static void enrollStudent(long studentID, long courseID)
		{
			String query = "INSERT INTO StudentEnrollment(StudentID, CourseID) " +
							"VALUES (@StudentID, @CourseID)";

			using(var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				try
				{
					using (var trans = conn.BeginTransaction()) {
						using (var cmd = new MySqlCommand(query, conn))
						{
							cmd.Parameters.AddWithValue("@StudentID", studentID);
							cmd.Parameters.AddWithValue("@CourseID", courseID);

							cmd.ExecuteNonQuery();
						}

						trans.Commit();
					}
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}

		public static List<Course> getStudentCourses(long studentID)
		{
			var courses = new List<Course>();
			string query = "SELECT c.ID, c.Name, c.Description, c.ThumbnailPath " +
							"FROM StudentEnrollment se " +
							"JOIN CourseInformation c ON se.COURSEID = c.ID " +
							"WHERE se.StudentID = @StudentID";
			using (var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn))
				{
					cmm.Parameters.AddWithValue("@StudentID", studentID);
					using (var reader = cmm.ExecuteReader())
					{
						while (reader.Read())
						{
							var course = new Course
							{
								Id = reader.GetInt64("ID"),
								Name = reader.GetString("Name"),
								Description = reader.GetString("Description"),
								thumbPath = reader.GetString("ThumbnailPath"),
							};

							courses.Add(course);
						}
					}
				}

			}

			return courses;
		}

		public static List<Course> getInstructorCourses(long instructorID) {

			var courses = new List<Course>();
			string query = "SELECT c.ID, c.Name, c.Description, c.ThumbnailPath " +
							"FROM CourseInstructors se " +
							"JOIN CourseInformation c ON se.CourseID = c.ID " +
							"WHERE se.InstructorID = @instructorID";
			using (var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn))
				{
					cmm.Parameters.AddWithValue("@instructorID", instructorID);
					using (var reader = cmm.ExecuteReader())
					{
						while (reader.Read())
						{
							var course = new Course
							{
								Id = reader.GetInt64("ID"),
								Name = reader.GetString("Name"),
								Description = reader.GetString("Description"),
								thumbPath = reader.GetString("ThumbnailPath"),
							};

							courses.Add(course);
						}
					}
				}

			}

			return courses;
		}

		public static void addReviewtoCourse(String title, String content, byte rating, long courseID, long studentID)
		{
			String CourseReviews = "INSERT INTO CourseReviews (StudentID, CourseID, Title, CONTENT, Rating)" +
				"Values(@sid, @cid, @title, @content, @rating)";

            using (connection = new MySqlConnection(dbSecret.connectionString))
            {
                connection.Open();
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        long reviewID;
                        using (var reviewInfoCommand = new MySqlCommand(CourseReviews, connection, transaction))
                        {
                            reviewInfoCommand.Parameters.AddWithValue("@sid", studentID);
                            reviewInfoCommand.Parameters.AddWithValue("@cid", courseID);
                            reviewInfoCommand.Parameters.AddWithValue("@title", title);
                            reviewInfoCommand.Parameters.AddWithValue("@content", content);
                            reviewInfoCommand.Parameters.AddWithValue("@rating", rating);

                            reviewInfoCommand.ExecuteNonQuery();

                            reviewID = reviewInfoCommand.LastInsertedId;
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

		public static List<Review> getCourseReviews(long courseID)
		{
			String query = "SELECT ID,StudentID,CourseID,Title,CONTENT,Rating FROM CourseReviews WHERE CourseID = @courseID";
			List<Review> reviews = new List<Review>();
			using (var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn))
				{
					cmm.Parameters.AddWithValue("@courseID", courseID);
					using (var reader = cmm.ExecuteReader())
					{
						while (reader.Read())
						{
							var course = new Review
							{
								ID = reader.GetInt64("ID"),
								Title = reader.GetString("Title"),
								StudentID = reader.GetInt64("StudentID"),
								CONTENT = reader.GetString("CONTENT"),
								Rating = reader.GetByte("Rating"),
							};

							reviews.Add(course);
						}
					}
				}

			}

			return reviews;
		}

		public static bool hastWrittenReview(long courseID,long studentID)
		{
			String query = "SELECT COUNT(*) FROM CourseReviews WHERE CourseID = @courseID AND StudentID = @studentID";
			using (var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn))
				{
					cmm.Parameters.AddWithValue("@courseID", courseID);
					cmm.Parameters.AddWithValue("@studentID", studentID);
					var result = cmm.ExecuteScalar();
					return Convert.ToInt32(result) > 0;
				}

			}

		}

		public static void InsertStudentEarnedCertificate(long studentID, long courseID, long certificateID, DateTime expiryDate, string filePath, decimal grade = 10)
		{
			string query = @"
        INSERT INTO StudentEarnedCertificates (StudentID, CourseID, CertificateID, Grade, ExpiryDate, FilePath) 
        VALUES (@StudentID, @CourseID, @CertificateID, @Grade, @ExpiryDate, @FilePath);";

			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				connection.Open();

				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@StudentID", studentID);
					command.Parameters.AddWithValue("@CourseID", courseID);
					command.Parameters.AddWithValue("@CertificateID", certificateID);
					command.Parameters.AddWithValue("@Grade", grade);
					command.Parameters.AddWithValue("@ExpiryDate", expiryDate);
					command.Parameters.AddWithValue("@FilePath", filePath);

					command.ExecuteNonQuery(); // Execute the insert query
				}
			}
		}


		public static bool ifCertiExisit(long studentID, long CourseID)
		{
			bool certificateExists = false;
			string query = @"
            SELECT 
                CASE 
                    WHEN EXISTS (
                        SELECT 1
                        FROM StudentEarnedCertificates
                        WHERE StudentID = @StudentID
                        AND CourseID = @CourseID
                    ) THEN TRUE
                    ELSE FALSE
                END AS CertificateExists;
        ";

			using (MySqlConnection connection = new MySqlConnection(dbSecret.connectionString))
			{
				connection.Open();

				using (MySqlCommand command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@StudentID", studentID);
					command.Parameters.AddWithValue("@CourseID", CourseID);

					var result = command.ExecuteScalar();
					certificateExists = result != null && Convert.ToBoolean(result);
				}
			}

			return certificateExists;
		}

		public static void createCourseCertification(long courseID, String templatePATH, String name)
		{
			string query = "INSERT INTO CourseCertificate (CourseID, TemplateFilePath, Name) VALUES (@CourseID, @TemplateFilePath, @Name)";

			using (MySqlConnection connection = new MySqlConnection(dbSecret.connectionString))
			{
				try
				{
					connection.Open();

					using (MySqlCommand command = new MySqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@CourseID", courseID);
						command.Parameters.AddWithValue("@TemplateFilePath", templatePATH);
						command.Parameters.AddWithValue("@Name", name);

						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
	}
}
