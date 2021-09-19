using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab kasutaja vanust konsoolis;
            //"oled sündinud aastal {yearOfBirth}"


            Console.WriteLine("Palun, sisesta oma vanus:");

            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;
            Console.WriteLine("Oled sündinud aastal "+ userAge );




        }
    }
}
