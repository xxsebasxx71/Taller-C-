using System;

namespace ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double articulo,pagar=0,total=0;
			
			Console.WriteLine("digite el costo del articulo");
			articulo=double.Parse(Console.ReadLine());
			
			if(articulo>=200000){
				
				pagar=articulo*0.15;
				total=articulo-pagar;
			}else if(articulo>100000 && articulo<200000){
			
				pagar=articulo*0.12;
				total=articulo-pagar;
			
			}else if(articulo<100000){
				
				pagar=articulo*0.10;
				total=articulo-pagar;
					
			}
			Console.WriteLine("el total en pagar es: "+total);
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}