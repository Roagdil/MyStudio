/*
 * Creado por SharpDevelop.
 * Usuario: Rodrigo
 * Fecha: 29/09/2024
 * Hora: 11:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Enunciado_4
{
	/// <summary>
	/// Description of Cupos.
	/// </summary>
	public class Cupos : Exception
	{
		public Cupos() : base() // si Cupos- inscriptos == 0 , se genera un error y lo imprimimos en pantalla
		{
		}
	}
}
