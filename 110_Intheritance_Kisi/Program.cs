class Kisi
{
    public string Adi { get; set; }
    public string IkinciAdi { get; set; }
    public string Soyadi { get; set; }
    public string TamAdi
    {
        get
        {
            return Adi + " " + IkinciAdi+ " " + Soyadi.ToUpper();
        }

    }
    public virtual string Unvan
    {
        get { return TamAdi; }
    }
}

class Doktor : Kisi
{
    public string Kidem { get; set; }
    public override string Unvan
    {
        get { return Kidem + ". " + base.Unvan; }
    }


}

class Program
{
    static void Main(string[] args)
    {
        Kisi kisi = new Kisi { Adi = "Berat", Soyadi = "Genç" };
        Console.WriteLine(kisi.TamAdi);
        Console.WriteLine(kisi.Unvan);

        Console.WriteLine("---------------------------");

        Doktor doktor = new Doktor { Adi = "Özge", IkinciAdi="Yeşim", Soyadi = "Doblan", Kidem = "Doc" };
        Console.WriteLine(doktor.Unvan);
    }
}
