using System;
using tpmodul4_103082800002;

namespace tpmodul3_NIM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO TABLE-DRIVEN (KODE POS) ===\n");

            string[] kelurahanSample = { "Batununggal", "Jatisari", "Maleer", "Cijaura", "Pasteur" };

            foreach (string kel in kelurahanSample)
            {
                int kodePos = KodePos.getKodePos(kel);
                if (kodePos != -1)
                {
                    Console.WriteLine($"Kode pos untuk {kel} adalah {kodePos}");
                }
            }

            Console.WriteLine("\nTekan sembarang tombol untuk lanjut...");
            Console.ReadKey();
        }
    }
}