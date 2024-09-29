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
			// Listado de deportes y atletas (Niños/as) ya creado para la simulacion del programa
			int i = 0;
			Club club = new Club();
			Atleta atleta = new Atleta("1");
			
			do{
				Menu();
				i = Intput();
				switch (i) {
					case 1:
						Console.WriteLine("opcion 1");
						break;
					case 2:
						Console.WriteLine("opcion 2");
						break;
					case 3:
						Console.WriteLine("opcion 3");
						break;
					case 4:
						Console.WriteLine("opcion 4");
						break;
					case 5:
						Console.WriteLine("opcion 5");
						break;
					case 6:
						
						do{
							Console.Clear();
							Console.WriteLine("opcion 6");
							SubMenu();
							i = Intput();
							switch (i) {
								case 1:
									Console.WriteLine("opcion 1");
									break;
								case 2:
									Console.WriteLine("opcion 2");
									break;
								case 3:
									Console.WriteLine("opcion 3");
									break;
								case 4:
									Console.WriteLine("Atras.");
									break;
								default: 
									Console.WriteLine("Opcion incorrecta");
									Console.ReadKey();
									Console.Clear();
									break;
							}
						}while(i!= 4);

						break;
					case 7:
						Console.WriteLine("opcion 5");
						break;
					case 0:
						Console.WriteLine("Adios");
						i = 0;
						break;
					default:
						Console.WriteLine("Valor ingresado no valido");
						Console.ReadKey();
						Console.Clear();
						break;
				}
				
			}while (i!=0) ;
			
			
			
			
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
			Console.WriteLine("0_ Salir");
		}
		public static void SubMenu(string texto = "Elija una de las siguientes opciones"){
			Console.WriteLine(texto);
			Console.WriteLine("1_ Por Deporte");
			Console.WriteLine("2_ Por Deporte y Categoria");
			Console.WriteLine("3_ Total");
			Console.WriteLine("4_ Regresar al Menu");
			
		}
		public static int Intput(){ // Entrada de un entero con control.
			int salida = 0;
			try {
				salida = int.Parse(Console.ReadLine());
				return salida;
			} catch (OverflowException) {
				Console.WriteLine("Exeso de valor ingresado");
				return Intput();
				
			}catch(FormatException){
				Console.WriteLine("A ingresado un valor no numerico");
				return Intput();
			}
		}
	}
}