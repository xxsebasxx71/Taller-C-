using System;

namespace ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n;
			float Fn;
			Console.WriteLine("digite n");
			n=int.Parse(Console.ReadLine());
			
			Fn=1/(Math.Sqrt(5))[(Math.Pow(((1+Math.Sqrt(5))/2),n))-(Math.Pow(((1-Math.Sqrt(5))/2),n))];
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}