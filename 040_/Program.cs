//class Kisi
//{
//    private string _Adi;
//    public string Adi
//    {
//        set { _Adi = value; }
//        get { return _Adi; }
//    }
//}
//bu şekilde get set kullanılabiliyorsa oto property(Özellik) yapabiliyorum

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
}

class Program
{
    static void Main(string[] args)
    {
        Kisi kisi1 = new Kisi();
        kisi1.Adi = "Burak";
        kisi1.IkinciAdi = "Berat";
        kisi1.Soyadi = "Genç";

        
        Console.WriteLine(kisi1.TamAdi);
        
        Kisi kisi2 = new Kisi();
        kisi2.Adi = "Yavuz";
        kisi2.Soyadi = "Işık";

        Console.WriteLine(kisi2.TamAdi);

    }
}
