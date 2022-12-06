using System;

namespace Regnvejrsstatistik
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalVal = ReturnTotalValues();

            double[] values = InsertValues(totalVal);

            PrintValues(values);
        }

        static double[] InsertValues(int totalVal)
        {
            double[] vals = new double[totalVal];

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
                        vals[i] = val;
                        correctVal = true;
                    }
                    else Console.WriteLine("Incorrect value. Try again.");
                }
                
            }

            return vals;

        }

        static int ReturnTotalValues()
        {
            bool totalInputted = false;
            int totalVal = 0;

            while(!totalInputted)
            {
                Console.WriteLine("Enter the total amount of values below: ");
                string totalValStr = Console.ReadLine();
                

                if(int.TryParse(totalValStr, out totalVal))
                {
                    if(totalVal > 0) 
                    {
                        totalInputted = true;
                        Console.WriteLine("Great success!");
                    }

                }
                else Console.WriteLine("Wrong value entered. Try again. Value must be above 0.");
            }

            return totalVal;
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

        static void PrintValues(double[] arr)
        {

            Console.Write("Value Number\t|\tValue\n\n");
            int counter = 0;
            foreach(double val in arr)
            {
                ++counter;
                Console.WriteLine($"\tValue #{counter}\t \t{val}");
            }

            Console.Write("\n--------------------------------------------------------------------------------------------------\n");
            Console.WriteLine($"AVEREAGE VALUE: {FindAvereage(arr)}");
            Console.WriteLine($"HIGHEST VALUE: {FindHighest(arr)}");
            Console.WriteLine($"LOWEST VALUE: {FindLowest(arr)}");
            Console.Write("\n--------------------------------------------------------------------------------------------------\n");
        }
    }
}
