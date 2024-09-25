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
		public void AgregarDeporte(Deporte deporte){
			int cap = this.deportes.Length;
			Deporte [] deportes= new Deporte[cap+1];
			for (int i = 0; i < cap; i++) {
				deportes[i]= this.deportes[i];
			}
			deportes[-1] = deporte;
			this.deportes = deportes;
			
		}
		public void AgregarAtleta(Atleta atleta){
			int cap = this.atletas.Length;
			Atleta [] atletas= new Atleta[cap+1];
			for (int i = 0; i < cap; i++) {
				atletas[i]= this.atletas[i];
			}
			atletas[-1] = atleta;
			this.atletas = atletas;
		}
		public void EliminarAtleta(Atleta atleta){
			int cap = this.atletas.Length;
			int cont= 0;
			Atleta [] atletas= new Atleta[cap-1];
			try {
				for (int i = 0; i < cap; i++) {
					if(atleta != this.atletas[i]){
						atletas[i]= this.atletas[i];
					}
				}
				this.atletas = atletas;
			} catch (IndexOutOfRangeException) {
				
				Console.WriteLine("Cliente ingresado no existente");
			}
			
		}
		public void EliminarDeporte(Deporte deporte){
			int cap = this.deportes.Length;
			int cont= 0;
			Deporte [] deportes= new Deporte[cap-1];
			try {
				for (int i = 0; i < cap; i++) {
					if(deporte != this.deportes[i]){
						deportes[i]= this.deportes[i];
					}
					
				}
				this.deportes = deportes;
			} catch (IndexOutOfRangeException) {
				
				Console.WriteLine("Deporte ingresado no existente");
			}
			
		}
		public void DarDeBajaEntrenador(){
			
		}
		public void DarDeAltaEntrenador(){
			
		}
		public void DarDeAltaAtleta(Atleta atleta){
			
		}
		public void DarDeBajaAtleta(Atleta atleta){
			
		}
		public void PagarCuota(Atleta atleta){
			
		}
		
	}
}
