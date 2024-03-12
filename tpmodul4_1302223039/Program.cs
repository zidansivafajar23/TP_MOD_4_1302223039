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
    }
}