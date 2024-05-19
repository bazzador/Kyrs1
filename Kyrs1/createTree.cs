using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kyrs1
{
    public partial class createTree : Form
    {
        public event EventHandler<TreeEventArgs> TreeCreated;
        public class abv
        {
            public abv()
            {
            }
        }
        public createTree()
        {
            InitializeComponent();
        }

        public class Tree
        {
            public string Name { get; set; }
            public List<string> Branches { get; private set; } 
            public Tree(string name, List<string> branches)
            {
                Name = name;
                Branches = branches;   
            }
        }

        public class TreeEventArgs : EventArgs
        {
            public Tree Tree { get; }

            public TreeEventArgs(Tree tree)
            {
                Tree = tree;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> branches = new List<string>();
            foreach (ListViewItem item in listView1.Items)
            {
                branches.Add(item.Text);
            }
            Tree tree = new Tree(nameTree.Text, branches);
            TreeCreated?.Invoke(this, new TreeEventArgs(tree));
            this.Hide();
        }
        private void confirmBranchButton_Click(object sender, EventArgs e)
        {
            if (nameBranch.Text != "")
            {
                listView1.Items.Add(nameBranch.Text);
            }
        }
    }
}
