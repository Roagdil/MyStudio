/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 27/07/2024
 * Hora: 16:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese el numero de un mes!");
			
			int num =0;
			num= int.Parse(Console.ReadLine());
			switch (num) {
					
					case 1:
					Console.WriteLine("enero");
					break;
				case 2:
					Console.WriteLine("febrero");
					break;
				case 3:
					Console.WriteLine("marzo");
					break;
				case 4:	
					Console.WriteLine("abril");
					break;
				case 5:
					Console.WriteLine("Mayo");
					break;
				case 6:
					Console.WriteLine("Junio");
					break;
				case 7:
					Console.WriteLine("Julio");
					break;
				case 8:;
					Console.WriteLine("Agosto");
					break;
				case 9:
					Console.WriteLine("Septiembre");
					break;
				case 10:
					Console.WriteLine("Octubre");
					break;
				case 11:
					Console.WriteLine("Noviembre");
					break;
				case 12:
					Console.WriteLine("Dicciembre");
					break;
				default:
					Console.WriteLine("Ingrese un numero valido");
					break;
						
				
			}	
						
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}