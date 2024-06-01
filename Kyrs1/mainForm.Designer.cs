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
            this.template_1 = new System.Windows.Forms.Panel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.template_3 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.addPhoto3Button = new System.Windows.Forms.Button();
            this.editTextButton = new System.Windows.Forms.Button();
            this.addPhoto2Button = new System.Windows.Forms.Button();
            this.template_1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.template_2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.template_3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(250, 653);
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
            // template_1
            // 
            this.template_1.Controls.Add(this.panel6);
            this.template_1.Controls.Add(this.panel5);
            this.template_1.Controls.Add(this.panel4);
            this.template_1.Controls.Add(this.panel3);
            this.template_1.Controls.Add(this.panel2);
            this.template_1.Enabled = false;
            this.template_1.Location = new System.Drawing.Point(1378, 12);
            this.template_1.Name = "template_1";
            this.template_1.Size = new System.Drawing.Size(950, 650);
            this.template_1.TabIndex = 8;
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
            this.addPhotoButton.Enabled = false;
            this.addPhotoButton.Location = new System.Drawing.Point(1261, 335);
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.Size = new System.Drawing.Size(98, 23);
            this.addPhotoButton.TabIndex = 9;
            this.addPhotoButton.Text = "Додати фото";
            this.addPhotoButton.UseVisualStyleBackColor = true;
            this.addPhotoButton.Visible = false;
            this.addPhotoButton.Click += new System.EventHandler(this.addPhotoButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(1261, 260);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(98, 23);
            this.saveChangesButton.TabIndex = 10;
            this.saveChangesButton.Text = "Зберегти дані";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // template_2
            // 
            this.template_2.Controls.Add(this.panel1);
            this.template_2.Controls.Add(this.panel8);
            this.template_2.Controls.Add(this.panel9);
            this.template_2.Controls.Add(this.panel11);
            this.template_2.Controls.Add(this.panel12);
            this.template_2.Enabled = false;
            this.template_2.Location = new System.Drawing.Point(224, 684);
            this.template_2.Name = "template_2";
            this.template_2.Size = new System.Drawing.Size(950, 650);
            this.template_2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(529, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 250);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(415, 250);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.richTextBox5);
            this.panel8.Location = new System.Drawing.Point(0, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(950, 25);
            this.panel8.TabIndex = 8;
            // 
            // richTextBox5
            // 
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox5.Location = new System.Drawing.Point(0, -3);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(950, 28);
            this.richTextBox5.TabIndex = 0;
            this.richTextBox5.Text = "";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel9.Controls.Add(this.richTextBox6);
            this.panel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel9.Location = new System.Drawing.Point(6, 606);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(937, 43);
            this.panel9.TabIndex = 7;
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox6.Location = new System.Drawing.Point(0, 0);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(937, 44);
            this.richTextBox6.TabIndex = 0;
            this.richTextBox6.Text = "";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DimGray;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.richTextBox8);
            this.panel11.Location = new System.Drawing.Point(5, 285);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(939, 320);
            this.panel11.TabIndex = 5;
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox8.Location = new System.Drawing.Point(-1, 0);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(938, 320);
            this.richTextBox8.TabIndex = 3;
            this.richTextBox8.Text = "";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.pictureBox2);
            this.panel12.Location = new System.Drawing.Point(6, 30);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(415, 250);
            this.panel12.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // template_3
            // 
            this.template_3.Controls.Add(this.panel13);
            this.template_3.Controls.Add(this.panel15);
            this.template_3.Enabled = false;
            this.template_3.Location = new System.Drawing.Point(283, 15);
            this.template_3.Name = "template_3";
            this.template_3.Size = new System.Drawing.Size(950, 650);
            this.template_3.TabIndex = 12;
            this.template_3.Visible = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.richTextBox7);
            this.panel13.Location = new System.Drawing.Point(0, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(950, 25);
            this.panel13.TabIndex = 8;
            // 
            // richTextBox7
            // 
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox7.Location = new System.Drawing.Point(0, -3);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(950, 28);
            this.richTextBox7.TabIndex = 0;
            this.richTextBox7.Text = "";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DimGray;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.richTextBox10);
            this.panel15.Location = new System.Drawing.Point(6, 76);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(939, 425);
            this.panel15.TabIndex = 5;
            // 
            // richTextBox10
            // 
            this.richTextBox10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox10.Location = new System.Drawing.Point(-4, -1);
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.Size = new System.Drawing.Size(942, 425);
            this.richTextBox10.TabIndex = 3;
            this.richTextBox10.Text = "";
            // 
            // addPhoto3Button
            // 
            this.addPhoto3Button.Enabled = false;
            this.addPhoto3Button.Location = new System.Drawing.Point(1261, 364);
            this.addPhoto3Button.Name = "addPhoto3Button";
            this.addPhoto3Button.Size = new System.Drawing.Size(98, 23);
            this.addPhoto3Button.TabIndex = 14;
            this.addPhoto3Button.Text = "Додати фото 2";
            this.addPhoto3Button.UseVisualStyleBackColor = true;
            this.addPhoto3Button.Visible = false;
            this.addPhoto3Button.Click += new System.EventHandler(this.addPhoto3Button_Click);
            // 
            // editTextButton
            // 
            this.editTextButton.Location = new System.Drawing.Point(1261, 297);
            this.editTextButton.Name = "editTextButton";
            this.editTextButton.Size = new System.Drawing.Size(75, 23);
            this.editTextButton.TabIndex = 4;
            this.editTextButton.Text = "Редагувати";
            this.editTextButton.UseVisualStyleBackColor = true;
            this.editTextButton.Click += new System.EventHandler(this.editTextButton_Click);
            // 
            // addPhoto2Button
            // 
            this.addPhoto2Button.Enabled = false;
            this.addPhoto2Button.Location = new System.Drawing.Point(1261, 335);
            this.addPhoto2Button.Name = "addPhoto2Button";
            this.addPhoto2Button.Size = new System.Drawing.Size(98, 23);
            this.addPhoto2Button.TabIndex = 13;
            this.addPhoto2Button.Text = "Додати фото";
            this.addPhoto2Button.UseVisualStyleBackColor = true;
            this.addPhoto2Button.Visible = false;
            this.addPhoto2Button.Click += new System.EventHandler(this.addPhoto2Button_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1924, 973);
            this.Controls.Add(this.addPhoto3Button);
            this.Controls.Add(this.addPhoto2Button);
            this.Controls.Add(this.editTextButton);
            this.Controls.Add(this.template_3);
            this.Controls.Add(this.template_2);
            this.Controls.Add(this.template_1);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.addPhotoButton);
            this.Controls.Add(this.underlineButton);
            this.Controls.Add(this.fontSizeComboBox);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.boldButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "mainForm";
            this.Text = "Довідник";
            this.template_1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.template_2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.template_3.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
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
        private System.Windows.Forms.Panel template_1;
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
        private Panel panel8;
        private RichTextBox richTextBox5;
        private Panel panel9;
        private RichTextBox richTextBox6;
        private Panel panel11;
        private RichTextBox richTextBox8;
        private Panel panel12;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel template_3;
        private Panel panel13;
        private RichTextBox richTextBox7;
        private Panel panel15;
        private RichTextBox richTextBox10;
        private Button editTextButton;
        private Button addPhoto2Button;
        private Button addPhoto3Button;
    }
}

