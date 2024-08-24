/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 28/07/2024
 * Hora: 15:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			// int i=0; Int ya definido en el for
			for(int i=1; i<=10;) {
				Console.WriteLine(i++); // primero imprime y luego suma un valor mas a I
			}
			Console.ReadKey();
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}