using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace JadersonHelp.Models
{
    public partial class RastreioDbContext : DbContext
    {
        public RastreioDbContext()
        {
        }

        public RastreioDbContext(DbContextOptions<RastreioDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Encomenda> Encomendas { get; set; }
        public virtual DbSet<Endereço> Endereços { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Preco> Precos { get; set; }
        public virtual DbSet<Rota> Rotas { get; set; }
        public virtual DbSet<RotasEncomenda> RotasEncomendas { get; set; }
        public virtual DbSet<Sede> Sedes { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=rastreio;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Encomenda>(entity =>
            {
                entity.HasKey(e => e.IdEncomenda)
                    .HasName("PK__Encomend__A37015B9BC140B85");

                entity.Property(e => e.IdEncomenda).HasColumnName("idEncomenda");

                entity.Property(e => e.Altura).HasColumnName("altura");

                entity.Property(e => e.CodRastreio)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("codRastreio");

                entity.Property(e => e.Comprimento).HasColumnName("comprimento");

                entity.Property(e => e.DataPostagem)
                    .HasColumnType("datetime")
                    .HasColumnName("dataPostagem");

                entity.Property(e => e.FkEnderecoDestinatario).HasColumnName("FK_enderecoDestinatario");

                entity.Property(e => e.FkEnderecoRemetente).HasColumnName("FK_enderecoRemetente");

                entity.Property(e => e.FkEnderecoSede).HasColumnName("FK_enderecoSede");

                entity.Property(e => e.FkStatus).HasColumnName("FK_status");

                entity.Property(e => e.Largura).HasColumnName("largura");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.ValorEntrega).HasColumnName("valorEntrega");

                entity.Property(e => e.Volume).HasColumnName("volume");

                entity.HasOne(d => d.FkEnderecoDestinatarioNavigation)
                    .WithMany(p => p.EncomendaFkEnderecoDestinatarioNavigations)
                    .HasForeignKey(d => d.FkEnderecoDestinatario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Encomendas_fk1");

                entity.HasOne(d => d.FkEnderecoRemetenteNavigation)
                    .WithMany(p => p.EncomendaFkEnderecoRemetenteNavigations)
                    .HasForeignKey(d => d.FkEnderecoRemetente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Encomendas_fk2");

                entity.HasOne(d => d.FkEnderecoSedeNavigation)
                    .WithMany(p => p.Encomenda)
                    .HasForeignKey(d => d.FkEnderecoSede)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Encomendas_fk3");

                entity.HasOne(d => d.FkStatusNavigation)
                    .WithMany(p => p.Encomenda)
                    .HasForeignKey(d => d.FkStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Encomendas_fk0");
            });

            modelBuilder.Entity<Endereço>(entity =>
            {
                entity.HasKey(e => e.IdEndereco)
                    .HasName("PK__Endereço__E45B8B27085A5A06");

                entity.Property(e => e.IdEndereco).HasColumnName("idEndereco");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(99)
                    .IsUnicode(false)
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cep");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(99)
                    .IsUnicode(false)
                    .HasColumnName("cidade");

                entity.Property(e => e.Complemento)
                    .IsRequired()
                    .HasMaxLength(99)
                    .IsUnicode(false)
                    .HasColumnName("complemento");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(99)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Rua)
                    .IsRequired()
                    .HasMaxLength(99)
                    .IsUnicode(false)
                    .HasColumnName("rua");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PK__Funciona__B0A1229522364114");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cpf");

                entity.Property(e => e.FkEnderecos).HasColumnName("FK_enderecos");

                entity.Property(e => e.FkSedes).HasColumnName("FK_sedes");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("sexo");

                entity.HasOne(d => d.FkEnderecosNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.FkEnderecos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Funcionarios_fk0");

                entity.HasOne(d => d.FkSedesNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.FkSedes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Funcionarios_fk1");
            });

            modelBuilder.Entity<Preco>(entity =>
            {
                entity.HasKey(e => e.IdPreco)
                    .HasName("PK__Preco__39A855D41AE6618A");

                entity.ToTable("Preco");

                entity.Property(e => e.IdPreco).HasColumnName("idPreco");

                entity.Property(e => e.PrecoFixo).HasColumnName("precoFixo");

                entity.Property(e => e.PrecoKm).HasColumnName("precoKm");

                entity.Property(e => e.PrecoPeso).HasColumnName("precoPeso");

                entity.Property(e => e.PrecoVolume).HasColumnName("precoVolume");
            });

            modelBuilder.Entity<Rota>(entity =>
            {
                entity.HasKey(e => e.IdRota)
                    .HasName("PK__Rotas__E507090A150CC261");

                entity.Property(e => e.IdRota).HasColumnName("idRota");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.FkFuncionario).HasColumnName("FK_funcionario");

                entity.HasOne(d => d.FkFuncionarioNavigation)
                    .WithMany(p => p.Rota)
                    .HasForeignKey(d => d.FkFuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rotas_fk0");
            });

            modelBuilder.Entity<RotasEncomenda>(entity =>
            {
                entity.HasKey(e => e.IdRotaEncomenda)
                    .HasName("PK__Rotas_En__CCB9FB9B2E2DC1C2");

                entity.ToTable("Rotas_Encomendas");

                entity.Property(e => e.IdRotaEncomenda).HasColumnName("idRotaEncomenda");

                entity.Property(e => e.FkEncomendas).HasColumnName("FK_encomendas");

                entity.Property(e => e.FkEndereco).HasColumnName("FK_endereco");

                entity.Property(e => e.FkRotas).HasColumnName("FK_rotas");

                entity.Property(e => e.FkStatus).HasColumnName("FK_status");

                entity.HasOne(d => d.FkEncomendasNavigation)
                    .WithMany(p => p.RotasEncomenda)
                    .HasForeignKey(d => d.FkEncomendas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rotas_Encomendas_fk0");

                entity.HasOne(d => d.FkEnderecoNavigation)
                    .WithMany(p => p.RotasEncomenda)
                    .HasForeignKey(d => d.FkEndereco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rotas_Encomendas_fk3");

                entity.HasOne(d => d.FkRotasNavigation)
                    .WithMany(p => p.RotasEncomenda)
                    .HasForeignKey(d => d.FkRotas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rotas_Encomendas_fk1");

                entity.HasOne(d => d.FkStatusNavigation)
                    .WithMany(p => p.RotasEncomenda)
                    .HasForeignKey(d => d.FkStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rotas_Encomendas_fk2");
            });

            modelBuilder.Entity<Sede>(entity =>
            {
                entity.HasKey(e => e.IdSede)
                    .HasName("PK__Sedes__C5AF63D057291D05");

                entity.Property(e => e.IdSede).HasColumnName("idSede");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FkEnderecos).HasColumnName("FK_enderecos");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(99)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("site");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.HasOne(d => d.FkEnderecosNavigation)
                    .WithMany(p => p.Sedes)
                    .HasForeignKey(d => d.FkEnderecos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Sedes_fk0");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__Status__01936F74F45AB8E7");

                entity.ToTable("Status");

                entity.Property(e => e.IdStatus).HasColumnName("idStatus");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
