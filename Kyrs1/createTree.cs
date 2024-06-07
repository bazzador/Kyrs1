using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
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

            public string AddressFile { get; set; } = @"C:\Kyrs11";
            protected template(RichTextBox rtbName, RichTextBox rtbInfo)
            {
                Name = rtbName.Rtf;
                Info = rtbInfo.Rtf;
            }
            protected template()
            {
            }
            public override string ToString()
            {
                return Name;
            }

            public abstract void SaveTextToRtf(string filePath);
            public abstract void ParseRTF(string filePath, RichTextBox rtbName, RichTextBox rtbInfo, RichTextBox rtbExtraInfo, RichTextBox rtbAddress, PictureBox pbImage);
        }
        public class template_1 : template
        {
            public Image Image { get; set; }
            public string ExtraInfo { get; set; }
            public string Address { get; set; }
            public RichTextBox[] rtb;

            public template_1(RichTextBox rtbName, RichTextBox rtbInfo, RichTextBox rtbExtraInfo, RichTextBox rtbAddress, Image image) : base(rtbName, rtbInfo)
            {
                Image = image;
                ExtraInfo = rtbExtraInfo.Rtf;
                Address = rtbAddress.Rtf;
            }

            public template_1() : base()
            {
            }
            public override void SaveTextToRtf(string filePath) 
            {
                try
                {
                    string imagePath = "NO PHOTO!";
                    //if (!Directory.Exists(directoryPath))
                    //{
                    //    Directory.CreateDirectory(directoryPath);
                    //}

                    //string filePath = Path.Combine(directoryPath, $"{Name}.txt");

                    //using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
                    //using (StreamWriter writer = new StreamWriter(fileStream))
                    //{
                    //    writer.WriteLine("Name: " + Name);
                    //    writer.WriteLine("Info (RTF): " + Info);
                    //    writer.WriteLine("ExtraInfo (RTF): " + ExtraInfo);
                    //    writer.WriteLine("Address: " + Address);

                    //    // Збереження зображення в окремий файл
                    //}
                    if (Image != null)
                    {
                        imagePath = Path.Combine(Address, $"{Name}.png");
                        Image.Save(imagePath);
                    }
                    string formattedContent = $"Name: {Name}\n" +
                                      $"Info (RTF): {Info}\n" +
                                      $"ExtraInfo (RTF): {ExtraInfo}\n" +
                                      $"Address: {Address}\n" +
                                      $"ImagePath: {imagePath}\n";

                    File.WriteAllText(filePath, formattedContent);
                    
                    MessageBox.Show("Дані успішно збережено!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка при збереженні даних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //public void LoadTextFromRtf(string filePath)
            //{
            //    string[] contents;
            //    if (File.Exists(filePath))
            //    {
            //        using (RichTextBox combinedRichTextBox = new RichTextBox())
            //        {
            //            // Зчитуємо вміст файлу
            //            combinedRichTextBox.LoadFile(filePath, RichTextBoxStreamType.RichText);

            //            // Розділяємо вміст за роздільниками нових рядків
            //            contents = combinedRichTextBox.Rtf.Split(new[] { "\n" }, StringSplitOptions.None);

            //            // Завантажуємо вміст у кожен RichTextBox
            //            for (int i = 0; i < rtb.Length && i < contents.Length; i++)
            //            {
            //                rtb[i].Rtf = contents[i];
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Файл не знайдено за шляхом: " + filePath);
            //    }
            //}   
            public override void ParseRTF(string filePath, RichTextBox rtbName, RichTextBox rtbInfo, RichTextBox rtbExtraInfo, RichTextBox rtbAddress, PictureBox pbImage) 
            {
                // Зчитування файлу
                if (!File.Exists(filePath))
                {
                    return;
                }
                string rtfContent = File.ReadAllText(filePath);

                // Регулярні вирази для виділення потрібних секцій
                string namePattern = @"Name:\s*({.*?})\s*Info";
                string infoPattern = @"Info \(RTF\):\s*({.*?})\s*ExtraInfo";
                string extraInfoPattern = @"ExtraInfo \(RTF\):\s*({.*?})\s*Address:(.*?)\n";
                string addressPattern = @"Address:\s*({.*?})\s*ImagePath";
                string imagePathPattern = @"ImagePath:\s*(.*)$";

                // Виділення значень за допомогою регулярних виразів
                var nameMatch = Regex.Match(rtfContent, namePattern, RegexOptions.Singleline);
                var infoMatch = Regex.Match(rtfContent, infoPattern, RegexOptions.Singleline);
                var extraInfoMatch = Regex.Match(rtfContent, extraInfoPattern, RegexOptions.Singleline);
                var addressMatch = Regex.Match(rtfContent, addressPattern, RegexOptions.Singleline);
                var imagePathMatch = Regex.Match(rtfContent, imagePathPattern, RegexOptions.Singleline);

                // Встановлення значень у відповідні RichTextBox
                if (nameMatch.Success)
                {
                    rtbName.Rtf = nameMatch.Groups[1].Value.Trim();
                }
                if (infoMatch.Success)
                {
                    rtbInfo.Rtf = infoMatch.Groups[1].Value.Trim();
                }
                if (extraInfoMatch.Success)
                {
                    rtbExtraInfo.Rtf = extraInfoMatch.Groups[1].Value.Trim();
                }
                if (addressMatch.Success)
                {
                    rtbAddress.Rtf = addressMatch.Groups[1].Value.Trim();
                }
                if (imagePathMatch.Success)
                {
                    string imagePath = imagePathMatch.Groups[1].Value.Trim();
                    if (imagePath != "NO PHOTO!")
                    {
                        if (File.Exists(imagePath))
                        {
                            pbImage.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            MessageBox.Show("Зображення не знайдено за вказаним шляхом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        pbImage.Image = null;
                    }
                }
            }
        }
        public class template_2 : template
        {
            public Image Image1 { get; set; }
            public Image Image2 { get; set; }
            public string Address { get; set; }

            public template_2(RichTextBox rtbName, RichTextBox rtbInfo, RichTextBox rtbAddress, Image image1, Image image2) : base(rtbName, rtbInfo)
            {
                Image1 = image1;
                Image2 = image2;
                Address = rtbAddress.Rtf;
            }

            public template_2() : base()
            {
            }

            public override void SaveTextToRtf(string filePath)
            {
                throw new NotImplementedException();
            }

            public override void ParseRTF(string filePath, RichTextBox rtbName, RichTextBox rtbInfo, RichTextBox rtbAddress, PictureBox pbImage, PictureBox pbImage2)
            {
                // ваша реалізація методу для template_2 з унікальною сигнатурою
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
