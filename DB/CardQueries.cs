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
	}
}
