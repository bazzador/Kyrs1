using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kyrs1
{
    public partial class createTree : Form
    {
        public event EventHandler<TreeEventArgs> TreeCreated;
        public class template_1
        {
            public string Name {  get; set; }
            public Image Image { get; set; }
            public string Info { get; set; }
            public string ExtraInfo { get; set; }
            public string Adress {  get; set; }
            public string AdressFile = @"D:\saves";
            public template_1(string name, Image image, string info, string extraInfo, string adress)
            {
                Name = name;
                Image = image;
                Info = info;
                ExtraInfo = extraInfo;
                Adress = adress;
            }
        }
        public
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
