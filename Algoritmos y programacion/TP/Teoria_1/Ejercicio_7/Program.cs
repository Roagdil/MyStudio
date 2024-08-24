/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 27/07/2024
 * Hora: 23:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			double i=0;
			double x=0;
			Console.WriteLine("escribe numeros para que se sumen hasta ingresar cero");
			do{
				x=double.Parse(Console.ReadLine());
				i+= x;
				Console.Write("El resultado es {0}",i);
				Console.WriteLine();
				
			}while (x!=0);
			
			Console.ReadKey(true);
		}
	}
}