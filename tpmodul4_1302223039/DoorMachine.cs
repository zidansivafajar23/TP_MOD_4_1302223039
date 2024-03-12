using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302223039
{
    internal class DoorMachine
    {
        // Enum untuk merepresentasikan state pintu
        public enum DoorState
        {
            Terkunci,
            Terbuka
        }

        // Properti untuk menyimpan state pintu
        public DoorState State { get; private set; }

        // Constructor untuk menginisialisasi state awal menjadi Terkunci
        public DoorMachine()
        {
            State = DoorState.Terkunci;
           
        }

        // Method untuk mengubah state pintu menjadi Terbuka
        public void Buka()
        {
            State = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }

        // Method untuk mengubah state pintu menjadi Terkunci
        public void Kunci()
        {
            State = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
