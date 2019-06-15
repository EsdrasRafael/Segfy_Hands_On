using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class SeguroAuto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nchar(100)")]
        public int NumeroApolice { get; set; }
        [Required]
        [Column(TypeName = "nchar(11)")]
        public string CPF { get; set; }
        [Required]
        [Column(TypeName = "nchar(7)")]
        public string PlacaVeiculo { get; set; }
        [Required]
        public float ValorPremio { get; set; }
    }
}
