class Hayvan
{
    public string Tur { get; set; }
    public string Ses { get; set; }
    

    public virtual void Bagir()
    {
        Console.WriteLine("[" + Tur + "]" + Ses + " " + Ses);
    }

    public Hayvan(string tur,string ses)
    {
        Console.WriteLine("Hayvan Oluşturuldu");
        Tur = tur;
        Ses = ses;
    }
}

class Kedi : Hayvan
{
    public Kedi():base("kedi","miyav")  //base class taki contructor ı çağırıyoruz. (baz alınan class ı çağırıyoruz)
    {
        Console.WriteLine("Kedi Oluşturuldu");
    }

}


class Program
    {
        static void Main(string[] args)
        {
            //Hayvan hayvan = new Hayvan("Kedi","Hav");
            //hayvan.Bagir();

            Kedi kedi = new Kedi();
            kedi.Bagir();
        }
    }
