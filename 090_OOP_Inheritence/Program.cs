
class Hayvan
{
    public string Tur { get; set; }
    public string Ses { get; set; }
    public Hayvan()
    {
        Console.WriteLine("Hayvan Oluşturuldu");
    }

    public virtual void Bagir()
    {
        Console.WriteLine("[" + Tur + "]" + Ses + " " + Ses);
    }

}
class Kedi : Hayvan
{
    public Kedi()
    {
        Console.WriteLine("Kedi Oluşturuldu");
        Tur = "Kedi";
        Ses = "miyav";
    }

}

class Kopek : Hayvan
{
    public Kopek()
    {
        Console.WriteLine("Kopek Oluşturuldu");
        Tur = "Köpek";
        Ses = "hav";
    }
    public override void Bagir()
    {
        Console.WriteLine("["+Tur+"]" + Ses.ToUpper() + " " + Ses.ToUpper() );
    }
}


class Program
{
    static void Main(string[] args)
    {
        Hayvan hayvan = new Hayvan();
        Console.WriteLine();
        Kedi kedi = new Kedi();
        Console.WriteLine();
        Kopek kopek = new Kopek();
        Console.WriteLine();
        Console.WriteLine("-------------");
        kedi.Bagir();
        kopek.Bagir();
    }
}
