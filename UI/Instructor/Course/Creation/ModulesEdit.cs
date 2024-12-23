using DatabaseSystemsProject.DB;
using DatabaseSystemsProject.UI.Instructor.Course.Creation.Subsections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystemsProject.UI.Instructor.Course.Creation
{
	public partial class ModulesEdit : Form
	{
		long courseId;

		public ModulesEdit(long retrievedID)
		{
			InitializeComponent();
			courseId = retrievedID;
			TreeNode newModule = new TreeNode("text processing");
			newModule.Tag = (long)104;
			courseTV.Nodes.Add(newModule);
		}

		private void addModBTN_Click(object sender, EventArgs e)
		{
			var createMod = new CreateModule(courseId);
			createMod.ShowDialog();
			if(createMod.moduleID == -1)
			{
				return;
			}

			TreeNode newModule = new TreeNode(createMod.moduleName);
			newModule.Tag = createMod.moduleID;
			courseTV.Nodes.Add(newModule);	
			
		}

		private  TreeNode getSelectedModule()
		{
			 return courseTV.SelectedNode;
		}

		private void rmModBTN_Click(object sender, EventArgs e)
		{
			var selectedNode = getSelectedModule();
			ModuleQueires.deleteModule((long)selectedNode.Tag);
			courseTV.Nodes.Remove(selectedNode);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var node = getSelectedModule();
			var video = new AddVideo(courseId, (long)node.Tag);
			video.ShowDialog();
			if (String.IsNullOrEmpty(video.videoTitle))
			{
				return;
			}
			var newNode = new TreeNode(video.videoTitle);
			courseTV.Nodes[node.Index].Nodes.Add(newNode);

		}

		private void button4_Click(object sender, EventArgs e)
		{
			var node = getSelectedModule();
			var reading = new AddReading(courseId, (long)node.Tag);
			reading.ShowDialog();
			if (String.IsNullOrEmpty(reading.readingTitle))
			{
				return;
			}

			var newNode = new TreeNode(reading.readingTitle);
			courseTV.Nodes[node.Index].Nodes.Add(newNode);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var node = getSelectedModule();
			var saq = new AddSAQ(courseId, (long)node.Tag);
			saq.ShowDialog();
			if (saq.secID <= -1)
			{
				return;
			}

			var newNode = new TreeNode("Short Question");
			courseTV.Nodes[node.Index].Nodes.Add(newNode);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			new AddMCQ().ShowDialog();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			new AddTFQ().ShowDialog();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			new AddAssign().ShowDialog();
		}

		private void courseTV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
