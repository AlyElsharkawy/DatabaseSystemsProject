using AxWMPLib;
using DatabaseSystemsProject.DB;
using DatabaseSystemsProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Student.Courses
{
	public partial class ModulesView : Form
	{
		Course selectedCourse;
		long studentID;

		Dictionary<long, List<long>> ModulesMCQs = new Dictionary<long, List<long>>();
		Dictionary<long, List<long>> ModulesAssigns = new Dictionary<long, List<long>>();
		Dictionary<long, List<long>> ModulesSAQs = new Dictionary<long, List<long>>();
		Dictionary<long, List<long>> ModulesTFQs = new Dictionary<long, List<long>>();



		public ModulesView(Course recievedCourse,long rStudentID)
		{
			InitializeComponent();

			selectedCourse = recievedCourse;
			studentID = rStudentID;	
			loadModules();

		}


		AxWindowsMediaPlayer mediaplayerInstance;

		int mcqIndex = 1;
		int assignIndex = 1;
		int saqIndex = 1;
		int tfIndex = 1;

		private void loadModules()
		{
			var modules = ModuleQueires.getCourseModules(selectedCourse.Id);
			foreach (var module in modules) {
				var enteredNode = modulesTV.Nodes.Add(module.moduleTitle);
				

				var videos = ModuleQueires.getModuleVideos(module.moduleID);
				foreach (var video in videos) {
					var videoNode = modulesTV.Nodes[enteredNode.Index].Nodes.Add(video.title);
					videoNode.Tag = video;
				}



				var mcqs = ModuleQueires.getModuleMCQs(module.moduleID);
				foreach (var mcq in mcqs)
				{
					var node = modulesTV.Nodes[enteredNode.Index].Nodes.Add($"MCQ{mcqIndex++}");
					node.Tag = mcq;
					if (!ModulesMCQs.ContainsKey(module.moduleID))
					{
						ModulesMCQs[module.moduleID] = new List<long>();
					}
					ModulesMCQs[module.moduleID].Add(mcq.ID);

				}

				var assignments = ModuleQueires.getModuleAssignments(module.moduleID);
				foreach (var assignment in assignments)
				{
					var assignmentNode = modulesTV.Nodes[enteredNode.Index].Nodes.Add($"Assignment{assignIndex++}");
					assignmentNode.Tag = assignment;

					if (!ModulesAssigns.ContainsKey(module.moduleID))
					{
						ModulesAssigns[module.moduleID] = new List<long>();
					}
					ModulesAssigns[module.moduleID].Add(assignment.ID);
				}

				var saqs = ModuleQueires.getModuleSAQs(module.moduleID);
				foreach (var saq in saqs)
				{
					var saqNode = modulesTV.Nodes[enteredNode.Index].Nodes.Add($"Short Question{saqIndex++}");
					saqNode.Tag = saq;

					if (!ModulesSAQs.ContainsKey(module.moduleID))
					{
						ModulesSAQs[module.moduleID] = new List<long>();
					}
					ModulesSAQs[module.moduleID].Add(saq.ID);

				}

				var readings = ModuleQueires.getModuleReadings(module.moduleID);
				foreach (var reading in readings)
				{
					var readingNode = modulesTV.Nodes[enteredNode.Index].Nodes.Add(reading.Title);
					readingNode.Tag = reading;
				}

				var tfquestions = ModuleQueires.getModuleTFQs(module.moduleID);
				foreach (var tf in tfquestions)
				{
					var tfNode = modulesTV.Nodes[enteredNode.Index].Nodes.Add($"True/False{tfIndex++}");
					tfNode.Tag = tf;

					if (!ModulesTFQs.ContainsKey(module.moduleID))
					{
						ModulesTFQs[module.moduleID] = new List<long>();
					}
					ModulesTFQs[module.moduleID].Add(tf.ID);

				}
			}
		}

		private void selectBTN_Click(object sender, EventArgs e)
		{
			if(modulesTV.SelectedNode == null)
			{
				return;
			}

			var selectedNode = modulesTV.SelectedNode;
			var selectedTag = selectedNode.Tag;
			if (selectedTag == null)
			{
				return;
			}



			clearWork();
			switch (selectedTag)
			{
					
				case Video video:
					loadVideo(video);
					break;
				case mcq mcq:
					loadMcq(mcq);
					break;
				case Assignment assignment:
					loadAssignment(assignment);
					break;
				case SAQ saq:
					loadSaq(saq);
					break;
				case Reading reading:
					loadReading(reading);
					break;
				case TFQ tfq:
					loadTfq(tfq);
					break;
				default:
					MessageBox.Show("Unknown type selected.");
					break;
			}


		}



		private void loadVideo(Video video)
		{
			
			Panel videoPanel = new Panel();
			videoPanel.Size = new Size(600, 385);  
			videoPanel.Margin = new Padding(5);

			
			Label videoTitleLabel = new Label();
			videoTitleLabel.Text = $"Title: {video.title}";
			videoTitleLabel.Size = new Size(200, 20);
			videoTitleLabel.Location = new Point(5, 5);
			videoPanel.Controls.Add(videoTitleLabel);


			mediaplayerInstance = new AxWindowsMediaPlayer();
			mediaplayerInstance.Name = "axWindowsMediaPlayer";
			mediaplayerInstance.Size = new Size(680, 350);
			mediaplayerInstance.Location = new Point(5, 30); 
			videoPanel.Controls.Add(mediaplayerInstance);
			mediaplayerInstance.CreateControl();
			mediaplayerInstance.URL = "D:\\Movies\\The Wind Rises (2013) [1080p] [BluRay] [YTS.MX]\\The Wind Rises (2013).mp4";
			mediaplayerInstance.Ctlcontrols.play();    

			
			Button viewButton = new Button();
			viewButton.Text = "Start";
			viewButton.Size = new Size(100, 30);
			viewButton.Location = new Point(5, 160); 
			viewButton.Click += (sender, e) => mediaplayerInstance.Ctlcontrols.play(); 
			videoPanel.Controls.Add(viewButton);

			
			moduleFLP.Controls.Add(videoPanel);
		}

		private void loadMcq(mcq mcq)
		{
			
			Panel mcqPanel = new Panel();
			mcqPanel.Size = new Size(600, 385); 
			mcqPanel.Margin = new Padding(5);

		
			Label mcqLabel = new Label();
			mcqLabel.Text = $"Question: {mcq.Prompt}";
			mcqLabel.Size = new Size(590, 40); 
			mcqLabel.Location = new Point(5, 10);
			mcqLabel.TextAlign = ContentAlignment.MiddleCenter; 
			mcqPanel.Controls.Add(mcqLabel);

			FlowLayoutPanel optionsPanel = new FlowLayoutPanel();
			optionsPanel.Size = new Size(590, 150);  
			optionsPanel.Location = new Point(5, 60);
			optionsPanel.FlowDirection = FlowDirection.TopDown;
			optionsPanel.WrapContents = false;
			optionsPanel.AutoSize = true;

			RadioButton option1 = new RadioButton()
			{
				Text = mcq.QuestionOne,
				Size = new Size(200,30),
				Tag = (byte)1
				
			};

			RadioButton option2 = new RadioButton()
			{
				Text = mcq.QuestionTwo,
				Size = new Size(200, 30),
				Tag = (byte)2
			};

			RadioButton option3 = new RadioButton()
			{
				Text = mcq.QuestionThree,
				Size = new Size(200, 30),
				Tag = (byte)3
			};

			RadioButton option4 = new RadioButton()
			{
				Text = mcq.QuestionFour,
				Size = new Size(200, 30),
				Tag = (byte)4
			};

			optionsPanel.Controls.Add(option1);
			optionsPanel.Controls.Add(option2);
			optionsPanel.Controls.Add(option3);
			optionsPanel.Controls.Add(option4);


			mcqPanel.Controls.Add(optionsPanel);

		
			Button submitButton = new Button();
			submitButton.Text = "Submit";
			submitButton.Size = new Size(100, 30);
			submitButton.Location = new Point(250, 230);  
			submitButton.Click += (sender, e) =>
			{
				
					foreach (var control in optionsPanel.Controls)
					{
						if (control is RadioButton radioButton && radioButton.Checked)
						{
							solveMCQ(mcq, (byte)radioButton.Tag);
							submitButton.Enabled = false;

							break;
						}
					}
				
				};

			if (SubSectionsQueries.isMcqSolved(studentID, mcq.ModuleID, mcq.CourseID, mcq.ID))
			{
				submitButton.Enabled = false;
			}
			mcqPanel.Controls.Add(submitButton);

		
			moduleFLP.Controls.Add(mcqPanel);
		}

		private void loadAssignment(Assignment assignment)
		{
			Panel assignmentPanel = new Panel();
			assignmentPanel.Size = new Size(600, 385);
			assignmentPanel.Margin = new Padding(5);

			Label promptLabel = new Label();
			promptLabel.Text = $"Prompt: {assignment.Prompt}";
			promptLabel.Size = new Size(580, 100);
			promptLabel.Location = new Point(10, 10);
			assignmentPanel.Controls.Add(promptLabel);

			Button uploadButton = new Button();
			uploadButton.Text = "Upload Solution";
			uploadButton.Size = new Size(150, 30);
			uploadButton.Location = new Point(150, 150);
			uploadButton.Click += (sender, e) =>
			{
				
					using (OpenFileDialog openFileDialog = new OpenFileDialog())
					{
						openFileDialog.Filter = "PDF Files|*.pdf|All Files|*.*";
						if (openFileDialog.ShowDialog() == DialogResult.OK)
						{
							solveAssignment(assignment, openFileDialog.FileName);
							uploadButton.Enabled = false;
						}
					}
			
			};

			if (SubSectionsQueries.isAssignSolved(studentID, assignment.ModuleID, assignment.CourseID, assignment.ID))
			{
				uploadButton.Enabled = false;
			}
				assignmentPanel.Controls.Add(uploadButton);

			moduleFLP.Controls.Add(assignmentPanel);
		}

		private void loadReading(Reading reading)
		{
			Panel readingPanel = new Panel();
			readingPanel.Size = new Size(600, 385);
			readingPanel.Margin = new Padding(5);

			Label titleLabel = new Label();
			titleLabel.Text = $"Title: {reading.Title}";
			titleLabel.Size = new Size(580, 20);
			titleLabel.Location = new Point(10, 10);
			readingPanel.Controls.Add(titleLabel);

			TextBox contentTextBox = new TextBox();
			contentTextBox.Text = reading.Content;
			contentTextBox.Size = new Size(580, 325);
			contentTextBox.Location = new Point(10, 40);
			contentTextBox.Multiline = true;
			contentTextBox.ScrollBars = ScrollBars.Vertical;
			contentTextBox.ReadOnly = true;
			readingPanel.Controls.Add(contentTextBox);

			moduleFLP.Controls.Add(readingPanel);
		}

		private void loadSaq(SAQ saq)
		{
			Panel saqPanel = new Panel();
			saqPanel.Size = new Size(600, 385);
			saqPanel.Margin = new Padding(5);

			Label saqLabel = new Label();
			saqLabel.Text = $"Question: {saq.Prompt}";
			saqLabel.Size = new Size(580, 20);
			saqLabel.Location = new Point(10, 10);
			saqPanel.Controls.Add(saqLabel);

			TextBox answerTextBox = new TextBox();
			answerTextBox.Size = new Size(580, 300);
			answerTextBox.Location = new Point(10, 40);
			answerTextBox.Multiline = true;
			answerTextBox.ScrollBars = ScrollBars.Vertical;
			saqPanel.Controls.Add(answerTextBox);

			Button submitButton = new Button();
			submitButton.Text = "Submit Answer";
			submitButton.Size = new Size(150, 30);
			submitButton.Location = new Point(10, 350);
			submitButton.Click += (sender, e) => {

				solveSAQ(saq, answerTextBox.Text);
				submitButton.Enabled = false;
				
			};
			if (SubSectionsQueries.isSAQSolved(studentID, saq.ModuleID, saq.CourseID, saq.ID))
			{

				submitButton.Enabled = false;
			}
			saqPanel.Controls.Add(submitButton);

			moduleFLP.Controls.Add(saqPanel);
		}

		private void loadTfq(TFQ tf)
		{
			Panel tfqPanel = new Panel();
			tfqPanel.Size = new Size(600, 385);
			tfqPanel.Margin = new Padding(5);

			Label tfqLabel = new Label();
			tfqLabel.Text = $"Question: {tf.Prompt}";
			tfqLabel.Size = new Size(580, 20);
			tfqLabel.Location = new Point(10, 10);
			tfqPanel.Controls.Add(tfqLabel);

			RadioButton trueRadioButton = new RadioButton();
			trueRadioButton.Text = "True";
			trueRadioButton.Size = new Size(100, 20);
			trueRadioButton.Location = new Point(10, 40);
			tfqPanel.Controls.Add(trueRadioButton);

			RadioButton falseRadioButton = new RadioButton();
			falseRadioButton.Text = "False";
			falseRadioButton.Size = new Size(100, 20);
			falseRadioButton.Location = new Point(120, 40);
			tfqPanel.Controls.Add(falseRadioButton);

			Button submitButton = new Button();
			submitButton.Text = "Submit Answer";
			submitButton.Size = new Size(100, 30);
			submitButton.Location = new Point(10, 70);
			submitButton.Click += (sender, e) =>
			{
				if (trueRadioButton.Checked)
				{
					solveTFQ(tf, 1);
				}
				else if (falseRadioButton.Checked)
				{
					solveTFQ(tf, 0);
				}
				else
				{
					MessageBox.Show("Please select an answer.");
				}

				submitButton.Enabled = false;
			};
			if (SubSectionsQueries.isTFSolved(studentID, tf.ModuleID, tf.CourseID, tf.ID))
			{
				submitButton.Enabled = false;
			}
			tfqPanel.Controls.Add(submitButton);

			moduleFLP.Controls.Add(tfqPanel);
		}

		private void clearWork()
		{
			if (mediaplayerInstance != null) { 
				mediaplayerInstance.Dispose();
				mediaplayerInstance = null;
			}

			moduleFLP.Controls.Clear();
		}


		private void solveMCQ(mcq mcq,byte chosenAnswer)
		{
			SubSectionsQueries.createSolvedMCQ(mcq, chosenAnswer,studentID);
			isModuleCompleted(mcq.ModuleID,mcq.CourseID);
		}

		private void solveAssignment(Assignment assignment, String chosenAnswer)
		{
			SubSectionsQueries.createSolvedAssignment(assignment, chosenAnswer, studentID);
			isModuleCompleted(assignment.ModuleID, assignment.CourseID);

		}

		private void solveSAQ(SAQ mcq, string chosenAnswer)
		{
			SubSectionsQueries.createSolvedSAQ(mcq, chosenAnswer, studentID);
			isModuleCompleted(mcq.ModuleID, mcq.CourseID);

		}


		private void solveTFQ(TFQ mcq, byte chosenAnswer)
		{
			SubSectionsQueries.createSolvedTFQ(mcq, chosenAnswer, studentID);
			isModuleCompleted(mcq.ModuleID, mcq.CourseID);

		}

		private void seeVideo(Video video)
		{
			SubSectionsQueries.markVideoSeen(video, studentID);
		}

		private void seeRead(Reading reading)
		{
			SubSectionsQueries.markReadingSeen(reading, studentID);
		}

		

		private void isModuleCompleted(long moduleID,long courseID)
		{
			if (ModulesMCQs.TryGetValue(moduleID, out List<long> mcqIds))
			{
				foreach (var mcqId in mcqIds)
				{
					if(!SubSectionsQueries.isMcqSolved(studentID, moduleID, selectedCourse.Id, mcqId))
					{
						return;
					}
				}
			}

			if (ModulesAssigns.TryGetValue(moduleID, out List<long> assignIds))
			{
				foreach (var mcqId in assignIds)
				{
					if (!SubSectionsQueries.isAssignSolved(studentID, moduleID, selectedCourse.Id, mcqId))
					{
						return;
					}
				}
			}

			if (ModulesSAQs.TryGetValue(moduleID, out List<long> saqIds))
			{
				foreach (var mcqId in saqIds)
				{
					if (!SubSectionsQueries.isSAQSolved(studentID, moduleID, selectedCourse.Id, mcqId))
					{
						return;
					}
				}
			}

			if (ModulesTFQs.TryGetValue(moduleID, out List<long> tfIds))
			{
				foreach (var mcqId in tfIds)
				{
					if (!SubSectionsQueries.isTFSolved(studentID, moduleID, selectedCourse.Id, mcqId))
					{
						return;
					}
				}
			}




			//query to add to database
			ModuleQueires.completeModule(moduleID, studentID, courseID);




		}
	}
}
