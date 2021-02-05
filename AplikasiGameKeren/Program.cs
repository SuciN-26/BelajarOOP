using System;

namespace AplikasiGameKeren
{
    class Program
    {
        static void Main(string[] args)
        {
            //MonsterGurita gurita = new MonsterGurita();
            //MonsterKelelawar kelelawar = new MonsterKelelawar();
            //MonsterKecoa kecoa = new MonsterKecoa();
            //MonsterKerbau kerbau = new MonsterKerbau();

            //gurita.Menyerang();
            //kelelawar.Menyerang();
            //kecoa.Menyerang();
            //kerbau.Menyerang();

            //Polymorphism
            //Monster[] monsters = new Monster[5];

            //monsters[0] = new MonsterGurita();
            //monsters[1] = new MonsterKelelawar();
            //monsters[2] = new MonsterKecoa();
            //monsters[3] = new MonsterKerbau();
            //monsters[4] = new MonsterKerbau();

            //for (int i = 0; i < monsters.Length; i++)
            //{
            //    if (!(monsters[i] is MonsterKerbau))
            //        monsters[i].Menyerang();
            //    else
            //        (monsters[i] as MonsterKerbau).Berjalan();
            //}

            //MonsterKerbau kerbau1, kerbau2;

            //kerbau1 = new MonsterKerbau();
            //kerbau2 = new MonsterKerbau();

            //Console.WriteLine("Nawa Kerbau 1 = {0}", kerbau1.Nyawa);
            //Console.WriteLine("Nawa Kerbau 2 = {0}", kerbau2.Nyawa);

            MonsterKerbau kerbau = new MonsterKerbau();
            MonsterKecoa kecoa = new MonsterKecoa();
            MonsterGurita gurita = new MonsterGurita();

            //kerbau.Menyerang();
            //kerbau.MelarikanDiri();
            //kecoa.Menyerang();
            //gurita.Menyerang();

            (kerbau as Monster).Menyerang();
            (kerbau as MonsterKerbau).Menyerang();
            (kerbau as Monster).MelarikanDiri();
            (kerbau as MonsterKerbau).MelarikanDiri();
        }
    }
}
