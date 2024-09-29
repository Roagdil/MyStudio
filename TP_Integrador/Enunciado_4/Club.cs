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
		public void DarDeBajaEntrenador(Deporte deporte){
			
		}
		public void DarDeAltaEntrenador(Deporte deporte){
			
		}
	
		public void PagarCuota(Atleta atleta){
			// pagar cuota de un atleta, se debe buscar el deporte que esta anotado y 
			foreach (Atleta  atleta1 in atletas) {
				Console.WriteLine(atleta1);
			}
		}
	}
}
//		
	