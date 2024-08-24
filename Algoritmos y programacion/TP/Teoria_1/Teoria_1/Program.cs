/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 27/07/2024
 * Hora: 15:06
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
			{
				int a,b,c;
			}
			{
				int a; int b; int c,d;
			}
			{
				int a=1; int b=2; int c= 3;
			}
			{
				int b; int c; int a=b=c=1;
			}
			{	
				int c; int a, b = c = 1; 
			}
			{
				int c; int a=2, b = c = 1;
			}
			{
				int a=2, b, c, d = 2*a;
			}
			{
				// error int a; int c=a; 
			}
			{
				// error char c='A', string st="Hola";
			}
			{
				char c='A'; string st="Hola";
			}
			{
				//error char c='A', st="Hola"; 
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}