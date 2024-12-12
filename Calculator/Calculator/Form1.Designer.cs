namespace Calculator
{
    partial class MAINFORM
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
            this.MainName = new System.Windows.Forms.Label();
            this.Start_bt = new System.Windows.Forms.Button();
            this.Load_bt = new System.Windows.Forms.Button();
            this.Quit_bt = new System.Windows.Forms.Button();
            this.Demand_lb = new System.Windows.Forms.Label();
            this.Expression_txtb = new System.Windows.Forms.TextBox();
            this.Cal_bt = new System.Windows.Forms.Button();
            this.Equal_lb = new System.Windows.Forms.Label();
            this.result_txtb = new System.Windows.Forms.TextBox();
            this.continue_bt = new System.Windows.Forms.Button();
            this.title_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainName
            // 
            this.MainName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainName.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainName.Location = new System.Drawing.Point(61, 39);
            this.MainName.Name = "MainName";
            this.MainName.Size = new System.Drawing.Size(671, 74);
            this.MainName.TabIndex = 0;
            this.MainName.Text = "BINARY TREE CALCULATOR";
            this.MainName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start_bt
            // 
            this.Start_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Start_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Start_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Start_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_bt.Location = new System.Drawing.Point(303, 182);
            this.Start_bt.Name = "Start_bt";
            this.Start_bt.Size = new System.Drawing.Size(195, 47);
            this.Start_bt.TabIndex = 1;
            this.Start_bt.Text = "START";
            this.Start_bt.UseVisualStyleBackColor = false;
            this.Start_bt.Click += new System.EventHandler(this.Start_bt_Click);
            // 
            // Load_bt
            // 
            this.Load_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Load_bt.Enabled = false;
            this.Load_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Load_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.Load_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_bt.Location = new System.Drawing.Point(303, 247);
            this.Load_bt.Name = "Load_bt";
            this.Load_bt.Size = new System.Drawing.Size(195, 47);
            this.Load_bt.TabIndex = 2;
            this.Load_bt.Text = "LOAD";
            this.Load_bt.UseVisualStyleBackColor = false;
            this.Load_bt.Click += new System.EventHandler(this.Load_bt_Click);
            // 
            // Quit_bt
            // 
            this.Quit_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quit_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Quit_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Quit_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Quit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_bt.Location = new System.Drawing.Point(303, 311);
            this.Quit_bt.Name = "Quit_bt";
            this.Quit_bt.Size = new System.Drawing.Size(195, 47);
            this.Quit_bt.TabIndex = 3;
            this.Quit_bt.Text = "QUIT";
            this.Quit_bt.UseVisualStyleBackColor = false;
            this.Quit_bt.Click += new System.EventHandler(this.Quit_bt_Click);
            // 
            // Demand_lb
            // 
            this.Demand_lb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Demand_lb.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Demand_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Demand_lb.Location = new System.Drawing.Point(122, 151);
            this.Demand_lb.Name = "Demand_lb";
            this.Demand_lb.Size = new System.Drawing.Size(610, 67);
            this.Demand_lb.TabIndex = 4;
            this.Demand_lb.Text = "Nhập biểu thức cần tính toán";
            this.Demand_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Demand_lb.Visible = false;
            // 
            // Expression_txtb
            // 
            this.Expression_txtb.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expression_txtb.Location = new System.Drawing.Point(129, 221);
            this.Expression_txtb.Multiline = true;
            this.Expression_txtb.Name = "Expression_txtb";
            this.Expression_txtb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Expression_txtb.Size = new System.Drawing.Size(369, 55);
            this.Expression_txtb.TabIndex = 5;
            this.Expression_txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Expression_txtb.Visible = false;
            // 
            // Cal_bt
            // 
            this.Cal_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cal_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Cal_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Cal_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cal_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cal_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cal_bt.Location = new System.Drawing.Point(555, 221);
            this.Cal_bt.Name = "Cal_bt";
            this.Cal_bt.Size = new System.Drawing.Size(116, 56);
            this.Cal_bt.TabIndex = 6;
            this.Cal_bt.Text = "CAL";
            this.Cal_bt.UseVisualStyleBackColor = false;
            this.Cal_bt.Visible = false;
            this.Cal_bt.Click += new System.EventHandler(this.Cal_bt_Click);
            // 
            // Equal_lb
            // 
            this.Equal_lb.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Equal_lb.Location = new System.Drawing.Point(504, 221);
            this.Equal_lb.Name = "Equal_lb";
            this.Equal_lb.Size = new System.Drawing.Size(45, 56);
            this.Equal_lb.TabIndex = 7;
            this.Equal_lb.Text = "=";
            this.Equal_lb.Visible = false;
            // 
            // result_txtb
            // 
            this.result_txtb.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_txtb.Location = new System.Drawing.Point(555, 221);
            this.result_txtb.Multiline = true;
            this.result_txtb.Name = "result_txtb";
            this.result_txtb.ReadOnly = true;
            this.result_txtb.Size = new System.Drawing.Size(141, 55);
            this.result_txtb.TabIndex = 8;
            this.result_txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.result_txtb.Visible = false;
            // 
            // continue_bt
            // 
            this.continue_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continue_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.continue_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.continue_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.continue_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continue_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_bt.Location = new System.Drawing.Point(243, 391);
            this.continue_bt.Name = "continue_bt";
            this.continue_bt.Size = new System.Drawing.Size(196, 47);
            this.continue_bt.TabIndex = 9;
            this.continue_bt.Text = "CONTINUE";
            this.continue_bt.UseVisualStyleBackColor = false;
            this.continue_bt.Visible = false;
            this.continue_bt.Click += new System.EventHandler(this.continue_bt_Click);
            // 
            // title_bt
            // 
            this.title_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.title_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.title_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.title_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_bt.Location = new System.Drawing.Point(445, 391);
            this.title_bt.Name = "title_bt";
            this.title_bt.Size = new System.Drawing.Size(136, 47);
            this.title_bt.TabIndex = 10;
            this.title_bt.Text = "TITLE";
            this.title_bt.UseVisualStyleBackColor = false;
            this.title_bt.Visible = false;
            this.title_bt.Click += new System.EventHandler(this.title_bt_Click);
            // 
            // MAINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title_bt);
            this.Controls.Add(this.continue_bt);
            this.Controls.Add(this.result_txtb);
            this.Controls.Add(this.Equal_lb);
            this.Controls.Add(this.Cal_bt);
            this.Controls.Add(this.Expression_txtb);
            this.Controls.Add(this.Demand_lb);
            this.Controls.Add(this.Quit_bt);
            this.Controls.Add(this.Load_bt);
            this.Controls.Add(this.Start_bt);
            this.Controls.Add(this.MainName);
            this.MaximizeBox = false;
            this.Name = "MAINFORM";
            this.Text = "CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainName;
        private System.Windows.Forms.Button Start_bt;
        private System.Windows.Forms.Button Load_bt;
        private System.Windows.Forms.Button Quit_bt;
        private System.Windows.Forms.Label Demand_lb;
        private System.Windows.Forms.TextBox Expression_txtb;
        private System.Windows.Forms.Button Cal_bt;
        private System.Windows.Forms.Label Equal_lb;
        private System.Windows.Forms.TextBox result_txtb;
        private System.Windows.Forms.Button continue_bt;
        private System.Windows.Forms.Button title_bt;
    }
}

