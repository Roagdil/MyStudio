/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 29/09/2024
 * Hora: 11:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Enunciado_4
{
	/// <summary>
	/// Description of Categoria.
	/// </summary>
	public class Categoria
	{
		string cat;
		
		public Categoria(int cat)
		{
			if (cat >= 6 && cat <= 10){
				this.cat = "Menor";
			}else if (cat >= 11 && cat <= 17) {
				this.cat = "Adolecente";
			}else if (cat >= 18) {
				this.cat = "Adulto";
			}
		}
		public string categoria{
			set{
				this.cat = value;
			}
			get{
				return this.cat;
			}
		}
	}
}
