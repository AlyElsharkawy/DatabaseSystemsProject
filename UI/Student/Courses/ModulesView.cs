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
		public ModulesView()
		{
			InitializeComponent();
			modulesDummyData();
		}

		private void modulesDummyData()
		{
			for (int i = 1; i <= 5; i++)
			{
				// Create a module node
				TreeNode moduleNode = new TreeNode($"Module {i}");

				// Add 5 items to each module
				for (int j = 1; j <= 5; j++)
				{
					moduleNode.Nodes.Add(new TreeNode($"Item {i}.{j}"));
				}

				// Add the module node to the TreeView
				modulesTV.Nodes.Add(moduleNode);
			}
		}
	}
}
