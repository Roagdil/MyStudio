/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 23/08/2024
 * Hora: 18:30
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
			string [] nombres = new string[] {"rodrigo","oto", "ana", "ala"};
			
			foreach (string element in nombres) {
				if (Palindromo(element)){
					
					Console.Write(element);
				}
			}
			Console.WriteLine();
			Console.ReadKey();
			
		}
		
		public static bool Palindromo(string palabra){
			palabra = palabra.ToLower();
			string copia = palabra;
			int longitud= palabra.Length - 1;
			for (int i = 0; i < palabra.Length; i++) {
				if (copia[longitud-i]!= palabra[i]){
					return false;
				}
			}
			return true;
		}
	}
}