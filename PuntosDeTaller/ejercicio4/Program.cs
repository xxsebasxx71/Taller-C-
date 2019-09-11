using System;

namespace ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre;
			double consumido,pagar;
			Console.WriteLine("digite su nombre");
			nombre=Console.ReadLine();
			
			Console.WriteLine("digite la cantidad consumida");
			consumido=double.Parse(Console.ReadLine());
			
			if(consumido<=199){
				Console.WriteLine("tiene que pagar: "+(pagar=consumido*1.20));
			}else if(consumido>=200 && consumido<=399){
				Console.WriteLine("tiene que pagar: "+(pagar=consumido*1.50));
			}else if(consumido>=400 && consumido<600){
				Console.WriteLine("tiene que pagar: "+(pagar=consumido*1.80));			
			}else if(consumido>600){
				Console.WriteLine("tiene que pagar: "+(pagar=consumido*2.00));
			}
				

			

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}