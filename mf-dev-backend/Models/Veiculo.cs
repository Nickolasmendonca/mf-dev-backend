﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Obrigatorio informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar placa!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar Ano de Fabricacao!")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar Ano do Modelo!")]
        public int AnoModelo { get; set; }
    }
}
