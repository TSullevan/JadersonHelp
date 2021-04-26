using System;
using System.Collections.Generic;

#nullable disable

namespace JadersonHelp.Models
{
    public partial class Preco
    {
        public int IdPreco { get; set; }
        public double PrecoKm { get; set; }
        public double PrecoPeso { get; set; }
        public double PrecoVolume { get; set; }
        public double PrecoFixo { get; set; }
    }
}
