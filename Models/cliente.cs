﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Solicitacao_de_orcamento.Models
{
    public class cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do contato deve ser informado.!")]
        [StringLength(50, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O telefone deve ser informado.!")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Forneça o número do telefone no formato (00) 00000-0000")]
        [DisplayName("Número do Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O email é obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Tipo de Projeto")]
        public string TipoProjeto { get; set; }

        [Required(ErrorMessage = "Ínforme a descrição do projeto.")]
        [DisplayName("Descrição do Projeto")]
        [StringLength(5000, MinimumLength = 20)]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
    }
}