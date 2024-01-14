namespace Compute_In.Forms
{
    partial class BudgetPlannerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetPlannerPage));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calculator = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budget Planner";
            // 
            // btn_Calculator
            // 
            this.btn_Calculator.BackgroundImage = global::Compute_In.Properties.Resources.icons8_calculator_64;
            this.btn_Calculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Calculator.FlatAppearance.BorderSize = 0;
            this.btn_Calculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calculator.Location = new System.Drawing.Point(711, 202);
            this.btn_Calculator.Name = "btn_Calculator";
            this.btn_Calculator.Size = new System.Drawing.Size(62, 59);
            this.btn_Calculator.TabIndex = 3;
            this.btn_Calculator.UseVisualStyleBackColor = true;
            this.btn_Calculator.Click += new System.EventHandler(this.btn_Calculator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 96);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(585, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calculator button ->\r\n";
            // 
            // BudgetPlannerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(822, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Calculator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BudgetPlannerPage";
            this.Text = "BudgetPlannerPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calculator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}