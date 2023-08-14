class Kisi
{
    public string Adi { get; set; } = "";
    public string IkinciAdi { get; set; } = "";
    public string Soyadi { get; set; } = "";

    public string TamAdi
    {
        get
        {
            string sonuc = "";
            sonuc += Adi;
            if (IkinciAdi != "")
                sonuc += " " + IkinciAdi;
            sonuc += " " + Soyadi.ToUpper();
            return sonuc;
        }

    }

    public Kisi(string adi,string ikinciAdi,string soyadi)
    {
        Adi = adi;
        IkinciAdi = ikinciAdi;
        Soyadi = soyadi;

    }

    public Kisi(string adi, string soyadi)
    {
        Adi = adi;
        Soyadi = soyadi;

    }
    public Kisi(string soyadi)
    {
        
        Soyadi = soyadi;

    }
}

class Program
{
    static void Main(string[] args)
    {
        Kisi kisi1 = new Kisi("Burak","Berat","Genç");
        Kisi kisi2 = new Kisi ("Yavuz","Işık");
        Kisi kisi3 = new Kisi ("DOBLAN");
        

        Console.WriteLine(kisi1.TamAdi);
        Console.WriteLine(kisi2.TamAdi);
        Console.WriteLine(kisi3.TamAdi);
    }
}

//constructor ı overload ettik.