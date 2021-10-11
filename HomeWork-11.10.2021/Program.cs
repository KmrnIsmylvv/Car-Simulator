using System;

namespace HomeWork_11._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Avtomobil avt = new Avtomobil();

            avt.Benzintutumu = 50;
            Console.WriteLine($"Maksimum benzin tutumu: {avt.Benzintutumu} Litr \n");

            avt.Benzin = 50;
            Console.WriteLine($"Hal-hazirda olan benzin: {avt.Benzin} Litr \n");

            avt.Kilometr = 345;
            Console.WriteLine($"Gedilen Yol: {avt.Kilometr} Km \n");

            //Console.WriteLine(avt.YuzKilometreYandirilanBenzin() + "\n");

            avt.YanacaqDoldurma(5);

            //Console.WriteLine(avt.TamDoldurmaq());

        }
    }
}
