using System.Windows.Forms;

namespace Kyrs1
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.boldButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.fontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.underlineButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addPhotoButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.template_2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(250, 600);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1285, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "+ корінь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1285, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "+ гілка";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(-1, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(938, 320);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // boldButton
            // 
            this.boldButton.Location = new System.Drawing.Point(1261, 154);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(25, 25);
            this.boldButton.TabIndex = 4;
            this.boldButton.Text = "Ж";
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.Location = new System.Drawing.Point(1261, 185);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(25, 25);
            this.italicButton.TabIndex = 5;
            this.italicButton.Text = "К";
            this.italicButton.UseVisualStyleBackColor = true;
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fontSizeComboBox.FormattingEnabled = true;
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.fontSizeComboBox.Location = new System.Drawing.Point(1304, 155);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(55, 24);
            this.fontSizeComboBox.TabIndex = 6;
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSize_SelectedIndexChanged);
            // 
            // underlineButton
            // 
            this.underlineButton.Location = new System.Drawing.Point(1261, 216);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(25, 25);
            this.underlineButton.TabIndex = 7;
            this.underlineButton.Text = "Ч";
            this.underlineButton.UseVisualStyleBackColor = true;
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(280, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 650);
            this.panel1.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.richTextBox4);
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(950, 25);
            this.panel6.TabIndex = 8;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox4.Location = new System.Drawing.Point(0, -3);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(950, 28);
            this.richTextBox4.TabIndex = 0;
            this.richTextBox4.Text = "";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Controls.Add(this.richTextBox3);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(6, 606);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(937, 43);
            this.panel5.TabIndex = 7;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox3.Location = new System.Drawing.Point(0, 0);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(937, 44);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.richTextBox2);
            this.panel4.Location = new System.Drawing.Point(432, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 250);
            this.panel4.TabIndex = 6;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(510, 250);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(5, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 320);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(6, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 250);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addPhotoButton
            // 
            this.addPhotoButton.Location = new System.Drawing.Point(1261, 256);
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.Size = new System.Drawing.Size(98, 23);
            this.addPhotoButton.TabIndex = 9;
            this.addPhotoButton.Text = "Додати фото";
            this.addPhotoButton.UseVisualStyleBackColor = true;
            this.addPhotoButton.Click += new System.EventHandler(this.addPhotoButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(1261, 302);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(98, 23);
            this.saveChangesButton.TabIndex = 10;
            this.saveChangesButton.Text = "Зберегти дані";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // template_2
            // 
            this.template_2.Location = new System.Drawing.Point(284, 0);
            this.template_2.Name = "template_2";
            this.template_2.Size = new System.Drawing.Size(950, 650);
            this.template_2.TabIndex = 11;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.template_2);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.addPhotoButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.underlineButton);
            this.Controls.Add(this.fontSizeComboBox);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.boldButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "mainForm";
            this.Text = "Довідник";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.ComboBox fontSizeComboBox;
        private System.Windows.Forms.Button underlineButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addPhotoButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private Button saveChangesButton;
        private Panel template_2;
    }
}

