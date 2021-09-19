using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutaja sunniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsooli;

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());



            int useAge = 2021 - yearOfBirth;

            //Console.WriteLine("Oled " + useAge + "aastat vana.");

            //string interpolation



        }
    }
}
