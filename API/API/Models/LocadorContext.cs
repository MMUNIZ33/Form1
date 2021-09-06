using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace API.Models
{
    public partial class LocadorContext : DbContext
    {
        public LocadorContext()
        {
        }

        public LocadorContext(DbContextOptions<LocadorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<tbl_Cliente> tbl_Clientes { get; set; }
        public virtual DbSet<tbl_ClientesContato> tbl_ClientesContatos { get; set; }
        public virtual DbSet<tbl_Clientes_PreCadastro> tbl_Clientes_PreCadastros { get; set; }
        public virtual DbSet<tbl_Clientes_PreCadastro_Contato> tbl_Clientes_PreCadastro_Contatos { get; set; }
        public virtual DbSet<tbl_TipoContato> tbl_TipoContatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=201.73.1.11;Initial Catalog=Locador;Uid=locador;pwd=blomaq@20");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<tbl_Cliente>(entity =>
            {
                entity.HasKey(e => e.CodCliente);

                entity.HasIndex(e => new { e.CodCliente, e.DesCliente }, "_dta_index_tbl_Clientes_5_1120775100__K1_K2_3_16_17_30_31")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.DesCliente, "_dta_index_tbl_Clientes_5_1120775100__K2_1_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30_31_32_")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.DesCliente, "_dta_index_tbl_Clientes_5_855674096__K2_1_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.CodCliente, "_dta_index_tbl_Clientes_7_2045302396__K1_2_11_24_25_35");

                entity.HasIndex(e => e.DesCliente, "_dta_index_tbl_Clientes_7_2045302396__K2_1_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30_31_32_");

                entity.HasIndex(e => e.DesCliente, "idxDesCliente")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.RazaoSocial, "idxRazaoSocial")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CEP)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CNH)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CNHValidade).HasColumnType("smalldatetime");

                entity.Property(e => e.CNPJ)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CPF)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Contato)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contato2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contato3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatCadastro).HasColumnType("smalldatetime");

                entity.Property(e => e.DatLiberado).HasColumnType("datetime");

                entity.Property(e => e.DesCliente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoComplemento)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FlgLiberado).HasDefaultValueSql("((0))");

                entity.Property(e => e.IE)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IM)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NomUsuario)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NomUsuarioLiberado)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RG)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Suframa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone2)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone3)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VlrDesconto).HasColumnType("numeric(8, 2)");
            });

            modelBuilder.Entity<tbl_ClientesContato>(entity =>
            {
                entity.HasKey(e => e.CodContato);

                entity.Property(e => e.Contato)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAssinaPDF).HasDefaultValueSql("((0))");

                entity.Property(e => e.FlgEmailPara).HasDefaultValueSql("((1))");

                entity.Property(e => e.MetodoAutenticacao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TipoContato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodClienteNavigation)
                    .WithMany(p => p.tbl_ClientesContatos)
                    .HasForeignKey(d => d.CodCliente)
                    .HasConstraintName("FK_tbl_ClientesContatos_tbl_Clientes");

                entity.HasOne(d => d.idTipoContatoNavigation)
                    .WithMany(p => p.tbl_ClientesContatos)
                    .HasForeignKey(d => d.idTipoContato)
                    .HasConstraintName("FK_tbl_ClientesContatos_tbl_TipoContato");
            });

            modelBuilder.Entity<tbl_Clientes_PreCadastro>(entity =>
            {
                entity.HasKey(e => e.CodClientePre);

                entity.ToTable("tbl_Clientes_PreCadastro");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CEP)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CNPJ)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CPF)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Contato)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatCadastro).HasColumnType("smalldatetime");

                entity.Property(e => e.DesCliente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoComplemento)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IE)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IM)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NomUsuario)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RG)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Suframa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_Clientes_PreCadastro_Contato>(entity =>
            {
                entity.HasKey(e => e.CodContatoPre);

                entity.Property(e => e.Contato)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAssinaPDF).HasDefaultValueSql("((0))");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodClientePreNavigation)
                    .WithMany(p => p.tbl_Clientes_PreCadastro_Contatos)
                    .HasForeignKey(d => d.CodClientePre)
                    .HasConstraintName("FK_tbl_Clientes_PreCadastro_Contatos_tbl_Clientes_PreCadastro");

                entity.HasOne(d => d.idTipoContatoNavigation)
                    .WithMany(p => p.tbl_Clientes_PreCadastro_Contatos)
                    .HasForeignKey(d => d.idTipoContato)
                    .HasConstraintName("FK_tbl_Clientes_PreCadastro_Contatos_tbl_TipoContato");
            });

            modelBuilder.Entity<tbl_TipoContato>(entity =>
            {
                entity.HasKey(e => e.idTipoContato);

                entity.ToTable("tbl_TipoContato");

                entity.Property(e => e.DesTipoContato)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
