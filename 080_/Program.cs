class Kisi
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }

    public virtual void Hakkinda() //virtual yazdığımda---eğer istersem değiştirebilirim.
    {
        Console.WriteLine("[KISI] Ben, "+Adi+" "+Soyadi.ToUpper());
    }

}

class Ogrenci : Kisi
{
    public string Okulu { get; set; }
    public override void Hakkinda()
    {
        Console.WriteLine("[OGR] Ben"+Adi+" "+Soyadi+" - "+Okulu);
    }
}
//override(ezmek,üzerine yazmak) edebilmek için virtual kullanılması şart.

//kişi öğrencinin base class ıdır.
//kişi öğrencinin child ıdır.
//kişi öğrenciden türetilmiştir.

class Calisan : Kisi
{
    public string Sirket { get; set; }
    public override void Hakkinda()
    {
        Console.WriteLine("[CLSN] Ben, "+Adi+" "+Soyadi+" -> "+Sirket+" şirketinde çalışıyorum");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kisi kisi = new Kisi()
        {
            Adi = "Yavuz",
            Soyadi = "Işık"
        };
       kisi.Hakkinda();

        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Adi = "Arda";
        ogrenci.Soyadi = "Büyükdoluca";
        ogrenci.Okulu = "Istanbul Un.";
        ogrenci.Hakkinda();

        Calisan calisan = new Calisan
        {
            Adi="Lizge",
            Soyadi="Diri",
            Sirket = "Apple"

        };

        kisi.Hakkinda();
        ogrenci.Hakkinda();
        calisan.Hakkinda();
    }
}
