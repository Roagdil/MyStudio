/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 23/09/2024
 * Hora: 17:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Enunciado_4
{
	/// <summary>
	/// Description of Club.
	/// </summary>
	public class Club
	{
		ArrayList atletas;
		ArrayList deportes;
		public Club()
		{
		}
		
		public void ImprimirDeudores(){
			foreach (Atleta atleta in atletas) {
				if(atleta.UltimoPago.Month != DateTime.Now.Month){
					Console.WriteLine(atleta);
				}
			}
		}
		
		public void AgregarAtleta(Atleta atleta){
			
			
		}
		public void EliminarAtleta(Atleta atleta){
			
		}
		public void DarDeBajaEntrenador(int i){
			try {
				Deporte deporte = (Deporte)deportes[i-1];
				deporte.NombreEntrenador= "";
				Console.Clear();
				Console.WriteLine("Entrenador dado de baja correctamente");
				Console.ReadKey();
			} catch (IndexOutOfRangeException) {
				
				Console.WriteLine("Indice ingresado no corresponde con las opciones");
				Console.ReadKey();
			}
		}
		public void AgregarEntrenador(int i){
			try {
				Deporte deporte = (Deporte)deportes[i-1];
				Console.WriteLine("Ingrese el nombre del Entrenador");
				deporte.NombreEntrenador= Console.ReadLine();
				Console.Clear();
				Console.WriteLine("Datos guardados correctamente");
				Console.ReadKey();
			} catch (IndexOutOfRangeException) {
				
				Console.WriteLine("Indice ingresado no corresponde con las opciones");
				Console.ReadKey();
			}
		}
	
		public void PagarCuota(Atleta atleta){
			// pagar cuota de un atleta, se debe buscar el deporte que esta anotado 
			foreach (Atleta  atleta1 in atletas) {
				Console.WriteLine(atleta1);
			}
		}
		public void Deportes(){
			Deporte deporte ;
			for (int i = 0; i < deportes.Count; i++) {
				deporte = (Deporte)deportes[i];
				Console.WriteLine("{0}_ {1} categoria: {2}",i+1,deporte.Nombre, deporte.categoria);
			}
		}
	}
}
//		
	