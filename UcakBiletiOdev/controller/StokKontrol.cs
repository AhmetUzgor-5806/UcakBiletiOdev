using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBiletiOdev.entity;
using UcakBiletiOdev.service;

namespace UcakBiletiOdev.controller
{
    public class StokKontrol
    {
        public bool ucak1StokKontrol ()

        {
            
            StokKontrolİsi stokKontrolİsi = new StokKontrolİsi();
               
                                 
            return stokKontrolİsi.ucak1StokKontrolİsi(UcakBiletiStok.ucak1Stok); 

        }

        public bool ucak2StokKontrol()

        {
            
            StokKontrolİsi stokKontrolİsi = new StokKontrolİsi();
            

            return stokKontrolİsi.ucak2StokKontrolİsi(UcakBiletiStok.ucak2Stok);

        }

        public int ucak1StokDusurme()

        {
            
            StokKontrolİsi stokKontrolİsi = new StokKontrolİsi();


            return stokKontrolİsi.ucak1StokDusurmeIsı (UcakBiletiStok.ucak1Stok);

        }

        public int ucak2StokDusurme()

        {
            
            StokKontrolİsi stokKontrolİsi = new StokKontrolİsi();


            return stokKontrolİsi.ucak2StokDusurmeIsı(UcakBiletiStok.ucak2Stok);

        }




    }
}
