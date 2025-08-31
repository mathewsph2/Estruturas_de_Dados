class Program
{

    public static void Incomodar(int numero)
    {
        if (numero <= 0)
        {
            return;
        }
        Incomodar(numero - 1);
        Console.Write("incomodam ");
    }

    // Função recursiva em ordem crescente:
    public static void Elefantes(int num)
    {
        if (num <= 0)
        {
            return;
        }
        Elefantes(num - 1);


        if (num % 2 == 0)
        {
            Console.Write("{0} elefantes ", num);
            Incomodar(num);
            Console.WriteLine(" muito mais");
        }

        else
        {

            Console.Write($"{num} elefante ");
            // Incomodar(num);
            Console.WriteLine(" muita gente");
        }

    }

    // Função recursiva em  ordem decrescente:
    public static void Setnafele(int num)
    {
        if (num <= 0)
        {
            return;
        }


        if (num % 2 == 0)
        {

             Console.Write($"{num} elefante ");
            // Incomodar(num);
            Console.WriteLine(" muita gente");

        }
        else
        {
            Console.Write("{0} elefantes ", num);
            Incomodar(num);
            Console.WriteLine(" muito menos");
        }

        Setnafele(num - 1);
    }

    // Main
    public static void Main(String[] args)
    {
        Elefantes(10);

        Setnafele(10);
    }
}