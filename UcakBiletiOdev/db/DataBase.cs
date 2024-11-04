using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBiletiOdev.NewFolder;

namespace UcakBiletiOdev.db
{
    internal class DataBase
    {
        public static List<YolcuOzellikleri> ucak1 = new List<YolcuOzellikleri> ();
        public static List<YolcuOzellikleri> ucak2 = new List<YolcuOzellikleri>();

        public void ucak1YolcuEkle(YolcuOzellikleri yolcu)
        {
            ucak1.Add(yolcu);
        }

        public void ucak2YolcuEkle(YolcuOzellikleri yolcu)
        {
            ucak2.Add(yolcu);
        }

        public void Ucak1YolcuListesiniYazdir()
        {
            Console.WriteLine("Uçak 1 Yolcu Listesi:");
            foreach (var yolcu in ucak1)
            {
                Console.WriteLine($"{yolcu.yolcuAdı} {yolcu.yolcuSoyadı}");
            }
        }

        public void Ucak2YolcuListesiniYazdir()
        {
            Console.WriteLine("Uçak 2 Yolcu Listesi:");
            foreach (var yolcu in ucak2)
            {
                Console.WriteLine($"{yolcu.yolcuAdı} {yolcu.yolcuSoyadı}");
            }
        }

    }
}
