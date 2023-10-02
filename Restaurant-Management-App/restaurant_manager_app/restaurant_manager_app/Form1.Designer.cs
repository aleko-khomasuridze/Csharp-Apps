namespace restaurant_manager_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
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
            panel1 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            Dashboard = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 23, 40);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 57);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(179, 155, 195);
            button5.Image = Properties.Resources.exit;
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(818, 14);
            button5.Name = "button5";
            button5.Size = new Size(73, 30);
            button5.TabIndex = 4;
            button5.Text = "logOut";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.comment_alt;
            button3.Location = new Point(785, 15);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 3;
            button3.Text = " ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.cross_small;
            button2.Location = new Point(897, 14);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 2;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.search;
            button1.Location = new Point(750, 15);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 1;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "ALEX INDUSTRIES";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 23, 40);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 720);
            panel2.TabIndex = 1;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Bottom;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.FromArgb(127, 124, 146);
            button11.Image = Properties.Resources.settings;
            button11.Location = new Point(0, 678);
            button11.Name = "button11";
            button11.Size = new Size(200, 42);
            button11.TabIndex = 8;
            button11.Text = "Settings";
            button11.TextImageRelation = TextImageRelation.TextBeforeImage;
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.FromArgb(127, 124, 146);
            button10.Image = Properties.Resources.burger_alt;
            button10.Location = new Point(0, 330);
            button10.Name = "button10";
            button10.Size = new Size(200, 42);
            button10.TabIndex = 7;
            button10.Text = "Restaurants";
            button10.TextImageRelation = TextImageRelation.TextBeforeImage;
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.FromArgb(127, 124, 146);
            button9.Image = Properties.Resources.chart_simple_horizontal;
            button9.Location = new Point(0, 288);
            button9.Name = "button9";
            button9.Size = new Size(200, 42);
            button9.TabIndex = 6;
            button9.Text = "Analitics ";
            button9.TextImageRelation = TextImageRelation.TextBeforeImage;
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.FromArgb(127, 124, 146);
            button8.Image = Properties.Resources.rectangle_list;
            button8.Location = new Point(0, 246);
            button8.Name = "button8";
            button8.Size = new Size(200, 42);
            button8.TabIndex = 5;
            button8.Text = "Menu List";
            button8.TextImageRelation = TextImageRelation.TextBeforeImage;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(127, 124, 146);
            button7.Image = Properties.Resources.users_alt;
            button7.Location = new Point(0, 204);
            button7.Name = "button7";
            button7.Size = new Size(200, 42);
            button7.TabIndex = 4;
            button7.Text = "Employees";
            button7.TextImageRelation = TextImageRelation.TextBeforeImage;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(127, 124, 146);
            button6.Image = Properties.Resources.user;
            button6.Location = new Point(0, 162);
            button6.Name = "button6";
            button6.Size = new Size(200, 42);
            button6.TabIndex = 3;
            button6.Text = "Costumers";
            button6.TextImageRelation = TextImageRelation.TextBeforeImage;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(127, 124, 146);
            button4.Image = Properties.Resources.house_chimney;
            button4.Location = new Point(0, 120);
            button4.Name = "button4";
            button4.Size = new Size(200, 42);
            button4.TabIndex = 2;
            button4.Text = "Dashboard";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 120);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(26, 95);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 7;
            label4.Text = "MENU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(80, 65, 89);
            label3.Location = new Point(72, 37);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 6;
            label3.Text = "Software Engineer";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(185, 155, 204);
            label2.Location = new Point(72, 15);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 5;
            label2.Text = "Aleko Khom";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 23, 40);
            panel4.Controls.Add(Dashboard);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(200, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(740, 42);
            panel4.TabIndex = 2;
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Dashboard.ForeColor = Color.FromArgb(127, 124, 146);
            Dashboard.Location = new Point(16, 12);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(98, 19);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "Dashboard";
            Dashboard.Click += Dashboard_Click;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(200, 99);
            panel5.Name = "panel5";
            panel5.Size = new Size(740, 678);
            panel5.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 32);
            ClientSize = new Size(940, 777);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Restaurant Management System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private Button button5;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button4;
        private Button button6;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Panel panel4;
        private Label Dashboard;
        private Panel panel5;
    }
}