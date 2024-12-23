﻿using DatabaseSystemsProject.DB;
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
		int mcqIndex = 1;
		int saqIndex = 1;
		int tfIndqx = 1;
		int assignIndex = 1;

		public ModulesEdit(long retrievedID)
		{
			InitializeComponent();
			courseId = retrievedID;
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

			var newNode = new TreeNode($"Short Question{saqIndex++}");
			courseTV.Nodes[node.Index].Nodes.Add(newNode);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			var node = getSelectedModule();
			var mcq = new AddMCQ(courseId, (long)node.Tag);
			mcq.ShowDialog();
			if (mcq.mcqID <= -1)
			{
				return;
			}

			var newNode = new TreeNode($"mcqQuestion{mcqIndex++}");
			courseTV.Nodes[node.Index].Nodes.Add(newNode);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			var node = getSelectedModule();
			var tfq = new AddTFQ(courseId, (long)node.Tag);
			tfq.ShowDialog();
			if (tfq.tfqID <= -1)
			{
				return;
			}

			var newNode = new TreeNode($"TFQuestion{tfIndqx++}");
			courseTV.Nodes[node.Index].Nodes.Add(newNode);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			var node = getSelectedModule();
			var saq = new AddAssign(courseId, (long)node.Tag);
			saq.ShowDialog();
			if (saq.asignID <= -1)
			{
				return;
			}

			var newNode = new TreeNode($"Assignment{assignIndex++}");
			courseTV.Nodes[node.Index].Nodes.Add(newNode);
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
