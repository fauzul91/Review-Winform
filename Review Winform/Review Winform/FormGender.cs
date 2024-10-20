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
    public partial class FormGender : Form
    {
        public FormGender()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormIdentitas formIdentitas = new FormIdentitas();
            formIdentitas.Show();
            this.Hide();
        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            labelInfoGender.Text = "Kamu adalah laki-laki";
            labelInfoGender.Left = (this.ClientSize.Width - labelInfoGender.Width) / 2;
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            labelInfoGender.Text = "Kamu adalah perempuan";
            labelInfoGender.Left = (this.ClientSize.Width - labelInfoGender.Width) / 2;
        }

        private void FormGender_Load(object sender, EventArgs e)
        {

        }
    }
}
