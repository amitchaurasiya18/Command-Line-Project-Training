using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int argumentsCount, argumentsMinimum = int.Parse(args[0]), argumentsMaximum = int.Parse(args[0]), argumentsSum = 0;
            float argumentsAverage;
            argumentsCount = args.Length;

            Console.WriteLine("Number of Arguments is : " + argumentsCount);

            for (int i = 0; i < argumentsCount; i++)
            {
                argumentsSum = argumentsSum + int.Parse(args[i]);

                if (int.Parse(args[i]) > argumentsMaximum)
                {
                    argumentsMaximum = int.Parse(args[i]);
                }

                if (int.Parse(args[i]) < argumentsMinimum)
                {
                    argumentsMinimum = int.Parse(args[i]);
                }
            }

            Console.WriteLine("Sum of Arguments is : " + argumentsSum);

            argumentsAverage = argumentsSum / argumentsCount;

            Console.WriteLine("Average of Arguments is : " + argumentsAverage);

            Console.WriteLine("Minimum of Arguments is : " + argumentsMinimum);

            Console.WriteLine("Maximum of Arguments is : " + argumentsMaximum);
        }
    }
}
