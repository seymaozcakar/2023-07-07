class Kare
{
    private int _Kenar;
    public int Kenar
    {
        get { return _Kenar; }
        set
        {
            if (value > 1)
                _Kenar = value;
            else
                _Kenar = 1; // Default değer : 1
        }
    }

    public int AlanHesapla()
    {
        return Kenar * Kenar;
    }
    public void Hakkinda()
    {
        Console.WriteLine("Kenar = " + Kenar + ", Alan = " + AlanHesapla());
    }

    public Kare(int kenar)
    {
        Console.WriteLine("Kare yaratıldı");
        Kenar = kenar;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kare kare = new Kare(-5);
        kare.Hakkinda();

        Console.WriteLine("------------------");
        kare.Kenar = 5;
        kare.Hakkinda();

        Console.WriteLine("------------------");
        kare.Kenar = -5;

        kare.Hakkinda();
    }
}
 //sınıfla aynı ismi taşır geri döndürmez public olmak zorunda değildir