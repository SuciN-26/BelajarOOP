using System;
using System.Collections.Generic;

namespace NegeriMonster
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Monster> monsters = new List<Monster>();

            //monsters.Add(new NagaPerkasa());
            //monsters.Add(new AyamImoet());
            //monsters.Add(new AyamApi());

            //foreach (Monster monster in monsters)
            //{
            //    if (monster is IDapatMenyemburkanApi)
            //        (monster as IDapatMenyemburkanApi).MenyemburkanApi();
            //}

            AyamApi ayamApi = new AyamApi();

            Console.WriteLine("Method 1 :");
            ayamApi.MenyemburkanApi();

            Console.WriteLine("Method 2 :");
            ayamApi.MenyemburkanApi(3);
        }
    }
}
