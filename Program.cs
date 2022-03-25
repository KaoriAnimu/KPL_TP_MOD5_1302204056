using System;

namespace TPKPL5
{
    class Program
    {
        static void Main(string[] args)

        {
            SayaTubeVideo saya = new SayaTubeVideo(" Tutorial Design By Contract - Moch. Kaori Rahadian ") ;

            saya.IncreasePlayCount(0) ;

            saya.PrintVideoDetails() ;

            Console.WriteLine() ;

            SayaTubeVideo saya1 = new SayaTubeVideo(" Moch. Kaori Rahadian ") ;

            saya1.IncreasePlayCount(1000000000) ;

            saya1.PrintVideoDetails() ;

        }
    }
}