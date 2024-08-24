/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 27/07/2024
 * Hora: 23:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int [] lista = new int[]{40,352};
			
			for (int x= lista[0]; x <= lista[1]; x++){
				if((x % 2 ==1)&& (x % 3 == 0))
				{
					Console.WriteLine(x);
				}
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}