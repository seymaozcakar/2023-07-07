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
  
    public bool KareMi
    {
        get
        {
            return (Kenar1 == Kenar2);
        }
    }

    public Dortgen(int Kenar1, int Kenar2) //doğrusu kenar1,kenar2
    {
        this.Kenar1 = Kenar1;
        this.Kenar2 = Kenar2; //this ile düzeltme
    }

    public Dortgen(int kenar):this(kenar,kenar) //hata vermeden tek değer girebilmesi için
    {
        
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
        Dortgen dortgen1 = new Dortgen(5,10);
        Dortgen dortgen2 = new Dortgen(5);
      

        dortgen1.Hakkinda();
        dortgen2.Hakkinda();
    }
}