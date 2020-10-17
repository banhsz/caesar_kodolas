using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string szoveg = "Abcdef. GH-IJ! klmno 123456789!?! ";
            string eltolt_szoveg ="";
            int eltolas = 26;

            //bejárja a szoveg változót karaktenként
            for (int i = 0; i < szoveg.Length; i++)
            {
                char seged = char.ToUpper(szoveg[i]);

                //ha el kell tolni a karaktert
                if (abc.Contains(seged))
                {
                    //karakter indexének keresése abc-ben
                    int index = abc.IndexOf(seged);
                    //karakter eltolása ; % = maradékos osztás, azért kell mert pld 8 at eltolod 5-el akkor D-lesz
                    index = (index + eltolas) % abc.Length;

                    //ha nagybetűs a karakter
                    if (szoveg[i] == char.ToUpper(szoveg[i]))
                    {
                        eltolt_szoveg += abc[index];
                    }
                    //ha kisbetűs
                    else
                    {
                        eltolt_szoveg += char.ToLower(abc[index]);
                    }
                }
                //ha nem kell eltolni. szőköz, irásjel stb.
                else
                {
                    eltolt_szoveg += szoveg[i];
                }
            }

            Console.WriteLine(eltolt_szoveg);
            Console.ReadKey();
        }
    }
}
