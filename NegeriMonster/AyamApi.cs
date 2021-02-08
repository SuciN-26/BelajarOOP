using System;
using System.Collections.Generic;
using System.Text;

namespace NegeriMonster
{
    public class AyamApi : AyamImoet, IDapatMenyemburkanApi
    {
        public override void Bobo()
        {
            Console.WriteLine("Ayam Api sedang bobo siang...");
        }

        public void MenyemburkanApi()
        {
            Console.WriteLine("Semburan Api maha Dahsyat versi Ayam!!!");
        }

        public void MenyemburkanApi(int n)
        {
            for (int i = 0; i < n; i++)
                MenyemburkanApi();
        }
    }
}
