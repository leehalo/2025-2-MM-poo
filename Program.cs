
class Program
{
    static void Main()
    {
        Televisao tv = new Televisao(42.0f);
        
        tv.Ligar(); // Liga no canal 1
        Console.WriteLine($"Volume inicial: {tv.Volume}");
        
        tv.TrocarCanal(500);      // Trocar canal
        
        tv.CanalAcima();          // volta para 1
        
        tv.CanalAbaixo();         // volta para 520 
        
        tv.AtivarMudo();
        
        tv.AumentarVolume();      // não funciona, TV no mudo

        Console.WriteLine($"Volume após aumentar: {tv.Volume}");

        tv.DiminuirVolume();
        Console.WriteLine($"Volume após diminuir: {tv.Volume}");

        tv.DefinirVolume(80);


        Console.WriteLine($"Volume definido para: {tv.Volume}");

        tv.AtivarMudo();

        tv.AumentarVolume(); // não vai funcionar
        tv.DesativarMudo();

        tv.Desligar();
    }
}
