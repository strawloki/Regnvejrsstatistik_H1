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

            //Console.WriteLine(FindAvereage(new double[] {321, 43, 432, 76, 21}));

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
            else Console.WriteLine("Wrong value entered. Try again. Value must be above 0.");


            double[] values = new double[totalVal];

            for(int i = 0; i < totalVal; i++)
            {
                bool correctVal = false;
                while(!correctVal)
                {
                    Console.Write($"\nInsert value {i + 1}/{totalVal}: ");
                    string strVal = Console.ReadLine();
                    double val = 0;

                    if(double.TryParse(strVal, out val))
                    {
                        Console.WriteLine($"Added value {val} to the list.");
                        values[i] = val;
                        correctVal = true;
                    }
                    else Console.WriteLine("Incorrect value. Try again.");
                }
                
            }


        }

        static double FindLowest(double[] arr)
        {
            double lowest = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                
                if(i + 1 < arr.Length && lowest > arr[i + 1])
                    lowest = arr[i + 1];

            }

            return lowest;
        }

        
        static double FindHighest(double[] arr)
        {
            double highest = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                
                if(i + 1 < arr.Length && highest < arr[i + 1])
                    highest = arr[i + 1];

            }

            return highest;  
        }
        
        static double FindAvereage(double[] arr)
        {
            double avg = 0;

            foreach(double item in arr)
                avg += item;

            return avg / arr.Length;
        }
        

    }
}
