/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 28/07/2024
 * Hora: 15:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			ArrayList lista = new ArrayList();
			string palabra="";
			int cantC =0;
			int cantP =0;
			int cantS =0;
			Console.WriteLine("ingrese una palabra, de lo contrario dejelo vacio");
			do{
				
				palabra = Console.ReadLine();
				if (palabra==""){
					break;
				}else{
					lista.Add(palabra);
					cantC+= palabra.Length;
					cantS+= palabra.IndexOf("s")== 0? 1 : 0;
					cantP++;
				}
				
			}while (true) ;
			double promedioS= cantS!=0 ? (cantS*100)/cantP : 0;
			double promedioC= cantP!=0 ? cantC/cantP : 0 ;
			int i =1;
			Console.WriteLine("Indice  |Palabra |Cant de Caracteres");
			foreach(string x in lista){
				
				Console.WriteLine(" {0}      |{1}  	 |{2} ",i, x,x.Length);
				i++;
			}
			Console.Write(" promedio de S por palabra: %{0}. ", promedioS);
			Console.Write("promedio de caracteres por palabra: {0} ", promedioC);
			Console.ReadKey(true);
				
			
			
			
			
		}
	}
}