ENUM
using System;

namespace gendery
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int N = int.Parse(Console.ReadLine());
                if ((N & (int)ДеньНедели.Вторник) == (int)ДеньНедели.Вторник(N & (int)ДеньНедели.Среда) == (int)ДеньНедели.Среда)
                {
                    Console.WriteLine("Среда или Вторник");
                    break;
                }
                if ((N & (int)ДеньНедели.Четверг) == (int)ДеньНедели.Четверг(N & (int)ДеньНедели.Пятница) == (int)ДеньНедели.Пятница)
                {
                    Console.WriteLine("Четверг или Пятница");
                    break;
                }
                if ((N & (int)ДеньНедели.Суббота) == (int)ДеньНедели.Суббота || (N & (int)ДеньНедели.Воскресенье) == (int)ДеньНедели.Воскресенье)
                {
                    Console.WriteLine("Суббота или Воскресенье");
                    break;
                }
                else
                {
                    Console.WriteLine("Понедельник");
                    break;
                }


            }
        }
    }
}
enum ДеньНедели
{
    Понедельник = 1,
    Вторник = 2,
    Среда = 4,
    Четверг = 8,
    Пятница = 16,
    Суббота = 32,
    Воскресенье = 64

}

