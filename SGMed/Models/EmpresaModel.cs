using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGMed.Models
{
    public class EmpresaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public string EnderecoEmpresa { get; set; }
    }
}
