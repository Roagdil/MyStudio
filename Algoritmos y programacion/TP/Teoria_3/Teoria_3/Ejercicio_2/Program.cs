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
			string respuesta;
			ArrayList alumno = new	ArrayList();
			ArrayList listaEscuela= new ArrayList();
			
			
			
			
			
			do{
				menu();
				respuesta = Console.ReadLine();
				switch (respuesta) {
					case "a": // inscribir un alumno
						nuevoAlumno(ref alumno);
						agregarEscuela(ref listaEscuela, alumno);
						break;
					case "b": // borrar alumno
						eliminarAlumno(ref listaEscuela);
						break;
					case "c":
						
						break;
					case "d":
						
						break;
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
		public static void eliminarAlumno(ref ArrayList listaEscuela){
			ArrayList alumnos= new ArrayList();
			Console.WriteLine("Ingrese el dni del alumno");
			long dni = long.Parse(Console.ReadLine());
			foreach (ArrayList escuela in listaEscuela) { // escuela tiene nombre{0} y listadeAlumnos{1}
				foreach (ArrayList Alumno in (ArrayList)escuela[1]) {
					if ((long)Alumno[2]== dni){		
						escuela.Remove(Alumno);
						Console.WriteLine("Alumno eliminado");
						break;
					}
										
					
				}
				
			}
			
		}
		public static int length(ArrayList lista){
			int i=0;
			foreach (var element in lista) {
				i++;
			}
			return i;
		}
		public static void agregarEscuela(ref ArrayList escuelas, ArrayList alumno){
			// formato de Escuela = nombre , lista de alumnos
			bool condicion= true;
			foreach (ArrayList escuela in escuelas) {
				if ((string)escuela[0]==(string)alumno[3]){
					condicion = false;
					ArrayList alumnos = (ArrayList)escuela[1];
					alumnos.Add(alumno);
					escuela[1]= alumnos;
				}
			}
			if (condicion){
				ArrayList listaAlumno = new ArrayList(){alumno};
				string nombre = (string )alumno[3];
				ArrayList escuela= new ArrayList(){nombre,listaAlumno};
				escuelas.Add(escuela);
			}
		}
		
	}
}