using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBiletiOdev.db;
using UcakBiletiOdev.NewFolder;

namespace UcakBiletiOdev.service
{
    internal class YolcuKaydet
    {

        public void ucak1yolcuEkle(String ad, String soyad)
        {
            YolcuOzellikleri yolcu = new YolcuOzellikleri();
            yolcu.yolcuAdı = ad;
            yolcu.yolcuSoyadı = soyad;
            
            DataBase db = new DataBase();
            db.ucak1YolcuEkle(yolcu);
            

        }

        public void ucak2yolcuEkle(String ad, String soyad)
        {
            YolcuOzellikleri yolcu = new YolcuOzellikleri();
            yolcu.yolcuAdı = ad;
            yolcu.yolcuSoyadı = soyad;

            DataBase db = new DataBase();
            db.ucak2YolcuEkle(yolcu);


        }
    }
}
