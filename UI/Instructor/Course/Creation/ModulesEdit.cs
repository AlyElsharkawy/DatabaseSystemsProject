using DatabaseSystemsProject.DB;
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
		}

		private void addModBTN_Click(object sender, EventArgs e)
		{
			var createMod = new CreateModule(courseId);
			createMod.ShowDialog();
			
			TreeNode newModule = new TreeNode(createMod.moduleName);
			newModule.Tag = createMod.moduleID;
			courseTV.Nodes.Add(newModule);	
			
		}

		private void rmModBTN_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = courseTV.SelectedNode;
			long id = (long)selectedNode.Tag;
			ModuleQueires.deleteModule(id);
			courseTV.Nodes.Remove(selectedNode);
		}
	}
}
