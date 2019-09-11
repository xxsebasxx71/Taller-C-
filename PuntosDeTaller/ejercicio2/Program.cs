using System;

namespace ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
			double b,h,a=0,r;
			
			Console.WriteLine("digite 1 para el  area del circulo");
			Console.WriteLine("digite 2 para el  area del rectangulo");
			Console.WriteLine("digite 3 para el  area del triangulo");
			
			Console.WriteLine("digite su opcion");
			num=int.Parse(Console.ReadLine());
			
			if(num==1){
				Console.WriteLine("digite radio del circulo");
				r=double.Parse(Console.ReadLine());
				
				a=Math.PI*Math.Pow(r,2);
			
			}else if(num==2){
			Console.WriteLine("digite base rectangulo");
			b=double.Parse(Console.ReadLine());
			Console.WriteLine("digite altura rectangulo");
			h=double.Parse(Console.ReadLine());
			
			a=b*h;
			
			}else if(num==3){
			Console.WriteLine("digite base triangulo");
			b=double.Parse(Console.ReadLine());
			Console.WriteLine("digite altura triangulo");
			h=double.Parse(Console.ReadLine());
			
			a=(b*h)/2;
			}
	
			Console.WriteLine("su area es: "+a);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}