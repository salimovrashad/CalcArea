namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("eded daxil et: ");
			int num = Convert.ToInt32(Console.ReadLine());
            Figure square = new Square(num);
            Console.WriteLine(square.CalcArea());
        }
	}
}