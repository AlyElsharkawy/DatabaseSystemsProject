﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Student.Payment
{
	public partial class AllCards : Form
	{
		public AllCards()
		{
			InitializeComponent();
			loadDummyData();
		}

		private void loadDummyData()
		{
			var items = new[]
			{
				new { Name="Belal Salem", Type = "Master Card", Number = "47**"},
				new { Name="Belal Salem", Type = "Visa", Number = "53**"},
				new { Name="Belal Salem", Type = "Visa", Number = "24**"},
			};

			foreach (var item in items)
			{
				Panel cardPanel = new Panel
				{
					Width = 350,
					Height = 100,
					Margin = new Padding(10),
					BorderStyle = BorderStyle.FixedSingle
				};

				Label cardName = new Label
				{
					Text = item.Name,
					Font = new Font("Arial", 10, FontStyle.Bold),
					Location = new Point(10, 10),
					Width = 100
				};

				Label cardType = new Label
				{
					Text = item.Type,
					Font = new Font("Arial", 10, FontStyle.Bold),
					Location = new Point(10, 35),
					Width = 100
				};

				Label cardNumber = new Label
				{
					Text = item.Number,
					Location = new Point(10, 60),
					Width = 100
				};

				Button cardBTN = new Button
				{
					Text = "Select",
					Location = new Point(250, 25),
					Width = 80,
					Height = 50
				};


				cardBTN.Click += (sender, e) => { MessageBox.Show($"You selected {item.Type}"); };
				cardPanel.Controls.Add( cardName);
				cardPanel.Controls.Add(cardType);
				cardPanel.Controls.Add(cardNumber);
				cardPanel.Controls.Add(cardBTN);

				cardsFLP.Controls.Add(cardPanel);

			}
		}


	}
}
