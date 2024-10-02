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
	public class Atleta : Categoria 
	{
		string nombre="";
		int edad;	
		Deporte dep;
		bool socio;
		DateTime ultimoPago;
		
		public Atleta(string nombre, int edad,string categoria): base( categoria)
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
		
		public Deporte deporte{
			set{
				dep = value;
			}
			get{
				return dep;
			}
		}
		
		public bool Socio{
			set{
				socio = value;
			}
			get {
				return socio;
			}
		}
	}
}
