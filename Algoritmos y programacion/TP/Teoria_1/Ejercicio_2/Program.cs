/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 27/07/2024
 * Hora: 15:07
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
			string name,lastName;
			int edad;
			long dni;
			dynamic cambiar;
			
			Console.WriteLine("Ingrese su nombre");
			
			name = Console.ReadLine();
			
			Console.WriteLine("Ingrese su apellido");
			
			lastName = Console.ReadLine();
			
			Console.WriteLine("Ingrese su edad");
			
			edad = int.Parse( Console.ReadLine());
			
			Console.WriteLine("Ingrese su DNI");
			
			dni =long.Parse( Console.ReadLine());
			
			
			Console.WriteLine("{0} {1} ({2}), DNI: {3}",name,lastName,edad,dni);
			Console.ReadKey(true);
		}
	}
}