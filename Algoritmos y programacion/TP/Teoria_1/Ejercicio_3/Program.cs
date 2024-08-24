/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 27/07/2024
 * Hora: 16:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			double numero=0;
			Console.WriteLine("Ingrese un numero a sumar");
			numero = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingrese un numero mas");
			numero += double.Parse(Console.ReadLine());
			// TODO: Implement Functionality Here
			
			
			Console.Write(numero);
			Console.ReadKey(true);
		}
	}
}