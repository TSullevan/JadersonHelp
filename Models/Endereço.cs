using System;
using System.Collections.Generic;

#nullable disable

namespace JadersonHelp.Models
{
    public partial class Endereço
    {
        public Endereço()
        {
            EncomendaFkEnderecoDestinatarioNavigations = new HashSet<Encomenda>();
            EncomendaFkEnderecoRemetenteNavigations = new HashSet<Encomenda>();
            Funcionarios = new HashSet<Funcionario>();
            RotasEncomenda = new HashSet<RotasEncomenda>();
            Sedes = new HashSet<Sede>();
        }

        public int IdEndereco { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }

        public virtual ICollection<Encomenda> EncomendaFkEnderecoDestinatarioNavigations { get; set; }
        public virtual ICollection<Encomenda> EncomendaFkEnderecoRemetenteNavigations { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<RotasEncomenda> RotasEncomenda { get; set; }
        public virtual ICollection<Sede> Sedes { get; set; }
    }
}
