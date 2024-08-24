/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 27/07/2024
 * Hora: 18:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int secuencia= 10;
			double valMin, resultado,valMax,resp;
			valMin=0;
			valMax=0;
			resultado=0;
			Console.WriteLine("Ingresa una serie de numeros y te dare el promedio");
			for (int i= 0; i< secuencia; i++){
				resp=double.Parse(Console.ReadLine());
				valMax= (valMax <= resp) ? resp : valMax;
				valMin= (valMin >= resp) || i==0 ? resp : valMin;
				resultado+= resp;
				Console.WriteLine(resultado);
			}
			resultado= resultado/secuencia;
			
			Console.WriteLine("Valor max: {0}, valor minimo:  {1}, promedio: {2}",valMax,valMin,resultado);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey();
		}
	}
}