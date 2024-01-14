namespace Compute_In.Forms
{
    partial class Calculator
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
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonBckspc = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDvd = new System.Windows.Forms.Button();
            this.buttonMltpl = new System.Windows.Forms.Button();
            this.buttonSbrct = new System.Windows.Forms.Button();
            this.buttonAd = new System.Windows.Forms.Button();
            this.buttonEql = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonPcnt = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::Compute_In.Properties.Resources.icons8_close_24__3_;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Cyan;
            this.btn_close.Location = new System.Drawing.Point(306, -2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(26, 27);
            this.btn_close.TabIndex = 17;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Controls.Add(this.btn_close);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(332, 25);
            this.topPanel.TabIndex = 19;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(26, 137);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(50, 50);
            this.buttonC.TabIndex = 20;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            // 
            // buttonBckspc
            // 
            this.buttonBckspc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.buttonBckspc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBckspc.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBckspc.ForeColor = System.Drawing.Color.White;
            this.buttonBckspc.Location = new System.Drawing.Point(97, 137);
            this.buttonBckspc.Name = "buttonBckspc";
            this.buttonBckspc.Size = new System.Drawing.Size(58, 50);
            this.buttonBckspc.TabIndex = 21;
            this.buttonBckspc.Text = "<-";
            this.buttonBckspc.UseVisualStyleBackColor = false;
            // 
            // buttonL
            // 
            this.buttonL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.buttonL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonL.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL.ForeColor = System.Drawing.Color.White;
            this.buttonL.Location = new System.Drawing.Point(178, 137);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(50, 50);
            this.buttonL.TabIndex = 22;
            this.buttonL.Text = "(";
            this.buttonL.UseVisualStyleBackColor = false;
            // 
            // buttonR
            // 
            this.buttonR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.buttonR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonR.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonR.ForeColor = System.Drawing.Color.White;
            this.buttonR.Location = new System.Drawing.Point(253, 137);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(50, 50);
            this.buttonR.TabIndex = 23;
            this.buttonR.Text = ")";
            this.buttonR.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(178, 203);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 24;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(178, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 25;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(101, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 26;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(101, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 27;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(101, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 28;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 29;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(178, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 30;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(26, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 31;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(26, 203);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 32;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // buttonDvd
            // 
            this.buttonDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(51)))));
            this.buttonDvd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDvd.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDvd.ForeColor = System.Drawing.Color.White;
            this.buttonDvd.Location = new System.Drawing.Point(253, 203);
            this.buttonDvd.Name = "buttonDvd";
            this.buttonDvd.Size = new System.Drawing.Size(50, 50);
            this.buttonDvd.TabIndex = 33;
            this.buttonDvd.Text = "/";
            this.buttonDvd.UseVisualStyleBackColor = false;
            // 
            // buttonMltpl
            // 
            this.buttonMltpl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(51)))));
            this.buttonMltpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMltpl.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMltpl.ForeColor = System.Drawing.Color.White;
            this.buttonMltpl.Location = new System.Drawing.Point(253, 270);
            this.buttonMltpl.Name = "buttonMltpl";
            this.buttonMltpl.Size = new System.Drawing.Size(50, 50);
            this.buttonMltpl.TabIndex = 34;
            this.buttonMltpl.Text = "X";
            this.buttonMltpl.UseVisualStyleBackColor = false;
            // 
            // buttonSbrct
            // 
            this.buttonSbrct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(51)))));
            this.buttonSbrct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSbrct.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSbrct.ForeColor = System.Drawing.Color.White;
            this.buttonSbrct.Location = new System.Drawing.Point(253, 335);
            this.buttonSbrct.Name = "buttonSbrct";
            this.buttonSbrct.Size = new System.Drawing.Size(50, 50);
            this.buttonSbrct.TabIndex = 35;
            this.buttonSbrct.Text = "-";
            this.buttonSbrct.UseVisualStyleBackColor = false;
            // 
            // buttonAd
            // 
            this.buttonAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(51)))));
            this.buttonAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAd.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAd.ForeColor = System.Drawing.Color.White;
            this.buttonAd.Location = new System.Drawing.Point(253, 401);
            this.buttonAd.Name = "buttonAd";
            this.buttonAd.Size = new System.Drawing.Size(50, 50);
            this.buttonAd.TabIndex = 36;
            this.buttonAd.Text = "+";
            this.buttonAd.UseVisualStyleBackColor = false;
            // 
            // buttonEql
            // 
            this.buttonEql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(51)))));
            this.buttonEql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEql.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEql.ForeColor = System.Drawing.Color.White;
            this.buttonEql.Location = new System.Drawing.Point(90, 470);
            this.buttonEql.Name = "buttonEql";
            this.buttonEql.Size = new System.Drawing.Size(149, 50);
            this.buttonEql.TabIndex = 37;
            this.buttonEql.Text = "=";
            this.buttonEql.UseVisualStyleBackColor = false;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(101, 401);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 50);
            this.button0.TabIndex = 38;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.ForeColor = System.Drawing.Color.White;
            this.buttonDot.Location = new System.Drawing.Point(26, 401);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(50, 50);
            this.buttonDot.TabIndex = 39;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            // 
            // buttonPcnt
            // 
            this.buttonPcnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.buttonPcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPcnt.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPcnt.ForeColor = System.Drawing.Color.White;
            this.buttonPcnt.Location = new System.Drawing.Point(178, 401);
            this.buttonPcnt.Name = "buttonPcnt";
            this.buttonPcnt.Size = new System.Drawing.Size(50, 50);
            this.buttonPcnt.TabIndex = 40;
            this.buttonPcnt.Text = "%";
            this.buttonPcnt.UseVisualStyleBackColor = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 549);
            this.Controls.Add(this.buttonPcnt);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonEql);
            this.Controls.Add(this.buttonAd);
            this.Controls.Add(this.buttonSbrct);
            this.Controls.Add(this.buttonMltpl);
            this.Controls.Add(this.buttonDvd);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonBckspc);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonBckspc;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonDvd;
        private System.Windows.Forms.Button buttonMltpl;
        private System.Windows.Forms.Button buttonSbrct;
        private System.Windows.Forms.Button buttonAd;
        private System.Windows.Forms.Button buttonEql;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonPcnt;
    }
}