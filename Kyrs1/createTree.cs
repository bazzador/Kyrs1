using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kyrs1
{
    public partial class createTree : Form
    {
        public event EventHandler<TreeEventArgs> TreeCreated;
        public List<template> templates;
        public abstract class template
        {
            public string Name { get; set; }
            public string Info { get; set; }
            protected template(string name, string info)
            {
                Name = name;
                Info = info;
            }
            protected template()
            {
            }
            public override string ToString()
            {
                return Name;
            }
        }
        public class template_1 : template
        {
            public Image Image { get; set; }
            public string ExtraInfo { get; set; }
            public string Address { get; set; }
            public string AddressFile { get; set; } = @"D:\saves";

            public template_1(string name, Image image, string info, string extraInfo, string address): base(name, info)
            {
                Image = image;
                ExtraInfo = extraInfo;
                Address = address;
            }
            public template_1() : base()
            {
            }
        }
        public class template_2 : template
        {
            public Image Image1 { get; set; }
            public Image Image2 { get; set; }
            public string Adress { get; set; }

            public string AdressFile = @"D:\saves";
            public template_2(string name, Image image1, Image image2, string info, string adress) : base(name, info)
            {
                Image1 = image1;
                Image2 = image2;
                Adress = adress;
            }
            public template_2() : base()
            {
            }
        }
        public class template_3 : template
        {
        }
        public createTree()
        {
            InitializeComponent();
            templates = new List<template>();

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
            public List<template> Templates { get; private set; }
            public TreeEventArgs(Tree tree, List<template> templates)
            {
                Tree = tree;
                Templates = templates;
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
            TreeCreated?.Invoke(this, new TreeEventArgs(tree, templates));
            this.Hide();
        }
        private void confirmBranchButton_Click(object sender, EventArgs e)
        {
            if (nameBranch.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        template_1 template1 = new template_1 { Name = nameBranch.Text };
                        listView1.Items.Add(template1.ToString());
                        templates.Add(template1);
                        break;
                    case 1:
                        template_2 template2 = new template_2 { Name = nameBranch.Text };
                        listView1.Items.Add(template2.ToString());
                        templates.Add(template2);
                        break;
                    case 2:
                        template_3 template3 = new template_3 { Name = nameBranch.Text };
                        listView1.Items.Add(template3.ToString());
                        templates.Add(template3);
                        break;
                }
            }
        }
    }
}
