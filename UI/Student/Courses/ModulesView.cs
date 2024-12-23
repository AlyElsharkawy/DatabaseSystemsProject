using DatabaseSystemsProject.DB;
using DatabaseSystemsProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseSystemsProject.UI.Student.Courses
{
	public partial class ModulesView : Form
	{
		Course selectedCourse;
		public ModulesView(Course recievedCourse)
		{
			InitializeComponent();

			selectedCourse = recievedCourse;
			loadModules();
		}

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
				}

				var assignments = ModuleQueires.getModuleAssignments(module.moduleID);
				foreach (var assignment in assignments)
				{
					var assignmentNode = modulesTV.Nodes[enteredNode.Index].Nodes.Add($"Assignment{assignIndex++}");
					assignmentNode.Tag = assignment;
				}

				var saqs = ModuleQueires.getModuleSAQs(module.moduleID);
				foreach (var saq in saqs)
				{
					var saqNode = modulesTV.Nodes[enteredNode.Index].Nodes.Add($"Short Question{saqIndex++}");
					saqNode.Tag = saq;
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


		}
	}
}
