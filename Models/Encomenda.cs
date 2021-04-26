using System;
using System.Collections.Generic;

#nullable disable

namespace JadersonHelp.Models
{
    public partial class Encomenda
    {
        public Encomenda()
        {
            RotasEncomenda = new HashSet<RotasEncomenda>();
        }

        public int IdEncomenda { get; set; }
        public string CodRastreio { get; set; }
        public int Peso { get; set; }
        public double Comprimento { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public double Volume { get; set; }
        public double ValorEntrega { get; set; }
        public DateTime DataPostagem { get; set; }
        public int FkStatus { get; set; }
        public int FkEnderecoDestinatario { get; set; }
        public int FkEnderecoRemetente { get; set; }
        public int FkEnderecoSede { get; set; }

        public virtual Endereço FkEnderecoDestinatarioNavigation { get; set; }
        public virtual Endereço FkEnderecoRemetenteNavigation { get; set; }
        public virtual Sede FkEnderecoSedeNavigation { get; set; }
        public virtual Status FkStatusNavigation { get; set; }
        public virtual ICollection<RotasEncomenda> RotasEncomenda { get; set; }
    }
}
