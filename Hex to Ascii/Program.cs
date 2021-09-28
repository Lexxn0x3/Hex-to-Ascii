using System;

namespace Hex_to_Ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(ConvertHex(str));
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static string ConvertHex(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }
    }
}
