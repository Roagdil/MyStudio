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
	public class Deporte : Categoria
	{
		string nombre;
		string nombreEntrenador;
		string [] dias;
		int [] horarios ;
		int cupos;
		int cantidadInscriptos=0; 
		int costo;
		
		public Deporte(string nombre , string categoria) : base (categoria)
		{
		}
		public string NombreEntrenador{
			set{
				this.nombreEntrenador = value;
			}
			get{
				return this.nombreEntrenador;
			}
		}
		public void AgregarAtleta(){
			cupos--;
			cantidadInscriptos ++;
		}
		public void QuitarAtleta(){
			cupos++;
			cantidadInscriptos --;
		}
		public string Nombre{
			get{
				return this.nombre;
			}
		}
	}
}
