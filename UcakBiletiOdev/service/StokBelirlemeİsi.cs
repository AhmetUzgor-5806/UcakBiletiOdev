using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBiletiOdev.entity;

namespace UcakBiletiOdev.service
{
    internal class StokBelirlemeİsi
    {
        public void ucak1StokBelirleme(int ucak1Stok)
        {
            UcakBiletiStok.ucak1Stok = ucak1Stok;
        }

        public void ucak2StokBelirleme(int ucak2Stok)
        {
            UcakBiletiStok.ucak2Stok = ucak2Stok;
        }
    }
}
