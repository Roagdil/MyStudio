/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 17/08/2024
 * Hora: 13:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Ejercicio_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			
			// TODO: Implement Functionality Here
			string [] vocales = new string[5]{"a","e","i","o","u"};
			byte [] cantidad = new byte[5];
			string palabra;
			
			Console.WriteLine("Ingrese una palabra");
			palabra= Console.ReadLine();
			cantidadVocales(ref cantidad,palabra.ToLower());
			Console.WriteLine("Contiene:");
			for (int i = 0; i < 5; i++) {
				Console.WriteLine(" {0} = {1}",vocales[i],cantidad[i]);
			}
			Console.ReadKey(true);
		}
		
		static void cantidadVocales(ref byte[] cant,string pal){
			for (int i = 0; i < pal.Length; i++) {
				switch (pal[i]) {
					case 'a' : cant[0]++; break;
					case 'e' : cant[1]++; break;
					case 'i' : cant[2]++; break;
					case 'o' : cant[3]++; break;
					case 'u' : cant[4]++; break;
				}
			}
		}
		
		
	}
}