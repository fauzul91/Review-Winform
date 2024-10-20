namespace Review_Winform
{
    partial class FormIdentitas
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
            this.gunaLineDataset1 = new Guna.Charts.WinForms.GunaLineDataset();
            this.inputNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.labelHasilNama = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNIM = new System.Windows.Forms.Label();
            this.inputNIM = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelHasilNIM = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gunaLineDataset1
            // 
            this.gunaLineDataset1.BorderColor = System.Drawing.Color.Empty;
            this.gunaLineDataset1.FillColor = System.Drawing.Color.Empty;
            this.gunaLineDataset1.Label = "Line1";
            // 
            // inputNama
            // 
            this.inputNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputNama.DefaultText = "";
            this.inputNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inputNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputNama.Location = new System.Drawing.Point(609, 331);
            this.inputNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputNama.Name = "inputNama";
            this.inputNama.PasswordChar = '\0';
            this.inputNama.PlaceholderText = "";
            this.inputNama.SelectedText = "";
            this.inputNama.Size = new System.Drawing.Size(286, 60);
            this.inputNama.TabIndex = 1;
            this.inputNama.TextOffset = new System.Drawing.Point(10, 0);
            this.inputNama.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(523, 572);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(222, 71);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // labelHasilNama
            // 
            this.labelHasilNama.AutoSize = true;
            this.labelHasilNama.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasilNama.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHasilNama.Location = new System.Drawing.Point(433, 101);
            this.labelHasilNama.Name = "labelHasilNama";
            this.labelHasilNama.Size = new System.Drawing.Size(412, 56);
            this.labelHasilNama.TabIndex = 4;
            this.labelHasilNama.Text = "Namamu siapa?";
            this.labelHasilNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNama.Location = new System.Drawing.Point(345, 343);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(210, 30);
            this.labelNama.TabIndex = 5;
            this.labelNama.Text = "Masukkan nama";
            // 
            // labelNIM
            // 
            this.labelNIM.AutoSize = true;
            this.labelNIM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNIM.Location = new System.Drawing.Point(345, 446);
            this.labelNIM.Name = "labelNIM";
            this.labelNIM.Size = new System.Drawing.Size(186, 30);
            this.labelNIM.TabIndex = 7;
            this.labelNIM.Text = "Masukkan NIM";
            // 
            // inputNIM
            // 
            this.inputNIM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputNIM.DefaultText = "";
            this.inputNIM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputNIM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputNIM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputNIM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputNIM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputNIM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inputNIM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputNIM.Location = new System.Drawing.Point(609, 434);
            this.inputNIM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputNIM.Name = "inputNIM";
            this.inputNIM.PasswordChar = '\0';
            this.inputNIM.PlaceholderText = "";
            this.inputNIM.SelectedText = "";
            this.inputNIM.Size = new System.Drawing.Size(286, 60);
            this.inputNIM.TabIndex = 6;
            this.inputNIM.TextOffset = new System.Drawing.Point(10, 0);
            this.inputNIM.TextChanged += new System.EventHandler(this.inputUmur_TextChanged);
            // 
            // labelHasilNIM
            // 
            this.labelHasilNIM.AutoSize = true;
            this.labelHasilNIM.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasilNIM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHasilNIM.Location = new System.Drawing.Point(416, 180);
            this.labelHasilNIM.Name = "labelHasilNIM";
            this.labelHasilNIM.Size = new System.Drawing.Size(446, 56);
            this.labelHasilNIM.TabIndex = 8;
            this.labelHasilNIM.Text = "NIM kamu brapa?";
            this.labelHasilNIM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Image = global::Review_Winform.Properties.Resources.btnContinue;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(1095, 51);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 41);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormIdentitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1286, 837);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelHasilNIM);
            this.Controls.Add(this.labelNIM);
            this.Controls.Add(this.inputNIM);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelHasilNama);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.inputNama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIdentitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.Charts.WinForms.GunaLineDataset gunaLineDataset1;
        private Guna.UI2.WinForms.Guna2TextBox inputNama;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label labelHasilNama;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNIM;
        private Guna.UI2.WinForms.Guna2TextBox inputNIM;
        private System.Windows.Forms.Label labelHasilNIM;
        private System.Windows.Forms.Button btnBack;
    }
}

