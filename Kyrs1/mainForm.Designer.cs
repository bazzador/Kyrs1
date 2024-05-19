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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(950, 650);
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
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(284, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 650);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 275);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(5, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 320);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(385, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 275);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(9, 606);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(934, 43);
            this.panel5.TabIndex = 7;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1384, 661);
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
    }
}

