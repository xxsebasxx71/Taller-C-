using System;

namespace ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			char letra;
			
			Console.WriteLine("digite una letra");
			letra=char.Parse(Console.ReadLine());
			
			
			if(letra=='a'){
				Console.WriteLine("la letra que digito es vocal" );
			}else if(letra=='e'){
				Console.WriteLine("la letra que digito es vocal" );
			}else if(letra=='i'){
				Console.WriteLine("la letra que digito es vocal" );
			}else if(letra=='o'){
				Console.WriteLine("la letra que digito es vocal" );
			}else if(letra=='u'){
				Console.WriteLine("la letra que digito es vocal" );
			}else{
				Console.WriteLine("la letra que digito es consonante ");
			}
			


			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}