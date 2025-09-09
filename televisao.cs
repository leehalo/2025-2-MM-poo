
public class Televisao
{
    private const int VOL_MIN = 0;
    private const int VOL_MAX = 100;
    private const int CANAL_MAX = 520;
    private const int CANAL_MIN = 1;

    private int ultimoCanal; // guarda o último canal assistido

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Volume = 100;  // volume inicial
        mudo = false;
        Canal = 520;
        Estado = false; // TV desligada
        Canal = 1;        // canal inicial
        ultimoCanal = Canal;
    }

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public bool Estado { get; set; }
    public int Canal { get; private set; }

    private bool mudo { get; set; }
    public int Volume { get; private set; }

    

    // Aumenta o volume
    public void AumentarVolume()
    {
        if (!mudo)
        {
            if (Volume < VOL_MAX)
                Volume++;
            else
                Console.WriteLine("Volume já está no máximo.");
        }
        else
        {
            Console.WriteLine("TV está no mudo.");
        }
    }

    // Diminui o volume
    public void DiminuirVolume()
    {
        if (!mudo)
        {
            if (Volume > VOL_MIN)
                Volume--;
            else
                Console.WriteLine("Volume já está no mínimo.");
        }
        else
        {
            Console.WriteLine("TV está no mudo.");
        }
    }

    // Define volume específico
    public void DefinirVolume(int novoVolume)
    {
        if (!mudo)
        {
            if (novoVolume < VOL_MIN)
                Volume = VOL_MIN;
            else if (novoVolume > VOL_MAX)
                Volume = VOL_MAX;
            else
                Volume = novoVolume;
        }
        else
        {
            Console.WriteLine("TV está no mudo. Não é possível alterar o volume.");
        }
    }

    // Liga ou desliga a TV
    public void Ligar()
    {
        Estado = true;
        ultimoCanal = Canal; 
        Console.WriteLine("TV ligada.");
    }

    public void Desligar()
    {
        Estado = false;
        ultimoCanal = Canal; // salva último canal
        Console.WriteLine("TV desligada.");
    }
     // Troca de canal
    public void TrocarCanal(int novoCanal)
    {
        if (novoCanal < CANAL_MIN || novoCanal > CANAL_MAX)
        {
            Console.WriteLine($"Canal inválido! Escolha entre {CANAL_MIN} e {CANAL_MAX}.");
            return;
        }
        Canal = novoCanal;
        ultimoCanal = Canal;
        Console.WriteLine($"Canal alterado para: {Canal}");
    }

    public void CanalAcima()
    {
        if (Canal < CANAL_MAX)
            TrocarCanal(Canal + 1);
        else
            Console.WriteLine("Você já está no canal máximo.");
    }

    public void CanalAbaixo()
    {
        if (Canal > CANAL_MIN)
            TrocarCanal(Canal - 1);
        else
            Console.WriteLine("Você já está no canal mínimo.");
    }

    // Ativa ou desativa o mudo
    public void AtivarMudo()
    {
        mudo = true;
        Console.WriteLine("Mudo ativado.");
    }

    public void DesativarMudo()
    {
        mudo = false;
        Console.WriteLine("Mudo desativado.");
    }
}
