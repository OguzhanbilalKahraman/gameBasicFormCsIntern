using irelia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irelia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hesap hesap = new Hesap();

        private void label3_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
           
            hesap.kullaniciAdi = textBox1.Text;
            hesap.rol = comboBox1.SelectedItem.ToString();
            durumDegistirme(false);
            gorunusDegistirme(true);

        }

        public void durumDegistirme(bool durum)
        {
            textBox1.Enabled = durum;
            comboBox1.Enabled = durum;
            btnSec.Enabled = durum;
        }


        public void gorunusDegistirme(bool gorunus)
        {
            lblCan.Visible = gorunus;
            pictureBox1.Visible = gorunus;
            btnSaldir.Visible = gorunus;
        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            hesap.Saldiri();
            lblCan.Width -= hesap.damage;
            MessageBox.Show($" Teq Düşmana {hesap.damage} kadar hasar verildi. ");

            if (lblCan.Width<=0)
            {
                MessageBox.Show("Noxusu Topraklarımızdan kovduk !!");
                pictureBox1.Visible = false;
                btnSaldir.Visible = false;
            }
        }
    }
}
