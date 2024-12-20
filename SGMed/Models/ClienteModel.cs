﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGMed.Models
{
    public class ClienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }
        public string NomeCompleto { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string CPF { get; set; }
        public string EnderecoCliente { get; set; }

        [ForeignKey("EmpresaModel")]
        public int EmpresafkID { get; set; }

    }



}
