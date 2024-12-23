using DatabaseSystemsProject.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

		public static long createAssignemnt(long modID, long courseID, String prompt, byte maxGrade)
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

		public static long createTFQ(long modID, long courseID, String prompt, byte maxGrade, byte correctAnswerIndex)
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



		public static void createSolvedMCQ(mcq mcq, byte chosenAnswer,long studentID)
		{
			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				try
				{
					connection.Open();

					string query = "INSERT INTO SolvedQuestionMultipleChoice (ID, ModuleID, CourseID, StudentID, StudentAnswer) " +
								   "VALUES (@ID, @ModuleID, @CourseID, @StudentID, @StudentAnswer)";

					using (var command = new MySqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@ID", mcq.ID);
						command.Parameters.AddWithValue("@ModuleID", mcq.ModuleID);
						command.Parameters.AddWithValue("@CourseID", mcq.CourseID);
						command.Parameters.AddWithValue("@StudentID", studentID);
						command.Parameters.AddWithValue("@StudentAnswer", chosenAnswer);

						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"An error occurred: {ex.Message}");
				}
			}
		}

		public static void createSolvedSAQ(SAQ saq, String answer, long studentID)
		{
			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				try
				{
					connection.Open();

					string query = "INSERT INTO SolvedShortAnswerQuestion (ID, ModuleID, CourseID, StudentID, StudentAnswer) " +
								   "VALUES (@ID, @ModuleID, @CourseID, @StudentID, @StudentAnswer)";

					using (var command = new MySqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@ID", saq.ID);
						command.Parameters.AddWithValue("@ModuleID", saq.ModuleID);
						command.Parameters.AddWithValue("@CourseID", saq.CourseID);
						command.Parameters.AddWithValue("@StudentID", studentID);
						command.Parameters.AddWithValue("@StudentAnswer", answer);

						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"An error occurred: {ex.Message}");
				}
			}
		}

		public static void createSolvedAssignment(Assignment assign, String filePath, long studentID)
		{
			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				try
				{
					connection.Open();

					string query = "INSERT INTO SolvedAssignment (ID, ModuleID, CourseID, StudentID, StudentAnswer) " +
								   "VALUES (@ID, @ModuleID, @CourseID, @StudentID, @StudentAnswer)";

					using (var command = new MySqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@ID", assign.ID);
						command.Parameters.AddWithValue("@ModuleID", assign.ModuleID);
						command.Parameters.AddWithValue("@CourseID", assign.CourseID);
						command.Parameters.AddWithValue("@StudentID", studentID);
						command.Parameters.AddWithValue("@StudentAnswer", filePath);

						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"An error occurred: {ex.Message}");
				}
			}
		}

		public static void createSolvedTFQ(TFQ tfq, byte choosenAnswer, long studentID)
		{
			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				try
				{
					connection.Open();

					string query = "INSERT INTO SolvedQuestionTrueFalse (ID, ModuleID, CourseID, StudentID, StudentAnswer) " +
								   "VALUES (@ID, @ModuleID, @CourseID, @StudentID, @StudentAnswer)";

					using (var command = new MySqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@ID", tfq.ID);
						command.Parameters.AddWithValue("@ModuleID", tfq.ModuleID);
						command.Parameters.AddWithValue("@CourseID", tfq.CourseID);
						command.Parameters.AddWithValue("@StudentID", studentID);
						command.Parameters.AddWithValue("@StudentAnswer", choosenAnswer);

						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"An error occurred: {ex.Message}");
				}
			}
		}

		public static void markVideoSeen(Video video, long studentID) {

			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				try
				{
					connection.Open();

					string query = "INSERT INTO SolvedQuestionVideo (ID, ModuleID, CourseID, StudentID) " +
								   "VALUES (@ID, @ModuleID, @CourseID, @StudentID)";

					using (var command = new MySqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@ID", video.Id);
						command.Parameters.AddWithValue("@ModuleID", video.modID);
						command.Parameters.AddWithValue("@CourseID", video.courseID);
						command.Parameters.AddWithValue("@StudentID", studentID);
						command.Parameters.AddWithValue("@IsDone", 1);

						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"An error occurred: {ex.Message}");
				}
			}
		}

		public static void markReadingSeen(Reading reading, long studentID) {
			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				try
				{
					connection.Open();

					string query = "INSERT INTO SolvedQuestionReading (ID, ModuleID, CourseID, StudentID) " +
								   "VALUES (@ID, @ModuleID, @CourseID, @StudentID )";

					using (var command = new MySqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@ID", reading.ID);
						command.Parameters.AddWithValue("@ModuleID", reading.ModuleID);
						command.Parameters.AddWithValue("@CourseID", reading.CourseID);
						command.Parameters.AddWithValue("@StudentID", studentID);

						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"An error occurred: {ex.Message}");
				}
			}

		}



		private bool mcqSolved(long studentId, long moduleId, long courseId, long questionId)
		{
			string query = "SELECT COUNT(*) FROM SolvedQuestionMultipleChoice WHERE StudentID = @studentId AND ModuleID = @moduleId AND CourseID = @courseId AND ID = @questionId";

			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@studentId", studentId);
					command.Parameters.AddWithValue("@moduleId", moduleId);
					command.Parameters.AddWithValue("@courseId", courseId);
					command.Parameters.AddWithValue("@questionId", questionId);

					var result = command.ExecuteScalar();
					return Convert.ToInt32(result) > 0; 
				}
			}
		}
	}
}
