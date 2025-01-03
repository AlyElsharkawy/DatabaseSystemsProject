﻿using DatabaseSystemsProject.Models;
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
			decimal grade = 0;
			if(chosenAnswer == mcq.CorrectAnswer)
			{
				grade = mcq.MaxGrade;
			}
			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				try
				{
					connection.Open();

					string query = "INSERT INTO SolvedQuestionMultipleChoice (ID, ModuleID, CourseID, StudentID, StudentAnswer,Grade) " +
								   "VALUES (@ID, @ModuleID, @CourseID, @StudentID, @StudentAnswer,@Grade)";

					using (var command = new MySqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@ID", mcq.ID);
						command.Parameters.AddWithValue("@ModuleID", mcq.ModuleID);
						command.Parameters.AddWithValue("@CourseID", mcq.CourseID);
						command.Parameters.AddWithValue("@StudentID", studentID);
						command.Parameters.AddWithValue("@StudentAnswer", chosenAnswer);
						command.Parameters.AddWithValue("@Grade", grade);

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
			decimal grade = 0;
			if (choosenAnswer == tfq.CorrectAnswer)
			{
				grade = tfq.MaxGrade;
			}
			using (var connection = new MySqlConnection(dbSecret.connectionString))
			{
				try
				{
					connection.Open();

					string query = "INSERT INTO SolvedQuestionTrueFalse (ID, ModuleID, CourseID, StudentID, StudentAnswer,Grade) " +
								   "VALUES (@ID, @ModuleID, @CourseID, @StudentID, @StudentAnswer,@Grade)";

					using (var command = new MySqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@ID", tfq.ID);
						command.Parameters.AddWithValue("@ModuleID", tfq.ModuleID);
						command.Parameters.AddWithValue("@CourseID", tfq.CourseID);
						command.Parameters.AddWithValue("@StudentID", studentID);
						command.Parameters.AddWithValue("@StudentAnswer", choosenAnswer);
						command.Parameters.AddWithValue("@Grade", grade);

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



		public static bool isMcqSolved(long studentId, long moduleId, long courseId, long questionId)
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

		public static bool isTFSolved(long studentId, long moduleId, long courseId, long questionId)
		{
			string query = "SELECT COUNT(*) FROM SolvedQuestionTrueFalse WHERE StudentID = @studentId AND ModuleID = @moduleId AND CourseID = @courseId AND ID = @questionId";

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

		public static bool isAssignSolved(long studentId, long moduleId, long courseId, long questionId)
		{
			string query = "SELECT COUNT(*) FROM SolvedAssignment WHERE StudentID = @studentId AND ModuleID = @moduleId AND CourseID = @courseId AND ID = @questionId";

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

		public static bool isSAQSolved(long studentId, long moduleId, long courseId, long questionId)
		{
			string query = "SELECT COUNT(*) FROM SolvedShortAnswerQuestion WHERE StudentID = @studentId AND ModuleID = @moduleId AND CourseID = @courseId AND ID = @questionId";

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


        public static List<SolvedAssignment> assignSolved(long courseId, long studentId)
        {
            string query = "SELECT sa.ID, sa.SolvedDate, sa.Grade, m.Title  FROM SolvedAssignment sa JOIN ModuleInformation m " +
				"ON m.ID = sa.ModuleID " +
				"WHERE sa.StudentID = @studentId " +
				"AND " +
				"sa.CourseID = @courseId";
            List<SolvedAssignment> sa = new List<SolvedAssignment>();
            using (var connection = new MySqlConnection(dbSecret.connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
					command.Parameters.AddWithValue("@studentId", studentId);
                    command.Parameters.AddWithValue("@courseId", courseId);
					using (var reader = command.ExecuteReader())
					{
						SolvedAssignment sa1 = new SolvedAssignment();
                        while (reader.Read())
                        {
							sa1.ID = reader.GetInt64("ID");
							sa1.SolvedDate = reader.GetDateTime("SolvedDate");
							sa1.ModuleTitle = reader.GetString("Title");
							try
							{
								sa1.Grade = reader.GetDecimal("Grade");
							}
							catch
							{
								sa1.Grade = null;
							}
                        }
						sa.Add(sa1);
                    }
                }
            }

			return sa;
        }

        public static List<SolvedShortAnswer> sAQSolved(long courseId, long studentId)
        {
            string query = "SELECT sa.ID, sa.SolvedDate, sa.Grade, m.Title  FROM SolvedShortAnswerQuestion sa JOIN ModuleInformation m ON m.ID = sa.ModuleID WHERE sa.StudentID = @studentId AND sa.CourseID = @courseId";
            List<SolvedShortAnswer> sa = new List<SolvedShortAnswer>();
            using (var connection = new MySqlConnection(dbSecret.connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentId", studentId);
                    command.Parameters.AddWithValue("@courseId", courseId);

                    using (var reader = command.ExecuteReader())
                    {
						SolvedShortAnswer sa1 = new SolvedShortAnswer();
                        while (reader.Read())
                        {
                            sa1.ID = reader.GetInt64("ID");
                            sa1.SolvedDate = reader.GetDateTime("SolvedDate");
                            sa1.ModuleTitle = reader.GetString("Title");
                            try
                            {
                                sa1.Grade = reader.GetDecimal("Grade");
                            }
                            catch
                            {
                                sa1.Grade = null;
                            }

							sa.Add(sa1);
                        }
                        
                    }
                }
				return sa;
            }
        }

		public static String studentSA(long studentId, long questionId)
		{
			String query = "SELECT StudentAnswer FROM SolvedShortAnswerQuestion WHERE StudentID = @studentId AND ID = @questionId ";
			String ans = "";
            using (var connection = new MySqlConnection(dbSecret.connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentId", studentId);
                    command.Parameters.AddWithValue("@questionId", questionId);
                    using (var reader = command.ExecuteReader())
                    {
                        SolvedAssignment sa1 = new SolvedAssignment();
                        while (reader.Read())
                        {
							ans = reader.GetString("StudentAnswer");
                        }
                    }
                }
				return ans.ToString();
            }
        }
    }
}
