using System;
using System.ComponentModel.DataAnnotations;

namespace ScaniaClientBase.Models
{
    // SSBCVP : Classe criada sem o uso de assistentes
    public class Cliente
    {
        // Key: Indica para o Entity Framework (EF) que o Id é chave
        [Key]
        public int Id { get; set; }
        // Required : Indica para o EF que o Nome é obrigatório
        [Required]
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}