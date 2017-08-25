﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo03.MVC.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        public string Especie { get; set; }
    }
}