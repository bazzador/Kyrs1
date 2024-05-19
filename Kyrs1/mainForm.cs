using System;
using System.Windows.Forms;

namespace Kyrs1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            createTree createTreeForm = new createTree();
            createTreeForm.TreeCreated += CreateTreeForm_TreeCreated;
            createTreeForm.ShowDialog();
        }

        private void CreateTreeForm_TreeCreated(object sender, createTree.TreeEventArgs e)
        {
            TreeNode rootNode = new TreeNode(e.Tree.Name);
            for (int i = 0; i < e.Tree.AmountOfBranches; i++)
            {
                rootNode.Nodes.Add(new TreeNode($"Вітка {i + 1}"));
            }

            treeView1.Nodes.Add(rootNode);
            treeView1.ExpandAll();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (treeView1.SelectedNode != null)
        //    {
        //        TreeNode selectedNode = treeView1.SelectedNode;
        //        string nodeName = $"Вітка {selectedNode.Nodes.Count + 1}";
        //        selectedNode.Nodes.Add(new TreeNode(nodeName));
        //        selectedNode.Expand();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Виберіть вузол, до якого буде додана вітка.");
        //    }
        //}
    }
}
