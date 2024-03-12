using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302223039
{
    internal class KodePos
    {
        private string[,] kodePosData = {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };

        // Method untuk mendapatkan kode pos berdasarkan nama kelurahan
        public string GetKodePos(string kelurahan)
        {
            for (int i = 0; i < kodePosData.GetLength(0); i++)
            {
                if (kodePosData[i, 0] == kelurahan)
                {
                    return kodePosData[i, 1];
                }
            }
            return "Kode Pos Tidak Ditemukan";
        }
    }
}
