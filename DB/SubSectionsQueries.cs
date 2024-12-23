using DatabaseSystemsProject.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
			String query = "INSERT INTO QuestionReading(ModuleID, CourseID, Title, Content) " +
							"VALUES (@ModuleID, @CourseID, @Title, @Content);";

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

		public static long createSAQ(long modID, long courseID, String prompt, byte maxGrade)
		{
			String query = "INSERT INTO QuestionShortAnswer(ModuleID, CourseID, Prompt, MaxGrade) " +
							"VALUES (@ModuleID, @CourseID, @Prompt, @MaxGrade)";

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

						return id;

					}
				}
				catch (Exception ex)
				{

					Console.WriteLine(ex.ToString());
					return -1;
				}
			}


		}

		public static long createMCQ(long modID, long courseID, String prompt, byte maxGrade,byte correctAnswerIndex,String q1,String q2,String q3,String q4)
		{
			String query = "INSERT INTO QuestionMultipleChoice(CourseID, ModuleID, MaxGrade, Prompt, CorrectAnswer, QuestionOne, QuestionTwo, QuestionThree, QuestionFour)" +
							"VALUES(@CourseID, @ModuleID, @MaxGrade, @Prompt, @CorrectAnswer, @QuestionOne, @QuestionTwo, @QuestionThree, @QuestionFour); ";

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
							command.Parameters.AddWithValue("@CorrectAnswer", correctAnswerIndex);
							command.Parameters.AddWithValue("@QuestionOne", q1);
							command.Parameters.AddWithValue("@QuestionTwo", q2);
							command.Parameters.AddWithValue("@QuestionThree", q3);
							command.Parameters.AddWithValue("@QuestionFour", q4);

							command.ExecuteNonQuery();

							id = command.LastInsertedId;
						}

						trans.Commit();
						return id;
					}
				}
				catch (Exception ex)
				{

					Console.WriteLine(ex.ToString());
					return -1;
				}
			}


		}

		public static void createAssignemnt(long modID, long courseID, String prompt, byte maxGrade)
		{
			String query = "INSERT INTO QuestionAssignment(ModuleID, CourseID, Prompt, MaxGrade)" +
							"VALUES(@ModuleID, @CourseID, @Prompt, @MaxGrade); ";

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

		public static void createTFQ(long modID, long courseID, String prompt, byte maxGrade, byte correctAnswerIndex)
		{
			String query = "INSERT INTO QuestionTrueFalse(ModuleID, CourseID, Prompt, MaxGrade, CorrectAnswer)"+
							"VALUES(@ModuleID, @CourseID, @Prompt, @MaxGrade, @CorrectAnswer); ";

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
							command.Parameters.AddWithValue("@CorrectAnswer", correctAnswerIndex);

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
