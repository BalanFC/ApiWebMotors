using System.ComponentModel.DataAnnotations;

namespace Entities
{
	public class AnuncioWebMotors
	{
		[Required]
		public int Id { get; set; }
		[Required]
		public string Marca { get; set; }
		[Required]
		public string Modelo { get; set; }
		[Required]
		public string Versao { get; set; }
		[Required]
		public int Ano { get; set; }
		[Required]
		public int Quilometragem { get; set; }
		[Required]
		public string Observacao { get; set; }
	}
}
