using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalCaroline.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("CidadeId")]
        [Display(Name = "Código do Cidade")]
        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Cidade")]
        public string CidadeNome { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]
        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }
    }
}
