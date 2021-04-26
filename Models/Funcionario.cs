using System;
using System.Collections.Generic;

#nullable disable

namespace JadersonHelp.Models
{
    public partial class Funcionario
    {
        public Funcionario()
        {
            Rota = new HashSet<Rota>();
        }

        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Sexo { get; set; }
        public string Cargo { get; set; }
        public int FkEnderecos { get; set; }
        public int FkSedes { get; set; }

        public virtual Endereço FkEnderecosNavigation { get; set; }
        public virtual Sede FkSedesNavigation { get; set; }
        public virtual ICollection<Rota> Rota { get; set; }
    }
}
