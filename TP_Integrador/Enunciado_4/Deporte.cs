/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 20/09/2024
 * Hora: 19:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Enunciado_4
{
	/// <summary>
	/// Description of Deporte.
	/// </summary>
	public class Deporte
	{
		string nombreEntrenador;
		string dias;
		DateTime [] horarios ;
		int cupos;
		int cantidadInscriptos; // atletas.count 
		int costo;
		
		public Deporte()
		{
		}
		public void DarAltaEntrenador(string entrenador){
			nombreEntrenador = entrenador;
		}
		public void DarBajaEntrenador(){
			
		}
		public void AgregarAtleta(){
			cupos--;
		}
		public void QuitarAtleta(){
			cupos++;
		}
	}
}
