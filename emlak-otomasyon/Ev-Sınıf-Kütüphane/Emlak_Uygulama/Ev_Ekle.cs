using System;

using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Diagnostics.Tracing;
using Ev_Sinif_Kütüphane;




namespace Emlak_Uygulama
{
 
    public partial class Ev_Ekle : Form
    {

        public Ev_Ekle()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (satisCB.SelectedItem == "Satılık")
            {
                Satilik_Ev satilik_Ev = new Satilik_Ev
                {
                    aktif = true,
                    Semt = semtCB.SelectedItem.ToString(),
                    yapimYili = Convert.ToInt32(yilTB.Text),
                    katNumarasi = Convert.ToInt32(katTB.Text),
                    odaSayisi = Convert.ToInt32(odaSayiTB.Text),
                    Alan = Convert.ToInt32(metreTB.Text),
                    Tur = (Tur)Enum.Parse(typeof(Tur), turCB.SelectedItem.ToString())
                };
                satilik_Ev.emlakNumarasi = satilik_Ev.emlakNumarasi + 1;
                MessageBox.Show("Satılık Ev eklendi.");
            }
            else if (satisCB.SelectedItem == "Kiralık")
            {
                Kiralik_Ev kiralik_Ev = new Kiralik_Ev
                {
                    aktif = true,
                    Semt = semtCB.SelectedItem.ToString(),
                    yapimYili = Convert.ToInt32(yilTB.Text),
                    katNumarasi = Convert.ToInt32(katTB.Text),
                    odaSayisi = Convert.ToInt32(odaSayiTB.Text),
                    Alan = Convert.ToInt32(metreTB.Text),
                    Tur = (Tur)Enum.Parse(typeof(Tur), turCB.SelectedItem.ToString())
                };
                kiralik_Ev.emlakNumarasi = kiralik_Ev.emlakNumarasi + 1;
                MessageBox.Show("Kiralık Ev eklendi.");
            }

            Emlak_Ana_Sayfa emlak_Ana_Sayfa = new Emlak_Ana_Sayfa();
            emlak_Ana_Sayfa.Show();
            this.Close();
            
        }
    }
}
