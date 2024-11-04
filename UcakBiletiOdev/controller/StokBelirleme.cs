using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBiletiOdev.service;

namespace UcakBiletiOdev.controller
{
    internal class StokBelirleme
    {
         public void ucak1StokBelirleme (int ucak1Stok) 
         {
            StokBelirlemeİsi ucak1StokKontrol = new StokBelirlemeİsi();
            ucak1StokKontrol.ucak1StokBelirleme(ucak1Stok);
        
         }

        public void ucak2StokBelirleme(int ucak2Stok)
        {
            StokBelirlemeİsi ucak2StokKontrol = new StokBelirlemeİsi();
            ucak2StokKontrol.ucak2StokBelirleme(ucak2Stok);

        }


    }
}
