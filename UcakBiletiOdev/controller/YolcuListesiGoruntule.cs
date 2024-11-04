using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBiletiOdev.db;
using UcakBiletiOdev.service;

namespace UcakBiletiOdev.controller
{
    internal class YolcuListesiGoruntule
    {

        public void ucak1YolcuGoruntule()
        {
            YolcuListesiGoruntuleIsi ucak1YolcuListesiGoruntuleIsi = new YolcuListesiGoruntuleIsi();
            ucak1YolcuListesiGoruntuleIsi.Ucak1YolcuListesiGoruntule();
        }

        public void ucak2YolcuGoruntule()
        {
            YolcuListesiGoruntuleIsi ucak2YolcuListesiGoruntuleIsi = new YolcuListesiGoruntuleIsi();
            ucak2YolcuListesiGoruntuleIsi.Ucak2YolcuListesiGoruntule();
        }
    }
}
