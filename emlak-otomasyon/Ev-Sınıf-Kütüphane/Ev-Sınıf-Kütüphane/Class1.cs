
namespace Ev_Sinif_Kütüphane

{
    public enum Tur
    {
        Daire,
        Müstakil,
        Dubleks,
        Villa,
        Yazlık
    }
    public class Ev
    {
        private int _odaSayisi;
        private int _katNumarasi;
        private string _Semt;
        private int _Alan;
        private int _yapimYili;
        private bool _aktif;
        private int _emlakNumarasi;
        private Tur _Tur;
        public Ev()
        {
            _odaSayisi = 0;
            _katNumarasi = 0;
            _Semt = "Merkez";
            _Alan = 0;
            _yapimYili = 1900;
            _aktif = true;
            _emlakNumarasi = 1000;
            _Tur = Tur.Daire;
        }
        public int odaSayisi { get { return _odaSayisi; } set 
            { if (value < 0) { LogOdaSayisi(value); _odaSayisi = 0; } else LogOdaSayisi(value); _odaSayisi = value; } }
        public int katNumarasi { get { return _katNumarasi; } set 
            { if(value < 0) { LogKatNumarasi(value); _odaSayisi = 0; } else LogKatNumarasi(value); _odaSayisi = value; } }
        public string Semt { get { return _Semt; } set { LogSemt(value); _Semt = value; } }
        public int Alan { get { return _Alan; } set 
            { if (value < 0) { LogAlan(value); _Alan = 0; } else { LogAlan(value); _Alan = value; } } }
        public int yapimYili { get { return _yapimYili; } set 
            { if (value < 1800) { LogYapimYil(value); _yapimYili = 1900;}else{LogYapimYil(value);_yapimYili = value;}} }
        public bool aktif { get { return _aktif; } set { LogAktif(value); _aktif = value; } }
        public int emlakNumarasi { get { return _emlakNumarasi; } set {LogEmlkNo(value); _emlakNumarasi = value; } }
        public Tur Tur { get { return _Tur; } set { _Tur = value; } }

        private void LogOdaSayisi(int value)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                if (value < 0)
                    sw.WriteLine("Oda sayısı hatalı girildi: " + value);
                else if (value > 0)
                    sw.WriteLine("Oda sayısı geçerli girildi: " + value);
            }
        }
        private void LogKatNumarasi(int value)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                if (value < 0)
                    sw.WriteLine("Kat numarası hatalı girildi: " + value);
                else if (value > 0)
                    sw.WriteLine("Kat numarası geçerli girildi: " + value);
            }
        }
        private void LogSemt(string value)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                if (value == null)
                    sw.WriteLine("Semt hatalı girildi: " + value);
                else if (value != null)
                    sw.WriteLine("Semt geçerli girildi: " + value);
            }
        }
        private void LogAlan(int value)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                if (value < 0)
                    sw.WriteLine("Alan hatalı girildi: " + value);
                else if (value > 0)
                    sw.WriteLine("Alan geçerli girildi: " + value);
            }
        }
        private void LogYapimYil(int value)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                if (value < 1800)
                    sw.WriteLine("Yapım yılı hatalı girildi: " + value);
                else if (value > 1800)
                    sw.WriteLine("Yapım yılı geçerli girildi: " + value);
            }
        }
        private void LogAktif(bool value)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
               if (value != _aktif)
                    sw.WriteLine("Aktiflik durumu değişti: " + value);

            }
        }
        private void LogEmlkNo(int value)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                if (value < 0)
                    sw.WriteLine("Emlak numarası hatalı girildi: " + value);
                else if (value > 0)
                    sw.WriteLine("Emlak numarası geçerli girildi: " + value);
            }
        }

        public virtual string EvBilgileri()
        {
            string evBilgiler =
                string.Format("Oda Sayısı: {0}\nKat Numarası: {1}\nSemt: {2}\nAlan: {3}\nYapım Yılı: {4}\nTürü: {5}\nEmlak Numarası: {6}\nAktiflik Durumu: {7}\n",
                 _odaSayisi, _katNumarasi, _Semt, _Alan, _yapimYili, _Tur, _emlakNumarasi, _aktif);
            return evBilgiler;
        }
        public double FiyatHesapla(int odaSayi) 
        {
            int carpan = 200;
            if (File.Exists("room_cost.txt"))
                carpan = Convert.ToInt32(File.ReadAllText("room_cost.txt"));

            double fiyat = odaSayi * carpan;
            return fiyat;
        }


    }

    public class Kiralik_Ev : Ev
    {
        private double _Depozito;
        private double _kiraBedeli;
        public Kiralik_Ev()
        {
            _Depozito = 0;
            _kiraBedeli = 0;
        }
        
        
        public double Depozito { get { return _Depozito; } set { _Depozito = value; } }
        public double kiraBedeli { get { return _kiraBedeli; } set { _kiraBedeli = value; } }

        public override string EvBilgileri()
        {
            string evBilgileri = 
                string.Format(EvBilgileri() + "Depozito: {0}\nKira Bedeli: {1}\n", Depozito, kiraBedeli);
            return evBilgileri;
                
        }

    }
    public class Satilik_Ev : Ev
    {
        private double _Fiyat;
        public Satilik_Ev()
        {
            _Fiyat = 0;
        }
        public double Fiyat { get { return _Fiyat; } set { _Fiyat = value; } }
        public override string EvBilgileri()
        {
            string evBilgileri = 
                string.Format(EvBilgileri() + "Fiyat: {0}\n", Fiyat);
            return evBilgileri;
        }
    
    }

    






}
