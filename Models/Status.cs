using System;
using System.Collections.Generic;

#nullable disable

namespace JadersonHelp.Models
{
    public partial class Status
    {
        public Status()
        {
            Encomenda = new HashSet<Encomenda>();
            RotasEncomenda = new HashSet<RotasEncomenda>();
        }

        public int IdStatus { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Encomenda> Encomenda { get; set; }
        public virtual ICollection<RotasEncomenda> RotasEncomenda { get; set; }
    }
}
