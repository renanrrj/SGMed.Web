namespace SGMed.Models
{
    public class ClienteModel : EmpresaModel
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }
        public string NomeCompleto { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string CPF { get; set; }
        public string EnderecoCliente { get; set; }

        public List<EmpresaModel> EmpresA { get; set; } = new List<EmpresaModel>();
    }

        

}
