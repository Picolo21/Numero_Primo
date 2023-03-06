internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe um valor qualquer: ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (value == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"Não é possível informar se {value} é primo ou não");
        }
        else
        {
            int count = 0;
            for (int i = value; i >= 1; i--)
            {
                if (value % i == 0)
                {
                    int div = (value / i);
                    Console.WriteLine($"{value} é divisível por {i}");
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{value} é divisível {count} vezes");
            Console.WriteLine();

            if (count != 2)
            {
                Console.WriteLine($"O número {value} não é primo");
            }
            else
            {
                Console.WriteLine($"O número {value} é primo");
            }
        }
        
    }
}