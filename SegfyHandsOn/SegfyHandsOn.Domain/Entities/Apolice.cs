using System;
using System.Collections.Generic;
using System.Text;

namespace SegfyHandsOn.Domain.Entities
{
    public class Apolice : BaseEntity
    {
        public int NumeroApolice { get; set; }
        public string CPF { get; set; }
    }
}
