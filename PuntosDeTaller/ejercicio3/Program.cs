using System;

namespace ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int mes;
			
			Console.WriteLine("digite el mes");
			mes=int.Parse(Console.ReadLine());
			
			 if(mes==1){
            Console.WriteLine("digito el mes 1 enero tiene 31 dias");
        }else if(mes==2){
            Console.WriteLine("digito el mes 2 febrero tiene 28 dias");
        }else if(mes==3){
            Console.WriteLine("digito el mes 3 marzo tiene 31 dias");
        }else if(mes==4){
            Console.WriteLine("digito el mes 4 abril tiene 30 dias");
        }else if(mes==5){
            Console.WriteLine("digito el mes 5 mayo tiene 31 dias");
        }else if(mes==6){
            Console.WriteLine("digito el mes 6 junio tiene 30 dias");
        }else if(mes==7){
            Console.WriteLine("digito el mes 7 julio tiene 31 dias");
        }else if(mes==8){
            Console.WriteLine("digito el mes 8 agosto tiene 31 dias");
        }else if(mes==9){
            Console.WriteLine("digito el mes 9 septiembre tiene 30 dias");
        }else if(mes==10){
            Console.WriteLine("digito el mes 10 octubre tiene 31 dias");
        }else if(mes==11){
            Console.WriteLine("digito el mes 11 noviembre tiene 30 dias");
        }else if(mes==12){
            Console.WriteLine("digito el mes 12 diciembre tiene 31 dias");
        }

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}