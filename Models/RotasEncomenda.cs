using System;
using System.Collections.Generic;

#nullable disable

namespace JadersonHelp.Models
{
    public partial class RotasEncomenda
    {
        public int IdRotaEncomenda { get; set; }
        public int FkEncomendas { get; set; }
        public int FkRotas { get; set; }
        public int FkStatus { get; set; }
        public int FkEndereco { get; set; }

        public virtual Encomenda FkEncomendasNavigation { get; set; }
        public virtual Endereço FkEnderecoNavigation { get; set; }
        public virtual Rota FkRotasNavigation { get; set; }
        public virtual Status FkStatusNavigation { get; set; }
    }
}
