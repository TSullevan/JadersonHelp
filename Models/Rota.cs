using System;
using System.Collections.Generic;

#nullable disable

namespace JadersonHelp.Models
{
    public partial class Rota
    {
        public Rota()
        {
            RotasEncomenda = new HashSet<RotasEncomenda>();
        }

        public int IdRota { get; set; }
        public int FkFuncionario { get; set; }
        public DateTime Data { get; set; }

        public virtual Funcionario FkFuncionarioNavigation { get; set; }
        public virtual ICollection<RotasEncomenda> RotasEncomenda { get; set; }
    }
}
