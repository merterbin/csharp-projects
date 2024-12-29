using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Uygulama
{
    public partial class Emlak_Giris_Ekrani : Form
    {
        public Emlak_Giris_Ekrani()
        {
            InitializeComponent();
        }
        public Emlak_Giris_Ekrani(IContainer components, Label label1, TextBox kullaniciAdiTB, Label label2, TextBox sifreTB, Button button1, Label label3)
        {
            this.components = components;
            this.label1 = label1;
            this.kullaniciAdiTB = kullaniciAdiTB;
            this.label2 = label2;
            this.sifreTB = sifreTB;
            this.button1 = button1;
            this.label3 = label3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiTB.Text == "admin" && sifreTB.Text == "1234")
            {
                Emlak_Ana_Sayfa emlak_Ana_Sayfa = new Emlak_Ana_Sayfa();
                emlak_Ana_Sayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
        }
    }
}
