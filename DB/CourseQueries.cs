using DatabaseSystemsProject.Models;
using DatabaseSystemsProject.UI.Instructor.Course.Creation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.DB
{
	public class CourseQueries
	{
		public static long CreateCourse(String name,decimal price,String thumbPath,String description)
		{
			String courseInsert = "INSERT INTO CourseInformation(Name, Description, ThumbnailPath, Cost) " +
				"VALUES (@Name, @Description, @Thumbnail, @Cost);";


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

						trans.Commit();
						return id;
					}
				}
				catch (Exception ex) {

					return -1;
				}
			}
		}


		public static List<Course> getAllCourses()
		{
			var courses = new List<Course>();
			string query = "SELECT ID, Name, Description, ThumbnailPath, Cost FROM CourseInformation";
			using (var conn = new MySqlConnection(dbSecret.connectionString)) { 
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn)) {

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
	}
}
