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
    public partial class Emlak_Ana_Sayfa : Form
    {
        public Emlak_Ana_Sayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Ev_Ekle ev_Ekle = new Ev_Ekle();
            ev_Ekle.Show();
            this.Close();
        }
    }
}
