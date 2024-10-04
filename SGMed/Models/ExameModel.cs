using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGMed.Models
{
    public class ExameModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExame { get; set; }
        public string DescricaoExame { get; set; }
    }
}
