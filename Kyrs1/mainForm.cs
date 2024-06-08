using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http.Headers;
using System.Windows.Forms;
using static Kyrs1.createTree;

namespace Kyrs1
{
    public partial class mainForm : Form
    {
        public List<template> templates;
        public string AddressFile { get; set; } = @"C:\Kyrs11";
        public TreeNode selectedNode;
        public string path;
        public mainForm()
        {
            InitializeComponent();
            templates = new List<template>();
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

            foreach (template _template in e.Templates)
            {
                TreeNode branchNode = new TreeNode(_template.Name); // Припустимо, що у шаблону є властивість Name
                branchNode.Tag = _template; // Збереження шаблону у властивості Tag
                rootNode.Nodes.Add(branchNode);
            }

            treeView1.Nodes.Add(rootNode);
            treeView1.ExpandAll();
        }
        //private void CreateTreeForm_TreeCreated(object sender, createTree.TreeEventArgs e)
        //{
        //    TreeNode rootNode = new TreeNode(e.Tree.Name);
        //    foreach (template _template in e.Templates)
        //    {
        //        templates.Add(_template);
        //    }
        //    foreach (string node in e.Tree.Branches)
        //    {
        //        rootNode.Nodes.Add(new TreeNode(node));
        //    }
        //    treeView1.Nodes.Add(rootNode);
        //    treeView1.ExpandAll();
        //}

        private void boldButton_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox2.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox3.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox4.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox5.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox6.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox7.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox8.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);

        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox2.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox3.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox4.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox5.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox6.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox7.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox8.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }

        private void fontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontSizeComboBox.SelectedItem != null)
            {
                float newSize;
                if (float.TryParse(fontSizeComboBox.SelectedItem.ToString(), out newSize))
                {
                    ChangeFontSize(newSize);
                }
            }
        }
        private void ChangeFontSize(float newSize)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, newSize, richTextBox1.SelectionFont.Style);
            richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont.FontFamily, newSize, richTextBox2.SelectionFont.Style);
            richTextBox3.SelectionFont = new Font(richTextBox3.SelectionFont.FontFamily, newSize, richTextBox3.SelectionFont.Style);
            richTextBox4.SelectionFont = new Font(richTextBox4.SelectionFont.FontFamily, newSize, richTextBox4.SelectionFont.Style);
            richTextBox5.SelectionFont = new Font(richTextBox5.SelectionFont.FontFamily, newSize, richTextBox5.SelectionFont.Style);
            richTextBox6.SelectionFont = new Font(richTextBox6.SelectionFont.FontFamily, newSize, richTextBox6.SelectionFont.Style);
            richTextBox7.SelectionFont = new Font(richTextBox7.SelectionFont.FontFamily, newSize, richTextBox7.SelectionFont.Style);
            richTextBox8.SelectionFont = new Font(richTextBox8.SelectionFont.FontFamily, newSize, richTextBox8.SelectionFont.Style);

        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }
        private void ToggleFontStyle(FontStyle fontStyle)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle newFontStyle = richTextBox1.SelectionFont.Style ^ fontStyle;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, newFontStyle);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNode = e.Node;
            MessageBox.Show("Вибрано гілку: " + selectedNode.Text);
            path = Path.Combine(AddressFile, selectedNode.Text);
            template_1.Visible = false;
            template_2.Visible = false;
            template_3.Visible = false;
            ClearForm();
            switch (templates[selectedNode.Index].GetType().Name)
            {
                case "template_1":
                    template_1.Visible = true;
                    template_1.Location = new Point(283, 15);
                    addPhotoButton.Visible = true;
                    template_1 template1 = (template_1)templates[selectedNode.Index];
                    RichTextBox rtbName1 = new RichTextBox();
                    RichTextBox rtbInfo1 = new RichTextBox();
                    RichTextBox rtbExtraInfo1 = new RichTextBox();
                    RichTextBox rtbAddress1 = new RichTextBox();
                    PictureBox pbImage1_1 = new PictureBox();

                    template1.ParseRTF(path, rtbName1, rtbInfo1, rtbExtraInfo1, rtbAddress1, pbImage1_1);
                    richTextBox4.Rtf = rtbName1.Rtf;
                    richTextBox2.Rtf = rtbInfo1.Rtf;
                    richTextBox1.Rtf = rtbExtraInfo1.Rtf;
                    richTextBox3.Rtf = rtbAddress1.Rtf;
                    pictureBox1.Image = pbImage1_1.Image;

                    break;
                case "template_2":
                    template_2.Visible = true;
                    template_2.Location = new Point(283, 15);
                    addPhoto2Button.Visible = true;
                    addPhoto3Button.Visible = true;
                    template_2 template2 = (template_2)templates[selectedNode.Index];
                    RichTextBox rtbName2 = new RichTextBox();
                    RichTextBox rtbInfo2 = new RichTextBox();
                    RichTextBox rtbAddress2 = new RichTextBox();
                    PictureBox pbImage2_1 = new PictureBox();
                    PictureBox pbImage2_2 = new PictureBox();
                    template2.ParseRTF(path, rtbName2, rtbInfo2, rtbAddress2, pbImage2_1, pbImage2_2);
                    richTextBox5.Rtf = rtbName2.Rtf;
                    richTextBox8.Rtf = rtbInfo2.Rtf;
                    richTextBox6.Rtf = rtbAddress2.Rtf;
                    pictureBox2.Image = pbImage2_1.Image;
                    pictureBox3.Image = pbImage2_2.Image;
                    break;
                case "template_3":
                    template_3.Visible= true;
                    template_3.Location = new Point(283, 15);
                    template_3 template3 = (template_3)templates[selectedNode.Index];
                    RichTextBox rtbName3 = new RichTextBox();
                    RichTextBox rtbInfo3 = new RichTextBox();
                    template3.ParseRTF(path, rtbName3, rtbInfo3);
                    richTextBox7.Rtf = rtbName3.Rtf;
                    richTextBox10.Rtf = rtbInfo3.Rtf;
                    break;
            }
        }
        private void ClearForm()
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
            richTextBox6.Text = "";
            richTextBox7.Text = "";
            richTextBox8.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
        }
        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            LoadImage(pictureBox1);
        }
        private void addPhoto2Button_Click(object sender, EventArgs e)
        {
            LoadImage(pictureBox2);
        }
        private void addPhoto3Button_Click(object sender, EventArgs e)
        {
            LoadImage(pictureBox3);
        }
        private void LoadImage(PictureBox pictureBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"c:\";
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Отримання шляху до вибраного файлу
                    string filePath = openFileDialog.FileName;

                    // Завантаження зображення у PictureBox
                    pictureBox.Image = Image.FromFile(filePath);
                }
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            string name = selectedNode.Text;
            switch (templates[selectedNode.Index].GetType().Name)
            {
                case "template_1":
                        template_1 template1 = new template_1(name, richTextBox4, richTextBox1, richTextBox2, richTextBox3, pictureBox1.Image);
                        template1.SaveTextToRtf(Path.Combine(AddressFile, selectedNode.Text));
                        MessageBox.Show($"Файл {selectedNode.Text} успішно збережений!");
                    break;
                case "template_2":
                    template_2 template2 = new template_2(name, richTextBox5, richTextBox8, richTextBox6, pictureBox2.Image, pictureBox3.Image);
                    template2.SaveTextToRtf(Path.Combine(AddressFile, selectedNode.Text));
                    MessageBox.Show($"Файл {selectedNode.Text} успішно збережений!");
                    break;
                case "template_3":
                    template_3 template3 = new template_3(name, richTextBox7, richTextBox10);
                    template3.SaveTextToRtf(Path.Combine(AddressFile, selectedNode.Text));
                    MessageBox.Show($"Файл {selectedNode.Text} успішно збережений!");
                    break;
            }
        }



        private void editTextButton_Click(object sender, EventArgs e)
        {
            if(editTextButton.Text == "Редагувати")
            {
                template_1.Enabled = true;
                template_2.Enabled = true;
                template_3.Enabled = true;
                addPhotoButton.Enabled = true;
                addPhoto2Button.Enabled = true;
                addPhoto3Button.Enabled = true;
                editTextButton.Text = "Зупинити редагування";
            }
            else
            {
                template_1.Enabled = false;
                template_2.Enabled = false;
                template_3.Enabled = false;
                addPhotoButton.Enabled = false;
                addPhoto2Button.Enabled = false;
                addPhoto3Button.Enabled= false;
                editTextButton.Text = "Редагувати";
            }
        }
    }
}
