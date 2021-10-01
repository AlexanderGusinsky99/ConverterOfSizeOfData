using System;

namespace ConverterOfSizeOfData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of file: ") ;
            double inputNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter type of file in format: bit, byte, Kb, Mb, Gb");
            string inputType = Console.ReadLine();
            double convertedToBit = 0;
            double convertedToByte = 0;
            double convertedToKb = 0;
            double convertedToMb = 0;
            double convertedToGb = 0;
            switch (inputType)
            {
                case "bit":
                    convertedToByte = inputNumber / 8;
                    convertedToKb = inputNumber / Math.Pow(2, 13);
                    convertedToMb = inputNumber / Math.Pow(2, 23);
                    convertedToGb = inputNumber / Math.Pow(2, 33);
                    Console.WriteLine(convertedToByte + " Byte");
                    Console.WriteLine(convertedToKb + " Kb");
                    Console.WriteLine(convertedToMb + " Mb");
                    Console.WriteLine(convertedToGb + " Gb");
                    break;
                case "byte":
                    convertedToBit = inputNumber * 8;
                    convertedToKb = inputNumber / Math.Pow(2, 10);
                    convertedToMb = inputNumber / Math.Pow(2, 20);
                    convertedToGb = inputNumber / Math.Pow(2, 30);
                    Console.WriteLine(convertedToByte + " Bit");
                    Console.WriteLine(convertedToKb + " Kb");
                    Console.WriteLine(convertedToMb + " Mb");
                    Console.WriteLine(convertedToGb + " Gb");
                    break;
                case "Kb":
                    convertedToBit = inputNumber / Math.Pow(2, 13);
                    convertedToByte = inputNumber / 8;
                    convertedToMb = inputNumber / Math.Pow(2, 23);
                    convertedToGb = inputNumber / Math.Pow(2, 33);
                    Console.WriteLine(convertedToByte + " Byte");
                    Console.WriteLine(convertedToKb + " Kb");
                    Console.WriteLine(convertedToMb + " Mb");
                    Console.WriteLine(convertedToGb + " Gb");
                    break;
                case "Mb":
                    convertedToBit = inputNumber / Math.Pow(2, 23);
                    convertedToByte = inputNumber / 8;
                    convertedToKb = inputNumber / Math.Pow(2, 13);
                    convertedToGb = inputNumber / Math.Pow(2, 33);
                    Console.WriteLine(convertedToByte + " Byte");
                    Console.WriteLine(convertedToKb + " Kb");
                    Console.WriteLine(convertedToMb + " Mb");
                    Console.WriteLine(convertedToGb + " Gb");
                    break;
                case "Gb":
                    convertedToBit = inputNumber / Math.Pow(2, 33);
                    convertedToByte = inputNumber / 8;
                    convertedToKb = inputNumber / Math.Pow(2, 13);
                    convertedToMb = inputNumber / Math.Pow(2, 23);
                    Console.WriteLine(convertedToByte + " Byte");
                    Console.WriteLine(convertedToKb + " Kb");
                    Console.WriteLine(convertedToMb + " Mb");
                    Console.WriteLine(convertedToGb + " Gb");
                    break;
            }
            Console.WriteLine(convertedToByte + " Byte");
            Console.WriteLine(convertedToKb + " Kb");
            Console.WriteLine(convertedToMb + " Mb");
            Console.WriteLine(convertedToGb + " Gb");
            Console.ReadLine();
        }
    }
}
