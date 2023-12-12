namespace CloudComputing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>f
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            checkBox4 = new CheckBox();
            button2 = new Button();
            checkBox5 = new CheckBox();
            textBox2 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            pictureBox1 = new PictureBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 2;
            label1.Text = "Points of interests (POIs)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 5;
            label2.Text = "Sensor parameters";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 175);
            button1.Name = "button1";
            button1.Size = new Size(273, 38);
            button1.TabIndex = 6;
            button1.Text = "Read WSN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 233);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 7;
            label3.Text = "Sensor range (r)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 230);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 287);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 9;
            label4.Text = "Activate sensors";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 317);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(114, 19);
            checkBox4.TabIndex = 10;
            checkBox4.Text = "Deterministically";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(12, 351);
            button2.Name = "button2";
            button2.Size = new Size(273, 38);
            button2.TabIndex = 11;
            button2.Text = "Read WSN on/off";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.Location = new Point(12, 404);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(80, 19);
            checkBox5.TabIndex = 12;
            checkBox5.Text = "Randomly";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 435);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 14;
            textBox2.Text = "0.3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 438);
            label5.Name = "label5";
            label5.Size = new Size(154, 15);
            label5.TabIndex = 13;
            label5.Text = "Sensor probablility initial on";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 192);
            button3.Location = new Point(12, 537);
            button3.Name = "button3";
            button3.Size = new Size(273, 38);
            button3.TabIndex = 15;
            button3.Text = "Show WSN";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 590);
            button4.Name = "button4";
            button4.Size = new Size(130, 26);
            button4.TabIndex = 16;
            button4.Text = "Calc single q";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(148, 590);
            button5.Name = "button5";
            button5.Size = new Size(137, 26);
            button5.TabIndex = 17;
            button5.Text = "Calc all q";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 622);
            button6.Name = "button6";
            button6.Size = new Size(130, 26);
            button6.TabIndex = 18;
            button6.Text = "Find WSN graph";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(148, 622);
            button7.Name = "button7";
            button7.Size = new Size(137, 26);
            button7.TabIndex = 19;
            button7.Text = "Calc sensor ID";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(355, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(750, 750);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 53);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 19);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "POI 36";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(11, 78);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 22;
            radioButton2.Text = "POI 121";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 104);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 19);
            radioButton3.TabIndex = 23;
            radioButton3.Text = "POI 441";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 800);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(checkBox5);
            Controls.Add(button2);
            Controls.Add(checkBox4);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cloud Computing - J.Łuka, Ł.Grochowski, M.Bielicki";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn radiusDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        protected CheckBox checkBox4;
        private Button button2;
        protected CheckBox checkBox5;
        private TextBox textBox2;
        private Label label5;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}