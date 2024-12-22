using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.DB
{
	public class InvoiceQueries
	{
		static public void createInvoice(long studentID,long courseID, long cardID, decimal cost)
		{
			String query = "INSERT INTO InvoiceInformation(CourseID, StudentID, CardID, TotalCost)" +
							"VALUES(@CourseID, @StudentID, @CardID, @TotalCost);";

			using (var conn = new MySqlConnection(dbSecret.connectionString)) { 
				conn.Open();
				try
				{
					using (var trans = conn.BeginTransaction())
					{
						using (var cmd = new MySqlCommand(query, conn))
						{
							cmd.Parameters.AddWithValue("@CourseID", courseID);
							cmd.Parameters.AddWithValue("@StudentID", studentID);
							cmd.Parameters.AddWithValue("@CardID", cardID);
							cmd.Parameters.AddWithValue("@TotalCost", cost);

							cmd.ExecuteNonQuery();

						}

						trans.Commit();
					}
				}
				catch (Exception ex) {
					Console.WriteLine(ex.Message);
				}
			}
		}
	}
}
