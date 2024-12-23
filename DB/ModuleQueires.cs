﻿using DatabaseSystemsProject.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.DB
{
	public class ModuleQueires
	{
		public static long CreateModule(long courseID, String title)
		{
			String query = "INSERT INTO ModuleInformation(CourseID, Title) " +
							"VALUES(@CourseID, @Title);";


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

							command.Parameters.AddWithValue("@CourseID", courseID);
							command.Parameters.AddWithValue("@Title", title);

							command.ExecuteNonQuery();

							id = command.LastInsertedId;
						}

						trans.Commit();
						return id;
					}
				}
				catch (Exception ex)
				{

					return -1;

				}
			}

		}

		public static void deleteModule(long moduleID)
		{
			String query = "DELETE FROM ModuleInformation WHERE ID = @moduleID";


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

							command.Parameters.AddWithValue("@moduleID", moduleID);

							command.ExecuteNonQuery();

							id = command.LastInsertedId;
						}

						trans.Commit();

					}
				}
				catch (Exception ex)
				{


				}

			}
		}

		public static List<Module> getCourseModules(long courseID)
		{
			List<Module> modules = new List<Module>();
			string query = "SELECT ID, CourseID,Title " +
				"FROM ModuleInformation WHERE CourseID = @courseID ";
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
							var mod = new Module
							{
								moduleID = reader.GetInt64("ID"),
								courseID = reader.GetInt64("CourseID"),
								moduleTitle = reader.GetString("Title"),
							};

							modules.Add(mod);
						}
					}
				}

			return modules;
		}

	}

		public static List<Video> getModuleVideos(long moduleID) {
			String query = "SELECT * FROM QuestionVideo WHERE ModuleID = @modID";
			List<Video> videos = new List<Video>();
			using (var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn))
				{
					cmm.Parameters.AddWithValue("@modID", moduleID);
					using (var reader = cmm.ExecuteReader())
					{
						while (reader.Read())
						{
							var mod = new Video
							{
								Id = reader.GetInt64("ID"),
								modID = reader.GetInt64("ModuleID"),
								courseID = reader.GetInt64("CourseID"),
								title = reader.GetString("Title"),
								filePath = reader.GetString("FilePath")
							};

							videos.Add(mod);
						}
					}
				}

				return videos;
			}
		}

		public static List<mcq> getModuleMCQs(long moduleID)
		{
			String query = "SELECT * FROM QuestionMultipleChoice WHERE ModuleID = @modID";
			List<mcq> mcqs = new List<mcq>();
			using (var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn))
				{
					cmm.Parameters.AddWithValue("@modID", moduleID);
					using (var reader = cmm.ExecuteReader())
					{
						while (reader.Read())
						{
							var mod = new mcq
							{
								ID = reader.GetInt64("ID"),
								ModuleID = reader.GetInt64("ModuleID"),
								CourseID = reader.GetInt64("CourseID"),
								Prompt = reader.GetString("Prompt"),
								MaxGrade = reader.GetByte("MaxGrade"),
								QuestionOne = reader.GetString("QuestionOne"),
								QuestionTwo = reader.GetString("QuestionTwo"),
								QuestionThree = reader.GetString("QuestionThree"),
								QuestionFour = reader.GetString("QuestionFour"),
								CorrectAnswer = reader.GetByte("CorrectAnswer")
							};

							mcqs.Add(mod);
						}
					}
				}

				return mcqs;
			}
		}

		public static List<Assignment> getModuleAssignments(long moduleID)
		{
			String query = "SELECT * FROM QuestionAssignment WHERE ModuleID = @modID";
			List<Assignment> mcqs = new List<Assignment>();
			using (var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn))
				{
					cmm.Parameters.AddWithValue("@modID", moduleID);
					using (var reader = cmm.ExecuteReader())
					{
						while (reader.Read())
						{
							var mod = new Assignment
							{
								ID = reader.GetInt64("ID"),
								ModuleID = reader.GetInt64("ModuleID"),
								CourseID = reader.GetInt64("CourseID"),
								Prompt = reader.GetString("Prompt"),
								MaxGrade = reader.GetByte("MaxGrade"),
								
							};

							mcqs.Add(mod);
						}
					}
				}

				return mcqs;
			}
		}

		public static List<SAQ> getModuleSAQs(long moduleID)
		{
			String query = "SELECT * FROM QuestionShortAnswer WHERE ModuleID = @modID";
			List<SAQ> mcqs = new List<SAQ>();
			using (var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn))
				{
					cmm.Parameters.AddWithValue("@modID", moduleID);
					using (var reader = cmm.ExecuteReader())
					{
						while (reader.Read())
						{
							var mod = new SAQ
							{
								ID = reader.GetInt64("ID"),
								ModuleID = reader.GetInt64("ModuleID"),
								CourseID = reader.GetInt64("CourseID"),
								Prompt = reader.GetString("Prompt"),
								MaxGrade = reader.GetByte("MaxGrade"),

							};

							mcqs.Add(mod);
						}
					}
				}

				return mcqs;
			}
		}


		public static List<TFQ> getModuleTFQs(long moduleID)
		{
			String query = "SELECT * FROM QuestionTrueFalse WHERE ModuleID = @modID";
			List<TFQ> mcqs = new List<TFQ>();
			using (var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn))
				{
					cmm.Parameters.AddWithValue("@modID", moduleID);
					using (var reader = cmm.ExecuteReader())
					{
						while (reader.Read())
						{
							var mod = new TFQ
							{
								ID = reader.GetInt64("ID"),
								ModuleID = reader.GetInt64("ModuleID"),
								CourseID = reader.GetInt64("CourseID"),
								Prompt = reader.GetString("Prompt"),
								MaxGrade = reader.GetByte("MaxGrade"),
								CorrectAnswer = reader.GetByte("CorrectAnswer")

							};

							mcqs.Add(mod);
						}
					}
				}

				return mcqs;
			}
		}


		public static List<Reading> getModuleReadings(long moduleID)
		{
			String query = "SELECT * FROM QuestionReading WHERE ModuleID = @modID";
			List<Reading> mcqs = new List<Reading>();
			using (var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn))
				{
					cmm.Parameters.AddWithValue("@modID", moduleID);
					using (var reader = cmm.ExecuteReader())
					{
						while (reader.Read())
						{
							var mod = new Reading
							{
								ID = reader.GetInt64("ID"),
								ModuleID = reader.GetInt64("ModuleID"),
								CourseID = reader.GetInt64("CourseID"),
								Content = reader.GetString("Content"),
								Title = reader.GetString("Title"),

							};

							mcqs.Add(mod);
						}
					}
				}

				return mcqs;
			}
		}

	}
}
