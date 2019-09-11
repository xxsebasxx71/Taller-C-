using System;

namespace ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1,num2,num3;
			
			Console.WriteLine("digite 3 numeros");
			num1=int.Parse(Console.ReadLine());
		    num2=int.Parse(Console.ReadLine());
			num3=int.Parse(Console.ReadLine());
			
			if (num1>num2 && num1>num3){
				
				Console.WriteLine("el mayor es: "+num1);
			
			}else if(num2>num1 && num2>num3){
				
				Console.Write("el mayor es: "+num2);
			
			}else{
             
			Console.WriteLine("el mayor es: "+num3 );
			}
		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}