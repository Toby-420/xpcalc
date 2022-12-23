namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "xpcalc";
            Console.Write("wanderer\n");
            decimal w = Convert.ToDecimal(Console.ReadLine());
            Console.Write("adventurer\n");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("hero\n");
            decimal h = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(w * 1000 + a * 5000 + h * 20000 + "xp");
            Console.Read();
        }
    }
}