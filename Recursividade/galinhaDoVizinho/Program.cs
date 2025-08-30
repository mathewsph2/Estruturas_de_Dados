using System.Globalization;

class Program
{

    public static void imprimeLetra(int num)
    {
        int ovo1 = 0;
        int ovo2 = 1;
        int ovo3 = 2;
        int ovo4 = 3;
        int ovo5 = 4;

        if (ovo1 >= num)
        {
            return;
        }

        imprimeLetra(num - 5);
        Console.WriteLine("A galinha do vizinho bota ovo amarelinho");
        Console.WriteLine("Bota {0}, bota {1}", ovo1 = ovo1 + num, ovo2 = ovo2 + num);

        Console.WriteLine("A galinha do vizinho bota ovo amarelinho");
        Console.WriteLine("Bota {0}, bota {1}", ovo3 = ovo3 + num, ovo4 = ovo4 + num);

        Console.WriteLine("A galinha do vizinho bota ovo amarelinho");
        Console.WriteLine("Bota {0}, bota mil!", ovo5 = ovo5 + num);
    }

    public static void Main(string[] args)
    {
        imprimeLetra(96);
    }
}