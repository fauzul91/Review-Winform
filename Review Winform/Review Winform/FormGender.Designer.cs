namespace Review_Winform
{
    partial class FormGender
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
            this.labelInfoGender = new System.Windows.Forms.Label();
            this.btnMale = new System.Windows.Forms.Button();
            this.btnFemale = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // labelInfoGender
            // 
            this.labelInfoGender.AutoSize = true;
            this.labelInfoGender.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoGender.ForeColor = System.Drawing.SystemColors.Control;
            this.labelInfoGender.Location = new System.Drawing.Point(319, 138);
            this.labelInfoGender.Name = "labelInfoGender";
            this.labelInfoGender.Size = new System.Drawing.Size(633, 56);
            this.labelInfoGender.TabIndex = 5;
            this.labelInfoGender.Text = "Jenis Kelamin Kamu Apa?";
            this.labelInfoGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMale
            // 
            this.btnMale.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMale.Location = new System.Drawing.Point(345, 548);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(222, 71);
            this.btnMale.TabIndex = 13;
            this.btnMale.Text = "Laki-laki";
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.Click += new System.EventHandler(this.btnMale_Click);
            // 
            // btnFemale
            // 
            this.btnFemale.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFemale.Location = new System.Drawing.Point(705, 548);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(222, 71);
            this.btnFemale.TabIndex = 14;
            this.btnFemale.Text = "Perempuan";
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.Click += new System.EventHandler(this.btnFemale_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Image = global::Review_Winform.Properties.Resources.btnBack;
            this.btnBack.Location = new System.Drawing.Point(40, 37);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 41);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.Image = global::Review_Winform.Properties.Resources.btnFemaleHover;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(50, 100);
            this.guna2ImageButton2.Image = global::Review_Winform.Properties.Resources.btnFemale;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(50, 100);
            this.guna2ImageButton2.Location = new System.Drawing.Point(615, 245);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton2.Size = new System.Drawing.Size(408, 315);
            this.guna2ImageButton2.TabIndex = 7;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = global::Review_Winform.Properties.Resources.btnMaleHover;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(50, 100);
            this.guna2ImageButton1.Image = global::Review_Winform.Properties.Resources.btnMale;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(50, 100);
            this.guna2ImageButton1.Location = new System.Drawing.Point(277, 232);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton1.Size = new System.Drawing.Size(354, 346);
            this.guna2ImageButton1.TabIndex = 6;
            // 
            // FormGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1286, 837);
            this.Controls.Add(this.btnFemale);
            this.Controls.Add(this.btnMale);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.labelInfoGender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGender";
            this.Load += new System.EventHandler(this.FormGender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoGender;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMale;
        private System.Windows.Forms.Button btnFemale;
    }
}