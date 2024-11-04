using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBiletiOdev.entity;
using UcakBiletiOdev.service;

namespace UcakBiletiOdev.controller
{
    public class YolcuKaydetme
    {
        public void ucak1YolcuKaydet(string ad, string soyad)

        {
            YolcuKaydet yolcuKaydet = new YolcuKaydet();

            yolcuKaydet.ucak1yolcuEkle( ad, soyad);

        }

        public void ucak2YolcuKaydet(string ad, string soyad)

        {
            YolcuKaydet yolcuKaydet = new YolcuKaydet();

            yolcuKaydet.ucak2yolcuEkle(ad, soyad);

        }

    }
}
