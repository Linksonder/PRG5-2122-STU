using DemoA.domain;
using System;


namespace DemoA
{
    class Program
    {
        static void Main(string[] args)
        {
            FortuneWeekendTeller teller = new FortuneWeekendTeller();

            IsHetWeekend resultaat = teller.WeekendChecker();

            Console.WriteLine("Welkom bij de weekend checker!");

            switch(resultaat)
            {
                case IsHetWeekend.Bietje: Console.WriteLine("It's friday again!!! saturday sunday what!"); break;
                case IsHetWeekend.JaHetIsWeekend: Console.WriteLine("Ik ga zwemmen in Bacardi lemouuun"); break;
                default: Console.WriteLine("Nog lange nie nog lange nie!");break;    
            }


        }
    }
}
