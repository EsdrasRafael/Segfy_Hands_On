using System;
using System.Collections.Generic;
using System.Text;

namespace SegfyHandsOn.Domain.Entities
{
    public class SeguroAuto : Apolice
    {
        public string PlacaVeiculo { get; set; }
        public float ValorPremio { get; set; }
    }
}
