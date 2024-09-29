/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 19/09/2024
 * Hora: 20:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Enunciado_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Club club = new Club();
			Atleta atleta = new Atleta();
			Menu();
			Console.WriteLine( Intput());
			club.PagarCuota(atleta);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void Menu(string texto = "Elija una de las siguientes opciones"){
			Console.WriteLine(texto);
			Console.WriteLine("1_ Dar de Alta a un entrenador");
			Console.WriteLine("2_ Dar de Baja a un entrenador");
			Console.WriteLine("3_ Dar de Alta a un Atleta");
			Console.WriteLine("4_ Dar de Baja a un Atleta"); // Actualizar cupos
			Console.WriteLine("5_ Pagar cuota de un Atleta");
			Console.WriteLine("6_ Lista de Inscriptos");
			Console.WriteLine("7_ Lista de Deudores");
		}
		public static void SubMenu(string texto = "Elija una de las siguientes opciones"){
			Console.WriteLine(texto);
			Console.WriteLine("1_ Por Deporte");
			Console.WriteLine("2_ Por Deporte y Categoria");
			Console.WriteLine("3_ Total");
			Console.WriteLine("0_ Regresar al Menu");
			
		}
		public static int Intput(){
			int salida = 0;
			try {
				salida = int.Parse(Console.ReadLine());
				return salida;
			} catch (OverflowException) {
				Console.WriteLine("Exeso de valor ingresado");
				
			}catch(FormatException){
				Console.WriteLine("A ingresado un valor no numerico");
			}
			return salida;
			
		}
	}
}