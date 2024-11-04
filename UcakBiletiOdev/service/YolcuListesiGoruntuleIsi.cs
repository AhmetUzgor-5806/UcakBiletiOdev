using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBiletiOdev.db;

namespace UcakBiletiOdev.service
{
    internal class YolcuListesiGoruntuleIsi
    {
        DataBase dataBase =new DataBase();


        public void Ucak1YolcuListesiGoruntule()
        {
            dataBase.Ucak1YolcuListesiniYazdir();
        }

        public void Ucak2YolcuListesiGoruntule()
        {
            dataBase.Ucak2YolcuListesiniYazdir();
        }

    }
}
