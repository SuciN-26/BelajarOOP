using System;
using System.Collections.Generic;
using System.Text;

namespace NegeriMonster
{
    public class NagaPerkasa : Monster, IDapatMenyemburkanApi
    {
        public override void Bobo()
        {
            Console.WriteLine("Naga Perkasa sedang bobo siang...");
        }

        public void MenyemburkanApi()
        {
            Console.WriteLine("Semburan Api Maha Dahsyat !!!");
        }

        public void Terbang()
        {
            Console.WriteLine("Naga Terbang Menjelajah Langit !!!");
        }
    }
}
