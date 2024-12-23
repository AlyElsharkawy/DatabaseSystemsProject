using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DatabaseSystemsProject.DB
{
	public class SubSectionsQueries
	{
		public static void createVideo(long modID, long courseID, String title, String filePath)
		{
			String query = "INSERT INTO QuestionVideo(ModuleID, CourseID, Title, FilePath) " +
				"VALUES(@ModuleID, @CourseID, @Title, @FilePath);";

			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				connection.Open();
				try
				{
					using (var trans = connection.BeginTransaction())
					{
						long id;
						using (var command = new MySqlCommand(query, connection))
						{

							command.Parameters.AddWithValue("@ModuleID", modID);
							command.Parameters.AddWithValue("@CourseID", courseID);
							command.Parameters.AddWithValue("@Title", title);
							command.Parameters.AddWithValue("@FilePath", filePath);

							command.ExecuteNonQuery();

							id = command.LastInsertedId;
						}

						trans.Commit();
					
					}
				}
				catch (Exception ex)
				{

					Console.WriteLine(ex.ToString());
				}
			}


		}

		public static void createReading(long modID, long courseID, String title, String content)
		{
			String query = "INSERT INTO QuestionVideo(ModuleID, CourseID, Title, Content) " +
				"VALUES(@ModuleID, @CourseID, @Title, @Content);";

			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				connection.Open();
				try
				{
					using (var trans = connection.BeginTransaction())
					{
						long id;
						using (var command = new MySqlCommand(query, connection))
						{

							command.Parameters.AddWithValue("@ModuleID", modID);
							command.Parameters.AddWithValue("@CourseID", courseID);
							command.Parameters.AddWithValue("@Title", title);
							command.Parameters.AddWithValue("@Content", content);

							command.ExecuteNonQuery();

							id = command.LastInsertedId;
						}

						trans.Commit();

					}
				}
				catch (Exception ex)
				{

					Console.WriteLine(ex.ToString());
				}
			}


		}

		public static void createSAQ(long modID, long courseID, String prompt, byte maxGrade)
		{
			String query = "INSERT INTO QuestionVideo(ModuleID, CourseID, Prompt, MaxGrade) " +
				"VALUES(@ModuleID, @CourseID, @Prompt, @MaxGrade);";

			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				connection.Open();
				try
				{
					using (var trans = connection.BeginTransaction())
					{
						long id;
						using (var command = new MySqlCommand(query, connection))
						{

							command.Parameters.AddWithValue("@ModuleID", modID);
							command.Parameters.AddWithValue("@CourseID", courseID);
							command.Parameters.AddWithValue("@Prompt", prompt);
							command.Parameters.AddWithValue("@MaxGrade", maxGrade);

							command.ExecuteNonQuery();

							id = command.LastInsertedId;
						}

						trans.Commit();

					}
				}
				catch (Exception ex)
				{

					Console.WriteLine(ex.ToString());
				}
			}


		}

	}
}
