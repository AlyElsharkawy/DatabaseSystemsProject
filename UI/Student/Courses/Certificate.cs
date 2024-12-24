using DatabaseSystemsProject.DB;
using DatabaseSystemsProject.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Student.Courses
{
	public partial class Certificate : Form
	{
		public Certificate(long studentID, long courseID)
		{
			InitializeComponent();
            var studentCertificate = loadCertificate(studentID, courseID);
            issueDate.Text = studentCertificate.IssueDate.Date.ToString();
            expiryDate.Text = studentCertificate.ExpiryDate.Date.ToString();
            certificateInfo.Text = "You have earned " + studentCertificate.certificateName.ToString() + " with a grade " + studentCertificate.Grade.ToString() +".";
            studentName.Text = "Mr, " + studentCertificate.studentName.ToString();
        }

		private static StudentCertificate loadCertificate(long studentID, long courseID)
		{
			String query = "SELECT CertificateID, IssueDate, Grade, ExpiryDate, StudentID, CourseID FROM StudentEarnedCertificates WHERE StudentID = @sid AND CourseID = @cid";
            var studentCertificate = new StudentCertificate();
            using (var conn = new MySqlConnection(dbSecret.connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmm = new MySqlCommand(query, conn))
                    {
                        cmm.Parameters.AddWithValue("@sid", studentID);
                        cmm.Parameters.AddWithValue("@cid", courseID);
                        using (var reader = cmm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                studentCertificate = new StudentCertificate
                                {
                                    Id = reader.GetInt64("CertificateID"),
                                    IssueDate = reader.GetDateTime("IssueDate"),
                                    ExpiryDate = reader.GetDateTime("ExpiryDate"),
                                    Grade = reader.GetInt64("Grade"),
                                    
                                    
                                };


                            }
                        }
                    }




                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                String query2 = "SELECT ID, Name FROM StudentInformation WHERE ID = @sid";
                try
                {
                    using (var cmm = new MySqlCommand(query2, conn))
                    {
                        cmm.Parameters.AddWithValue("@sid", studentID);
                        using (var reader = cmm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                studentCertificate.studentName = reader.GetString("Name");


                            }
                        }



                    }

                }
                catch (Exception ex) {
                Console.WriteLine(ex.Message);
                }


                String query3 = "SELECT Name, CourseID FROM CourseCertificate WHERE ID = @cid";

                try
                {
                    using (var cmm = new MySqlCommand(query3, conn))
                    {
                        cmm.Parameters.AddWithValue("@cid", studentCertificate.Id);
                        using (var reader = cmm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                studentCertificate.certificateName = reader.GetString("Name");
                              

                            }
                        }



                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }

                return studentCertificate;
            }

            

        }

	}
}
