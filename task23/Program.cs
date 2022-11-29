class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи число и узри кубы этих чисел!:");
            int N = int.Parse(Console.ReadLine());
 
            Console.WriteLine("Числицо" + "\t" + "Кубец");
            for(int i = 1; i <= N; i++)
                Console.WriteLine(i + "\t" + i*i*i);
 
            Console.ReadLine();
  
        }
    }
