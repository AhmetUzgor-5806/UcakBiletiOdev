using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBiletiOdev.entity;

namespace UcakBiletiOdev.service
{
    internal class Yoneticiİsleri
    {
     public int ucak1StokBelirleme ()
               
        { 
        
        UcakBiletiStok.ucak1Stok=Convert.ToInt32(Console.ReadLine());

            return UcakBiletiStok.ucak1Stok;
                  
        }
        public int ucak2StokBelirleme()

        {
            
            UcakBiletiStok.ucak2Stok = Convert.ToInt32(Console.ReadLine());

            return UcakBiletiStok.ucak2Stok;

        }

    }
}
