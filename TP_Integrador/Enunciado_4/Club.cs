/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 23/09/2024
 * Hora: 17:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Enunciado_4
{
	/// <summary>
	/// Description of Club.
	/// </summary>
	public class Club
	{	
		Atleta [] atletas;
		Deporte [] deportes;
		public Club()
		{
		}
		
		public void ImprimirDeudores(){
			foreach (Atleta atleta in atletas) {
				if(atleta.UltimoPago == DateTime.Now){
					Console.WriteLine(atleta);
				}
			}
		}
	}
}
