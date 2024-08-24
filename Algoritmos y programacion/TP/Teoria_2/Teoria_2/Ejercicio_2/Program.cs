/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 28/07/2024
 * Hora: 15:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int sum=0; int i=1;
			while (i<=10) // el error es el punto y coma
			{
				 sum += i++;
				
			}
			Console.WriteLine(sum);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}