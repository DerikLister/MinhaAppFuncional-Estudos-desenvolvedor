﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMvcFuncional.Models
{
    public class Aluno
    {
        [Key]
        public  int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        public  string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "O Campo {0} está em formato incorreto")]
        [Display(Name = "Data de Nascimento")]
        public  DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(60, ErrorMessage = "O campo {0} precisa ter {1} caracteres")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public  string? Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Confirme o E-mail")]
        [Compare("Email", ErrorMessage = "Os E-mails informados não são idênticos")]
        [NotMapped]
        public  string? EmailConfirmacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Avaliação")]
        [Range(1, 5, ErrorMessage = "O campo {0} deve estar entre {1} e {2}")]
        public  int Avaliacao { get; set; }

        public  bool Ativo { get; set; }

    }
}
