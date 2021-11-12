using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int time=Convert.ToInt32(Console.ReadLine()); //DateTime.Now.Hour;
            if(time >= 6 && time <=11)
            Console.WriteLine("Günaydın");
            else if(time < 18 && time > 6 )
            Console.WriteLine("İyi günler");
            else
            Console.WriteLine("iyi geceler");


        }
    }
}
