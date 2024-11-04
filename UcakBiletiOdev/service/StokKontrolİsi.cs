using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBiletiOdev.entity;

namespace UcakBiletiOdev.service
{
    public class StokKontrolİsi
    {
        public bool ucak1StokKontrolİsi(int ucak1Stok)
        {
            return ucak1Stok <= 0; 
        }

        public bool ucak2StokKontrolİsi(int ucak2Stok)
        {
            return ucak2Stok <= 0; 
        }

        public int ucak1StokDusurmeIsı(int ucak1Stok)
        {
            if (ucak1Stok > 0)
            {
                return ucak1Stok - 1; 
            }
            return ucak1Stok; 
        }

        public int ucak2StokDusurmeIsı(int ucak2Stok)
        {
            if (ucak2Stok > 0)
            {
                return ucak2Stok - 1; 
            }
            return ucak2Stok; 
        }


    }
}
