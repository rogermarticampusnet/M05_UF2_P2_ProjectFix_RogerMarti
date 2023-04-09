using System;

namespace DayOfTheWeek
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a day");
            int day = int.Parse(Console.ReadLine());
            int dayofweek = DayOfTheWeek(year, month, day);
            Console.WriteLine("The day of the week is:");
            switch (dayofweek)
            {
                case 0: Console.WriteLine("Sunday"); break;
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                default: Console.WriteLine("Unknown"); break;
            }
        }
        public static int DayOfTheWeek(int year, int month, int day)
        {
            // determinar si el mes es enero o febrero
            if (month < 3)
            {
                month += 12;
                year--;
            }
            
            // calcular el siglo y el año dentro del siglo
            int j = year / 100;
            int k = year % 100;
            
            // aplicar la fórmula de Zeller
            int h = (day + 13 * (month + 1) / 5 + k + k / 4 + j / 4 + 5 * j) % 7;
            
            // ajustar el resultado para que sea positivo
            if (h <= 0)
            {
                h += 7;
            }
            return h - 1;
        }
    }
}
