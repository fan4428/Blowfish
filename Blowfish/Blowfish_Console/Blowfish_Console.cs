using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlowfishLib;

namespace Blowfish_Console
{
    class Blowfish_Console
    {
        static void Main(string[] args)
        {
            int exit = 1;
            string value;
            string key = "{123ABC9F-AFBC-36DC-8FF8-00BDAFF1584DGFQQ}";
            string encrypted;
            string decipher;
            do
            {
                Console.Clear();
                Console.WriteLine("Input value:    ");
                value = Convert.ToString(Console.ReadLine());
                Blowfish blowfish = new Blowfish(key);
                encrypted = blowfish.Encipher(value);
                Console.WriteLine("Encrypted value:     " + encrypted);
                decipher = blowfish.Decipher(encrypted);
                Console.WriteLine("Decipher value:     " + decipher);
                Console.WriteLine("Input 0 to exit:    ");
                exit = Convert.ToInt32(Console.ReadLine());
            }
            while (exit != 0);
        }
    }
}
