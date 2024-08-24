/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 28/07/2024
 * Hora: 15:29
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
			
			Console.WriteLine("Ingresa una palabra y te dire si es palindromo o no");
			string palabra = Console.ReadLine();
			string palindromo="";
			Console.WriteLine("Hello World!");
			for (int i =palabra.Length -1 ; i>= 0; i--){
				palindromo+= palabra[i];
			}
			Console.WriteLine(palabra==palindromo ? "Es palindromo" : "No es palindromo" );
			
			Console.Write(palindromo);
			Console.ReadKey(true);
		}
	}
}