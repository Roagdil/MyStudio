/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 30/07/2024
 * Hora: 12:05
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
			Console.WriteLine("Welcome!!!");
			int opcion=0;
			double num1=0;
			double num2=0;
			double resultado=0;
			bool condicion= true;
			while (condicion) {
				opcion = Menu();
				Console.WriteLine(resultado);
				switch (opcion) {
					case 1:
						Console.WriteLine("-------------Sumar-------");
						num1 =  PedirNumero();
						num2 =  PedirNumero();
						resultado= Sumar(num1,num2);
						Console.WriteLine("Su resultado es: " + resultado);
						break;
					case 2:
						Console.WriteLine("-------Restar--------");
						num1 =  PedirNumero();
						num2 = PedirNumero();
						resultado= Restar(num1,num2);
						Console.WriteLine("Su resultado es: " + resultado);
						break;
					case 3:
						Console.WriteLine("----------Multiplicar----------");
						num1 = PedirNumero();
						num2 = PedirNumero();
						resultado= Multiplicar(num1,num2);
						Console.WriteLine("Su resultado es: " + resultado);
						break;
					case 4:
						Console.WriteLine("------Dividir--------");
						num1 = PedirNumero();
						num2 = PedirNumero();
						resultado= Dividir(num1,num2);
						Console.WriteLine("Su resultado es: " + resultado);
						break;
					case 5:
						resultado=0;
						Console.Clear();
						break;
					case 0: 
						condicion = false;
						Console.Clear();
						Console.WriteLine("Adios...");
						break;
					default:
						Console.WriteLine("Ocurrio un error");
						break;
				}
			}
		
			Console.ReadKey(true);
		}
		public static double Sumar(double val1, double val2){
			return val1 + val2;
		}
		public static double Restar(double val1, double val2){
			return val1 - val2;
		}
		public static double Dividir(double val1, double val2){
			return val1 != 0 && val2!= 0 ? val1 / val2 : 0;
		}
		public static double Multiplicar(double val1, double val2){
			return val1 != 0 && val2!= 0 ? val1* val2 : 0;
		}
		public static int Menu(string texto=""){
			int x=0;
			texto = texto== "" ? "Que deseas hacer?" : texto;
			Console.WriteLine(texto);
			Console.WriteLine("1_ Sumar");
			Console.WriteLine("2_ Restar");
			Console.WriteLine("3_ Multiplicar");
			Console.WriteLine("4_ Dividir");
			Console.WriteLine("5_ Borrar resultado");
			Console.WriteLine("Enter_ Salir");
			x=(int) PedirNumero();
			Console.Clear();
			return x<=5 && x>=0 ? x : Menu("Ingrese una opcion valida por favor...");
		}
		public static double PedirNumero(string texto=""){
			double x= 0;
			texto = texto== "" ? "Ingresa un numero" : texto;
			Console.WriteLine(texto);
			string s= Console.ReadLine();
			
			foreach( char c in s){
				if (!((int)c <= 57 && (int)c >=48)){
					return PedirNumero("Ingrese un numero por favor");
				}
			}
			x= s.Length==0 ? 0 :  double.Parse(s);
			return x;
		}
	}
}