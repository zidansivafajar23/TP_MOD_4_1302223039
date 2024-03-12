using tpmodul4_1302223039;

internal class Program
{
    private static void Main(string[] args)
    {
        // Membuat instance dari class KodePos yang berada di namespace tpmodul4_1302223039
        tpmodul4_1302223039.KodePos kodePosObj = new tpmodul4_1302223039.KodePos();

        // Memanggil method dari class KodePos
        string kodePosBatununggal = kodePosObj.GetKodePos("Batununggal");
        Console.WriteLine("Kode Pos Batununggal: " + kodePosBatununggal);

        string kodePosKujangSari = kodePosObj.GetKodePos("Kujangsari");
        Console.WriteLine("Kode Pos Kujangsari: " + kodePosKujangSari);

        string kodePosKujangSamoja = kodePosObj.GetKodePos("Samoja");
        Console.WriteLine("Kode Pos Samoja: " + kodePosKujangSamoja);
        Console.WriteLine("\n ==========================");

        //===============================================================================//

        // Membuat instance dari class DoorMachine
        DoorMachine door = new DoorMachine();

        // Mensimulasikan perubahan state
        Console.WriteLine(" ");
        door.Buka(); // Membuka pintu yang terkunci
        door.Buka(); // Membuka pintu yang terbuka
        door.Kunci(); // Mengunci pintu yang terbuka
        door.Kunci(); // Mengunci pintu yang terkunci
    }
}