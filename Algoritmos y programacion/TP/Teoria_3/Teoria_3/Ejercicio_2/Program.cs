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
					case "a": // inscribir un alumno
						nuevoAlumno(ref alumno);
						listaAlumno.Add(alumno);
						
						break;
					case "b":
						eliminarAlumno(ref listaAlumno);
						break;
					case "c":
						Console.WriteLine("Se encuentran {0} alumnos inscriptos",length(listaAlumno));
						break;
					case "d": break;
					case "e": break;
					case "" : break;
					default:
						Console.Clear();
						Console.WriteLine("Respuesta incorrecta");
						break;
				}
				
				
			}while (respuesta != "");
			// TODO: Implement Functionality Here
			
			Console.Write("Adios");
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
		public static void nuevoAlumno(ref ArrayList alumno){
			string nombre,apellido,escuela;
			long dni;
			Console.WriteLine("Ingrese nombre del alumno");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese apellido del alumno");
			apellido = Console.ReadLine();
			Console.WriteLine("Ingrese dni del alumno");
			dni = long.Parse( Console.ReadLine());
			Console.WriteLine("Ingrese Escuela del alumno");
			escuela =  Console.ReadLine();
			alumno.Add(nombre);
			alumno.Add(apellido);
			alumno.Add(dni);
			alumno.Add(escuela);
			
		}
		public static void eliminarAlumno(ref ArrayList lista){
			ArrayList copia= new ArrayList();
			Console.WriteLine("Ingrese el dni del alumno");
			long dni = long.Parse(Console.ReadLine());
			foreach (ArrayList element in lista) {
				if ((long)element[2] != dni){
					copia.Add(element);
				}
			}
			lista = copia;
		}
		public static int length(ArrayList lista){
			int i=0;
			foreach (var element in lista) {
				i++;
			}
			return i;
		}
		
	}
}