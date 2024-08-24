/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 24/08/2024
 * Hora: 12:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre, apellido, respuesta;
			long dni;
			ArrayList listaEscuela= new ArrayList();
			ArrayList alumno = new	ArrayList();
			ArrayList listaAlumno = new ArrayList();
			
			
			do{
				menu();
				respuesta = Console.ReadLine();
				switch (respuesta) {
					case "a": break;
					case "b": break;
					case "c": break;
					case "d": break;
					case "e": break;
					case "" : Console.WriteLine("Adios"); break;
					default:
						Console.Clear();
						Console.WriteLine("Respuesta incorrecta");
						break;
				}
				
			}while (respuesta != "");
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void menu(string respuesta=""){
			// Imprimiremos un menu y aqui modificaremos la condicion dada
			
			Console.WriteLine("Ingrese una de estas opciones sino presione enter para salir.");
			Console.WriteLine("a: Inscribir un alumno");
			Console.WriteLine("b: Borrar Alumno (DNI)");
			Console.WriteLine("c: Alumnos inscriptos");
			Console.WriteLine("d: Escuelas con Alumnos inscriptos");
			Console.WriteLine("e: Lista de Escuelas");
			
			
			
		}
	}
}