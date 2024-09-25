/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 19/09/2024
 * Hora: 21:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Enunciado_4
{
	/// <summary>
	/// Description of Atleta.
	/// </summary>
	public class Atleta
	{
		string nombre="";
		int edad;
		Deporte deporte;
		int categoria;
		bool socio;
		DateTime ultimoPago;
		
		public Atleta()
		{
		}
		
		public void ActualizarPago(){
			ultimoPago = DateTime.Now;
		}
		public DateTime UltimoPago{
			set{
				ultimoPago = value;
			}
			get {
				return ultimoPago;
			}
		}
	}
}
