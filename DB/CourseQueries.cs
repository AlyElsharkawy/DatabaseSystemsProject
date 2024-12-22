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
		public static long CreateCourse(String name,double price,String thumbPath,String description)
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
	}
}
