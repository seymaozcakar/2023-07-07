///bool
class Program
{
    static bool CiftMi(int sayi)
    {
        return (sayi % 2 == 0);
    }

    static bool CiftMi2(int sayi)
    {
        if (sayi % 2 == 0)
            return true;
        else
            return false;
    }

    static bool CiftMi1(int sayi)
    {
        bool sonuc = true;
        if (sayi % 2 == 0)
        {
            sonuc = true;
        }
        else
        {
            sonuc = false;
        }
        return sonuc;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(CiftMi(10));
        Console.WriteLine(CiftMi(5));
        Console.WriteLine("-------------");
        Console.WriteLine(10 % 2 == 0);
    }
}
