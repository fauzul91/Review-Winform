using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review_Winform
{
    public partial class FormIdentitas : Form
    {
        public FormIdentitas()
        {
            InitializeComponent();
            btnSimpan.Enabled = false;
        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {
            if (labelNama.Text == "")
            {
                btnSimpan.Enabled = false;
            }
            else
            {
                btnSimpan.Enabled= true;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        { 
            labelHasilNama.Text = inputNama.Text;
            labelHasilNIM.Text = inputNIM.Text;

            labelHasilNama.Left = (this.ClientSize.Width - labelHasilNama.Width) / 2;
            labelHasilNIM.Left = (this.ClientSize.Width - labelHasilNIM.Width) / 2;
        }

        private void inputUmur_TextChanged(object sender, EventArgs e)
        {
            if (labelNIM.Text == "")
            {
                btnSimpan.Enabled = false;
            }
            else
            {
                btnSimpan.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormGender formGender = new FormGender();
            formGender.Show();
            this.Hide();
        }
    }
}
