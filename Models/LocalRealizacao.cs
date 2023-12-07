using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalCaroline.Models
{
    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name = "Código do Local")]
        public int Id { get; set; }

        [Column("LocalNome")]
        [Display(Name = "Local")]
        public string LocalNome { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
