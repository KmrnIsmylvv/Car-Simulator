using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_11._10._2021
{
    class Avtomobil
    {
        private int _maxbenzintutumu; //max benzin tutumu =50
        private double _benzin;
        private double _kilometr;
        private double _pul;
        public int Benzintutumu { get => _maxbenzintutumu; set => _maxbenzintutumu = value; }
        public double Kilometr { get => _kilometr; set => _kilometr = value; }
        public double Benzin { get => _benzin; set => _benzin = value; }
        public double Pul { get => _pul; set => _pul = value; }

        public string YuzKilometreYandirilanBenzin()
        {
            //Teqriben 100 km-e 10 litr benzin goturdum
            _benzin = _kilometr / 10;
            return $"100 km-ya yandirilan benzin: {_benzin} Litr";
        }

        public void YanacaqDoldurma(int litr)
        {
            _pul = litr * 1.2;
            _benzin += litr;
            if (_benzin <= 50)
            {
               
                Console.WriteLine($"Odeyeceyiniz Mebleg: {_pul} manat");
                Console.WriteLine($"Benzin: {_benzin} Litr");

            }
            if (_benzin > 50)
            {
                Console.WriteLine("Chen maksimum 50 litr tutur.");
            }
           
        }
        public string TamDoldurmaq()
        {
            _pul = Convert.ToInt32((_maxbenzintutumu - _benzin) * 1.2); //1 litr 1.20 man hesabladim
            _benzin = 50;
            Console.WriteLine($"Odeyeceyiniz mebleg: {_pul} manat");
            return $"Benzin: {_benzin} Litr";
        }
    }
}
