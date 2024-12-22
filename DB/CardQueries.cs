using DatabaseSystemsProject.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DatabaseSystemsProject.DB
{
	public class CardQueries
	{
		public static void createBankCard(long number, long studentID, short expYear, byte expMonth, string nameOnCard, String type,String cvv)
		{
			String query = "INSERT INTO BankCard(ID,StudentID, ExpirationYear, ExpirationMonth, NameOnCard, Type, CVV) " +
				"VALUES(@ID, @StudentID, @ExpirationYear, @ExpirationMonth, @NameOnCard, @Type, @CVV);";

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

							command.Parameters.AddWithValue("@ID", number);
							command.Parameters.AddWithValue("@StudentID", studentID);
							command.Parameters.AddWithValue("@ExpirationYear", expYear);
							command.Parameters.AddWithValue("@ExpirationMonth", expMonth);
							command.Parameters.AddWithValue("@NameOnCard", nameOnCard);
							command.Parameters.AddWithValue("@Type", type);
							command.Parameters.AddWithValue("@CVV", cvv);

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

		public static List<BankCard> getStudentCards(int studentID)
		{
			List<BankCard> cards = new List<BankCard>();
			string query = "SELECT * FROM BankCard WHERE StudentID = @StudentID";
			using (var conn = new MySqlConnection(dbSecret.connectionString))
			{
				conn.Open();
				using (var cmm = new MySqlCommand(query, conn))
				{
					cmm.Parameters.AddWithValue("@StudentID", studentID);
					using (var reader = cmm.ExecuteReader()) {
						while (reader.Read()) { 
							var card = new BankCard
							{
								ID = reader.GetInt64("ID"),
								StudentID = reader.GetInt64("StudentID"),
								ExpirationYear = reader.GetInt16("ExpirationYear"),
								ExpirationMonth = reader.GetByte("ExpirationMonth"),
								NameOnCard = reader.GetString("NameOnCard"),
								Type = reader.GetString("Type"),
								CVV = reader.GetString("CVV")

							};

							cards.Add(card);
						}
					}

				}
			}

			return cards;
		}
	}
}
