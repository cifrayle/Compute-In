namespace Compute_In.Forms
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_DebtCounter = new System.Windows.Forms.Button();
            this.btn_expenseTracker = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_DebtCounter);
            this.panel1.Controls.Add(this.btn_expenseTracker);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 614);
            this.panel1.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.LightGray;
            this.sidePanel.Location = new System.Drawing.Point(3, 299);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(8, 46);
            this.sidePanel.TabIndex = 8;
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Logout.Image = global::Compute_In.Properties.Resources.icons8_logout_46;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(12, 455);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(265, 46);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_DebtCounter
            // 
            this.btn_DebtCounter.FlatAppearance.BorderSize = 0;
            this.btn_DebtCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DebtCounter.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DebtCounter.ForeColor = System.Drawing.Color.LightGray;
            this.btn_DebtCounter.Image = global::Compute_In.Properties.Resources.icons8_debt_46;
            this.btn_DebtCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DebtCounter.Location = new System.Drawing.Point(12, 403);
            this.btn_DebtCounter.Name = "btn_DebtCounter";
            this.btn_DebtCounter.Size = new System.Drawing.Size(265, 46);
            this.btn_DebtCounter.TabIndex = 7;
            this.btn_DebtCounter.Text = "Debt Counter";
            this.btn_DebtCounter.UseVisualStyleBackColor = true;
            this.btn_DebtCounter.Click += new System.EventHandler(this.btn_budgetPlanner_Click);
            // 
            // btn_expenseTracker
            // 
            this.btn_expenseTracker.FlatAppearance.BorderSize = 0;
            this.btn_expenseTracker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expenseTracker.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expenseTracker.ForeColor = System.Drawing.Color.LightGray;
            this.btn_expenseTracker.Image = global::Compute_In.Properties.Resources.icons8_expense_46;
            this.btn_expenseTracker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_expenseTracker.Location = new System.Drawing.Point(12, 351);
            this.btn_expenseTracker.Name = "btn_expenseTracker";
            this.btn_expenseTracker.Size = new System.Drawing.Size(265, 46);
            this.btn_expenseTracker.TabIndex = 6;
            this.btn_expenseTracker.Text = "Expense Tracker";
            this.btn_expenseTracker.UseVisualStyleBackColor = true;
            this.btn_expenseTracker.Click += new System.EventHandler(this.btn_debtCounter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Compute_In.Properties.Resources._416370168_1048614279750598_1280637082707728801_n__1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Home.Image = global::Compute_In.Properties.Resources.icons8_home_page_46;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(12, 299);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(265, 46);
            this.btn_Home.TabIndex = 5;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.button1_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Silver;
            this.topPanel.Controls.Add(this.btn_close);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(289, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(822, 24);
            this.topPanel.TabIndex = 17;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::Compute_In.Properties.Resources.icons8_close_24__3_;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Cyan;
            this.btn_close.Location = new System.Drawing.Point(796, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(26, 27);
            this.btn_close.TabIndex = 16;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(289, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(822, 590);
            this.mainPanel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(339, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 58);
            this.label2.TabIndex = 5;
            this.label2.Text = "Developed By:\r\n      Group 3\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Compute_In.Properties.Resources.imageedit_2_4328054504;
            this.pictureBox2.Location = new System.Drawing.Point(55, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(727, 423);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1111, 614);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_DebtCounter;
        private System.Windows.Forms.Button btn_expenseTracker;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}