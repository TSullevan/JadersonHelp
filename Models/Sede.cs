using System;
using System.Collections.Generic;

#nullable disable

namespace JadersonHelp.Models
{
    public partial class Sede
    {
        public Sede()
        {
            Encomenda = new HashSet<Encomenda>();
            Funcionarios = new HashSet<Funcionario>();
        }

        public int IdSede { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string Nome { get; set; }
        public int FkEnderecos { get; set; }

        public virtual Endereço FkEnderecosNavigation { get; set; }
        public virtual ICollection<Encomenda> Encomenda { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
