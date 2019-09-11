using System;

namespace ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num,num1,num2;
			Console.WriteLine("digite un numero");
			num1=int.Parse(Console.ReadLine());
			Console.WriteLine("digite su segundo numero");
			num2=int.Parse(Console.ReadLine());
			
			Console.WriteLine("las opciones son");
			Console.WriteLine("1 - Adiccion");
			Console.WriteLine("2 - Sustraccion");
			Console.WriteLine("3 - Multiplicacion");
			Console.WriteLine("4 - Divison");
			
			num=int.Parse(Console.ReadLine());
			if(num==1){
				Console.WriteLine("se suma: "+(num1+num2));
			}else if(num==2){
				Console.WriteLine("se resta: "+(num1-num2));
			}else if(num==3){
				Console.WriteLine("se multiplica: "+(num1*num2));
			}else if(num==4){
				Console.WriteLine("se divide: "+(num1/num2));
			}
			
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}