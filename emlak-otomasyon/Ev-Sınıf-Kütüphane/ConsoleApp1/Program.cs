using Ev_Sınıf_Kütüphane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev ev = new Ev();

            ev.Adres = "İstanbul";
            ev.odaSayisi = +2;
            ev.katNumarasi = +3;
            ev.katNumarasi = -3;
            
            Console.WriteLine("Oda Sayısı: " + ev.odaSayisi);
        }
    }
}
