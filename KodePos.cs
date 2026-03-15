using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul4_103082800002
{
    internal class KodePos
    {
            private static Dictionary<string, int> tabelKodePos = new Dictionary<string, int>
        {
            {"Batununggal", 40266},
            {"Kujangsari", 40287},
            {"Mengger", 40267},
            {"Wates", 40256},
            {"Cijaura", 40287},
            {"Jatisari", 40286},
            {"Margasari", 40286},
            {"Sekejati", 40286},
            {"Kebonwaru", 40272},
            {"Maleer", 40274},
            {"Samoja", 40273}
        };

            public static int getKodePos(string kelurahan)
            {
                
                if (tabelKodePos.ContainsKey(kelurahan))
                {
                    return tabelKodePos[kelurahan];
                }
                else
                {
                    Console.WriteLine($"Kelurahan '{kelurahan}' tidak ditemukan.");
                    return -1;
                }
            }
        }
    }


