using System;

namespace Regnvejrsstatistik
{
    class Program
    {
        static void Main(string[] args)
        {
            //user inputs amount of values first
            //then user inputs the values themselves

            //afterwards, the lowest, highest and avereage of those values must be found
            bool totalInputted = false;

            Console.WriteLine("Enter the total amount of values below: ");
            string totalValStr = Console.ReadLine();
            int totalVal = 0;

            if(int.TryParse(totalValStr, out totalVal))
            {
                if(totalVal > 0) 
                {
                    totalInputted = true;
                    Console.WriteLine("Great success!");
                }

            }
            else Console.WriteLine();

            double[] values = new double[totalVal];
        }
    }
}
