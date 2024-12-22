﻿using MySql.Data.MySqlClient;
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

	}
}
