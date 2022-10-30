namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "xpcalc";
            Console.Write("wanderer\n");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("adventurer\n");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("hero\n");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(w * 1000 + a * 5000 + h * 20000 + "xp");
            Console.Read();
        }
    }
}