//////////////////10_Tekrar
class Dortgen
{
    private int _Kenar1;
    public int Kenar1
    {
        get { return _Kenar1; }
        set
        {
            if (value > 1)
                _Kenar1 = value;
            else
                _Kenar1 = 1; // Default değer : 1
        }
    }
    private int _Kenar2;
    public int Kenar2
    {
        get { return _Kenar2; }
        set
        {
            if (value < 1)
                _Kenar2 = 1; // Default değer : 1
            else
                _Kenar2 = value;
        }
    }
    //private bool _KareMi;
    //public bool KareMi
    //{
    //    get { return _KareMi; }
    //    set { _KareMi = value; }
    //}
    public bool KareMi
    {
        get
        {
            return (Kenar1 == Kenar2);
        }
    }

    public bool KareMi1
    {
        get
        {
            if (Kenar1 == Kenar2)
                return true;
            else
                return false;
        }
    }

    public int AlanHesapla()
    {
        return Kenar1 * Kenar2;
    }
    public int CevreHesapla()
    {
        return 2 * (Kenar1 + Kenar2);
    }
    public void Hakkinda()
    {
        Console.Write("K1 = " + Kenar1);
        Console.Write(", K2 = " + Kenar2);
        Console.Write(", Alan = " + AlanHesapla());
        Console.Write(", Cevre= " + CevreHesapla());
        Console.WriteLine();
        if (KareMi)
            Console.Write("bu bir Kare");
        else
            Console.Write("bu bir Kare değildir");
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dortgen dortgen = new Dortgen();
        dortgen.Kenar1 = 10;
        dortgen.Kenar2 = 10;

        dortgen.Hakkinda();
    }
}

