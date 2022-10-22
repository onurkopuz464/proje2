using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
             int x,y,z,toplam;


             x = 4;
             y = 8;
             z = 12;
             toplam = 16;
             x +=2;
             y *=2;
             z /=4;

             bool success = true;
             bool unsuccess = x<y;

             if(success && unsuccess)
             {
                Console.WriteLine("okey!");
             }
             
             toplam = toplam%y;
             Console.WriteLine(toplam);









        }
    }
}