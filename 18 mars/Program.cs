using System;
using static System.Console;

namespace Variables18mars
{
    class Program
    {
        static void Main(string[] args)
        {
            Array[] strings = initialize();

            printMenu(strings);
            ReadLine();
        }

        static Array[] initialize(){
            return new Array[] {
                new string[] { "sbyte", $"{sizeof(sbyte)}", $"{sbyte.MinValue}", $"{sbyte.MaxValue}" },
                new string[] { "byte", $"{sizeof(byte)}", $"{byte.MinValue}", $"{byte.MaxValue}" },
                new string[] { "short", $"{sizeof(short)}", $"{short.MinValue}", $"{short.MaxValue}" },
                new string[] { "ushort", $"{sizeof(ushort)}", $"{ushort.MinValue}", $"{ushort.MaxValue}" },
                new string[] { "int", $"{sizeof(int)}", $"{int.MinValue}", $"{int.MaxValue}" },
                new string[] { "uInt", $"{sizeof(uint)}", $"{uint.MinValue}", $"{uint.MaxValue}" },
                new string[] { "long", $"{sizeof(long)}", $"{long.MinValue}", $"{long.MaxValue}" },
                new string[] { "ulong", $"{sizeof(ulong)}", $"{ulong.MinValue}", $"{ulong.MaxValue}" },
                new string[] { "float", $"{sizeof(float)}", $"{float.MinValue}", $"{float.MaxValue}" },
                new string[] { "double", $"{sizeof(double)}", $"{double.MinValue}", $"{double.MaxValue}" },
                new string[] { "decimal", $"{sizeof(decimal)}", $"{decimal.MinValue}", $"{decimal.MaxValue}" }
            };
        }

        static void printMenu(Array[] arrayOfStrings)
        {
            string[] titles = { "Type", "Byte(s) of memory", "Min", "Max" };
            WriteLine("{0,-8} {1,-12} {2,17} {3,32}", titles);
            printDashLine();

            foreach (string[] info in arrayOfStrings)
                WriteLine("{0,-8} {1,-2} {2,32} {3,32}", info);

            printDashLine();
        }

        static void printDashLine(){
            for (int i = 0; i < 77; i++) Write("-");
            WriteLine("");
        }
    }
}
