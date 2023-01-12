class Program
{
    static void Main(string[] args)
    {
        List<int> listEnteros = new List<int>();
        for(int i = 1; i <= 100;i++)
        {
            listEnteros.Add(i);
         
        }

        Linq(listEnteros);

        Console.WriteLine();

        Linq2(listEnteros);


    }

    public static void Linq(List<int> listEnteros)
    {

        var numeros = listEnteros.Where(a => a % 7 == 0 ) ;
        foreach(int num in numeros)
        {
            Console.WriteLine(num);
        }
    }

    public static void Linq2(List<int> listEnteros)
    {
        var numeros = from num in listEnteros
                      where num %7==0
                     select num;

        foreach(int num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}








