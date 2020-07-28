using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace apivistoria2.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<EmpresaConsultaVeicular> EmpresaConsultaVeicular { get; set; }
        public virtual DbSet<EmpresaConsultaVeicularParametroEntrada> EmpresaConsultaVeicularParametroEntrada { get; set; }
        public virtual DbSet<EmpresaConsultaVeicularValorDeEntrada> EmpresaConsultaVeicularValorDeEntrada { get; set; }
        public virtual DbSet<EmpresaEmpresaConsultaVeicular> EmpresaEmpresaConsultaVeicular { get; set; }
        public virtual DbSet<EmpresaEndereco> EmpresaEndereco { get; set; }
        public virtual DbSet<EmpresaSetupFoto> EmpresaSetupFoto { get; set; }
        public virtual DbSet<GrupoVestigio> GrupoVestigio { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<PessoaEndereco> PessoaEndereco { get; set; }
        public virtual DbSet<PessoaTipoServico> PessoaTipoServico { get; set; }
        public virtual DbSet<SetupFoto> SetupFoto { get; set; }
        public virtual DbSet<StatusAgenda> StatusAgenda { get; set; }
        public virtual DbSet<StatusVestigio> StatusVestigio { get; set; }
        public virtual DbSet<TblCliente> TblCliente { get; set; }
        public virtual DbSet<TblControle> TblControle { get; set; }
        public virtual DbSet<TblEndereco> TblEndereco { get; set; }
        public virtual DbSet<TblFranqueador> TblFranqueador { get; set; }
        public virtual DbSet<TblFranqueadorGrupoVestigio> TblFranqueadorGrupoVestigio { get; set; }
        public virtual DbSet<TblFranqueadorObjetoFoto> TblFranqueadorObjetoFoto { get; set; }
        public virtual DbSet<TblFranqueadorSegmento> TblFranqueadorSegmento { get; set; }
        public virtual DbSet<TblFranqueadorStatusVestigio> TblFranqueadorStatusVestigio { get; set; }
        public virtual DbSet<TblFranqueadorTipoServico> TblFranqueadorTipoServico { get; set; }
        public virtual DbSet<TblFranqueadorTipoServicoVestigio> TblFranqueadorTipoServicoVestigio { get; set; }
        public virtual DbSet<TblFranqueadorTipoVeiculo> TblFranqueadorTipoVeiculo { get; set; }
        public virtual DbSet<TblFranqueadorTipoVeiculoVestigio> TblFranqueadorTipoVeiculoVestigio { get; set; }
        public virtual DbSet<TblFranqueadorTipoVeiculoVestigioServico> TblFranqueadorTipoVeiculoVestigioServico { get; set; }
        public virtual DbSet<TblFranqueadorTipoVestigio> TblFranqueadorTipoVestigio { get; set; }
        public virtual DbSet<TblFranqueadorVestigio> TblFranqueadorVestigio { get; set; }
        public virtual DbSet<TblGrupoEconomico> TblGrupoEconomico { get; set; }
        public virtual DbSet<TblLaudo> TblLaudo { get; set; }
        public virtual DbSet<TblLaudoVestigio> TblLaudoVestigio { get; set; }
        public virtual DbSet<TblModuloSistema> TblModuloSistema { get; set; }
        public virtual DbSet<TblModuloSistemaFilho> TblModuloSistemaFilho { get; set; }
        public virtual DbSet<TblObjetoFoto> TblObjetoFoto { get; set; }
        public virtual DbSet<TblPerfil> TblPerfil { get; set; }
        public virtual DbSet<TblPerfilModulo> TblPerfilModulo { get; set; }
        public virtual DbSet<TblPessoa> TblPessoa { get; set; }
        public virtual DbSet<TblPessoaFisica> TblPessoaFisica { get; set; }
        public virtual DbSet<TblPessoaJuridica> TblPessoaJuridica { get; set; }
        public virtual DbSet<TblProvedor> TblProvedor { get; set; }
        public virtual DbSet<TblProvedorParametro> TblProvedorParametro { get; set; }
        public virtual DbSet<TblRelacionamento> TblRelacionamento { get; set; }
        public virtual DbSet<TblSegmento> TblSegmento { get; set; }
        public virtual DbSet<TblSetupFoto> TblSetupFoto { get; set; }
        public virtual DbSet<TblTipoEndereco> TblTipoEndereco { get; set; }
        public virtual DbSet<TblTipoVeiculo> TblTipoVeiculo { get; set; }
        public virtual DbSet<TblUf> TblUf { get; set; }
        public virtual DbSet<TblUsuario> TblUsuario { get; set; }
        public virtual DbSet<TblUsuarioModulo> TblUsuarioModulo { get; set; }
        public virtual DbSet<TblVistoria> TblVistoria { get; set; }
        public virtual DbSet<TblVistoriaGrupoVestigio> TblVistoriaGrupoVestigio { get; set; }
        public virtual DbSet<TblVistoriaProvedor> TblVistoriaProvedor { get; set; }
        public virtual DbSet<TblVistoriaProvedorParametro> TblVistoriaProvedorParametro { get; set; }
        public virtual DbSet<TblVistoriaSegmento> TblVistoriaSegmento { get; set; }
        public virtual DbSet<TblVistoriaSetupFoto> TblVistoriaSetupFoto { get; set; }
        public virtual DbSet<TblVistoriaStatusVestigio> TblVistoriaStatusVestigio { get; set; }
        public virtual DbSet<TblVistoriaTipoServico> TblVistoriaTipoServico { get; set; }
        public virtual DbSet<TblVistoriaTipoServicoCliente> TblVistoriaTipoServicoCliente { get; set; }
        public virtual DbSet<TblVistoriaTipoServicoSegmento> TblVistoriaTipoServicoSegmento { get; set; }
        public virtual DbSet<TblVistoriaTipoServicoVestigio> TblVistoriaTipoServicoVestigio { get; set; }
        public virtual DbSet<TblVistoriaTipoVeiculoVestigio> TblVistoriaTipoVeiculoVestigio { get; set; }
        public virtual DbSet<TblVistoriaTipoVeiculoVestigioServico> TblVistoriaTipoVeiculoVestigioServico { get; set; }
        public virtual DbSet<TblVistoriaTipoVestigio> TblVistoriaTipoVestigio { get; set; }
        public virtual DbSet<TblVistoriaVestigio> TblVistoriaVestigio { get; set; }
        public virtual DbSet<TipoCobranca> TipoCobranca { get; set; }
        public virtual DbSet<TipoServicoPessoaValor> TipoServicoPessoaValor { get; set; }
        public virtual DbSet<TipoServicoSegmentoValor> TipoServicoSegmentoValor { get; set; }
        public virtual DbSet<TipoVeiculo> TipoVeiculo { get; set; }
        public virtual DbSet<TipoVestigio> TipoVestigio { get; set; }
        public virtual DbSet<UsuarioModuloSistema> UsuarioModuloSistema { get; set; }
        public virtual DbSet<Vestigio> Vestigio { get; set; }
        public virtual DbSet<VistoriaConsultaVeicular> VistoriaConsultaVeicular { get; set; }
        public virtual DbSet<VistoriaFoto> VistoriaFoto { get; set; }
        public virtual DbSet<VistoriaFotoAvaria> VistoriaFotoAvaria { get; set; }
        public virtual DbSet<VistoriaLogAcao> VistoriaLogAcao { get; set; }
        public virtual DbSet<VistoriaVestigio> VistoriaVestigio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server=sqldesenv.allrisksolucoes.com.br;Database=Vistoria20;User Id=vistoria;Password=AllVis19.;");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agenda>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaIdFranqueador, e.EmpresaId, e.PessoaId, e.DataDesejadaInicio });

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.DataDesejadaInicio)
                    .HasColumnName("DataDesejada_Inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgendaId).ValueGeneratedOnAdd();

                entity.Property(e => e.Chassi)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.DataAgendada).HasColumnType("datetime");

                entity.Property(e => e.DataDesejadaFim)
                    .HasColumnName("DataDesejada_Fim")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumeroSinistro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Placa)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdRealizado).HasColumnName("UsuarioId_Realizado");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.Veiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpresaConsultaVeicular>(entity =>
            {
                entity.HasKey(e => e.NomeRazaoSocial);

                entity.Property(e => e.NomeRazaoSocial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpresaConsultaVeicularId).ValueGeneratedOnAdd();

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<EmpresaConsultaVeicularParametroEntrada>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaConsultaVeicularId, e.ParametroDeEntrada });

                entity.ToTable("EmpresaConsultaVeicular_ParametroEntrada");

                entity.Property(e => e.ParametroDeEntrada)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpresaConsultaVeicularChaveId)
                    .HasColumnName("EmpresaConsultaVeicular_ChaveId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<EmpresaConsultaVeicularValorDeEntrada>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaEmpresaConsultaVeicularId, e.EmpresaConsultaVeicularChaveId, e.ValorDeEntrada });

                entity.ToTable("EmpresaConsultaVeicular_ValorDeEntrada");

                entity.Property(e => e.EmpresaEmpresaConsultaVeicularId).HasColumnName("Empresa_EmpresaConsultaVeicularId");

                entity.Property(e => e.EmpresaConsultaVeicularChaveId).HasColumnName("EmpresaConsultaVeicular_ChaveId");

                entity.Property(e => e.ValorDeEntrada)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpresaConsultaVeicularValorId)
                    .HasColumnName("EmpresaConsultaVeicular_ValorId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<EmpresaEmpresaConsultaVeicular>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaId, e.EmpresaConsultaVeicularId });

                entity.ToTable("Empresa_EmpresaConsultaVeicular");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpresaEmpresaConsultaVeicularId)
                    .HasColumnName("Empresa_EmpresaConsultaVeicularId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<EmpresaEndereco>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaId, e.EnderecoId });

                entity.ToTable("Empresa_Endereco");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpresaEnderecoId)
                    .HasColumnName("Empresa_EnderecoId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<EmpresaSetupFoto>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaIdFranqueador, e.EmpresaId, e.SetupFotoId });

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpresaSetupFotoId).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<GrupoVestigio>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaId, e.EmpresaIdFranqueador, e.GrupoVestigio1 });

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.GrupoVestigio1)
                    .HasColumnName("GrupoVestigio")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrupoVestigioId).ValueGeneratedOnAdd();

                entity.Property(e => e.OrdemPrint).HasColumnName("Ordem_Print");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(e => e.CpfCnpj);

                entity.Property(e => e.CpfCnpj)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoEconomicoPessoaId).HasColumnName("GrupoEconomico_PessoaId");
            });

            modelBuilder.Entity<PessoaEndereco>(entity =>
            {
                entity.HasKey(e => new { e.PessoaId, e.EnderecoId });

                entity.ToTable("Pessoa_Endereco");

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PessoaEnderecoId)
                    .HasColumnName("Pessoa_EnderecoId")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PessoaTipoServico>(entity =>
            {
                entity.HasKey(e => new { e.PessoaId, e.TipoServicoId });

                entity.ToTable("Pessoa_TipoServico");

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.PessoaTipoServicoId)
                    .HasColumnName("Pessoa_TipoServicoId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.Valor).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<SetupFoto>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaIdFranqueador, e.TipoVeiculoId, e.Descricao });

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetupFotoId).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<StatusAgenda>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaIdFranqueador, e.Descricao });

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusAgendaId).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<StatusVestigio>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaIdFranqueador, e.EmpresaId, e.TipoServicoId, e.CorHexa });

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.CorHexa)
                    .HasColumnName("Cor_Hexa")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusVestigio1)
                    .IsRequired()
                    .HasColumnName("StatusVestigio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusVestigioId).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<TblCliente>(entity =>
            {
                entity.HasKey(e => e.CnpjCpf);

                entity.ToTable("tblCliente");

                entity.Property(e => e.CnpjCpf)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Segmento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CnpjCpfNavigation)
                    .WithOne(p => p.TblCliente)
                    .HasForeignKey<TblCliente>(d => d.CnpjCpf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPessoa_tblCliente");

                entity.HasOne(d => d.SegmentoNavigation)
                    .WithMany(p => p.TblCliente)
                    .HasForeignKey(d => d.Segmento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSegmento_tblCliente");
            });

            modelBuilder.Entity<TblControle>(entity =>
            {
                entity.HasKey(e => e.Versao);

                entity.ToTable("tblControle");

                entity.Property(e => e.Versao)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DataLiberacao).HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEndereco>(entity =>
            {
                entity.HasKey(e => new { e.Cnpj, e.TipoEndereco });

                entity.ToTable("tblEndereco");

                entity.HasIndex(e => e.Cnpj)
                    .HasName("IDX_tblEndereco_Cnpj");

                entity.HasIndex(e => e.EnderecoId)
                    .HasName("AK_tblEndereco_EnderecoId")
                    .IsUnique();

                entity.HasIndex(e => e.TipoEndereco)
                    .HasName("IDX_tblEndereco_TipoEndereco");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEndereco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EhPrincipal)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasColumnName("UF")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjNavigation)
                    .WithMany(p => p.TblEndereco)
                    .HasForeignKey(d => d.Cnpj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPessoaJuridica_tblEndereco");

                entity.HasOne(d => d.TipoEnderecoNavigation)
                    .WithMany(p => p.TblEndereco)
                    .HasForeignKey(d => d.TipoEndereco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblTipoEndereco_tblEndereco");

                entity.HasOne(d => d.UfNavigation)
                    .WithMany(p => p.TblEndereco)
                    .HasForeignKey(d => d.Uf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblUF_tblEndereco");
            });

            modelBuilder.Entity<TblFranqueador>(entity =>
            {
                entity.HasKey(e => e.CnpjFranqueador);

                entity.ToTable("tblFranqueador");

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CorHexa)
                    .HasColumnName("Cor_Hexa")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogoCaminhoFisico)
                    .HasColumnName("Logo_CaminhoFisico")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjFranqueadorNavigation)
                    .WithOne(p => p.TblFranqueador)
                    .HasForeignKey<TblFranqueador>(d => d.CnpjFranqueador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPessoaJuridica_tblFranqueador");
            });

            modelBuilder.Entity<TblFranqueadorGrupoVestigio>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.GrupoVestigio });

                entity.ToTable("tblFranqueadorGrupoVestigio");

                entity.HasIndex(e => e.GrupoVestigioId)
                    .HasName("AK_tblFranqueadorGrupoVestigio_GrupoVestigioId")
                    .IsUnique();

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrupoVestigioId).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjFranqueadorNavigation)
                    .WithMany(p => p.TblFranqueadorGrupoVestigio)
                    .HasForeignKey(d => d.CnpjFranqueador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueador_tblFranqueadorGrupoVestigio");
            });

            modelBuilder.Entity<TblFranqueadorObjetoFoto>(entity =>
            {
                entity.HasKey(e => new { e.Objeto, e.CnpjFranqueador });

                entity.ToTable("tblFranqueadorObjetoFoto");

                entity.Property(e => e.Objeto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjFranqueadorNavigation)
                    .WithMany(p => p.TblFranqueadorObjetoFoto)
                    .HasForeignKey(d => d.CnpjFranqueador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueador_tblFranqueadorObjetoFoto");

                entity.HasOne(d => d.ObjetoNavigation)
                    .WithMany(p => p.TblFranqueadorObjetoFoto)
                    .HasForeignKey(d => d.Objeto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblObjetoFoto_tblFranqueadorObjetoFoto");
            });

            modelBuilder.Entity<TblFranqueadorSegmento>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.Segmento });

                entity.ToTable("tblFranqueadorSegmento");

                entity.HasIndex(e => e.CnpjFranqueador)
                    .HasName("IDX_tblFranqueadorSegmento_CnpjFranqueador");

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Segmento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjFranqueadorNavigation)
                    .WithMany(p => p.TblFranqueadorSegmento)
                    .HasForeignKey(d => d.CnpjFranqueador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueador_tblFranqueadorSegmento");

                entity.HasOne(d => d.SegmentoNavigation)
                    .WithMany(p => p.TblFranqueadorSegmento)
                    .HasForeignKey(d => d.Segmento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSegmento_tblFranqueadorSegmento");
            });

            modelBuilder.Entity<TblFranqueadorStatusVestigio>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.TipoServico, e.StatusVestigioFranqueador });

                entity.ToTable("tblFranqueadorStatusVestigio");

                entity.HasIndex(e => new { e.CnpjFranqueador, e.TipoServico, e.CorHexa })
                    .HasName("AK_tblFranqueadorStatusVestigio_CnpjFranqueador")
                    .IsUnique();

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusVestigioFranqueador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorHexa)
                    .IsRequired()
                    .HasColumnName("Cor_Hexa")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblFranqueadorTipoServico)
                    .WithMany(p => p.TblFranqueadorStatusVestigio)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoServico_tblFranqueadorStatusVestigio");
            });

            modelBuilder.Entity<TblFranqueadorTipoServico>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.TipoServico });

                entity.ToTable("tblFranqueadorTipoServico");

                entity.HasIndex(e => e.CnpjFranqueador)
                    .HasName("IDX_tblFranqueadorTipoServico_CnpjFranqueador");

                entity.HasIndex(e => e.TipoServicoId)
                    .HasName("AK_tblFranqueadorTipoServico_TipoServicoId")
                    .IsUnique();

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjFranqueadorNavigation)
                    .WithMany(p => p.TblFranqueadorTipoServico)
                    .HasForeignKey(d => d.CnpjFranqueador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueador_tblFranqueadorTipoServico");
            });

            modelBuilder.Entity<TblFranqueadorTipoServicoVestigio>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.TipoServico, e.GrupoVestigio, e.TipoVestigio });

                entity.ToTable("tblFranqueadorTipoServicoVestigio");

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblFranqueadorTipoServico)
                    .WithMany(p => p.TblFranqueadorTipoServicoVestigio)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoServico_tblFranqueadorTipoServicoVestigio");

                entity.HasOne(d => d.TblFranqueadorTipoVestigio)
                    .WithMany(p => p.TblFranqueadorTipoServicoVestigio)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.GrupoVestigio, d.TipoVestigio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoVestigio_tblFranqueadorTipoServicoVestigio");
            });

            modelBuilder.Entity<TblFranqueadorTipoVeiculo>(entity =>
            {
                entity.HasKey(e => new { e.TipoVeiculo, e.CnpjFranqueador });

                entity.ToTable("tblFranqueadorTipoVeiculo");

                entity.Property(e => e.TipoVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjFranqueadorNavigation)
                    .WithMany(p => p.TblFranqueadorTipoVeiculo)
                    .HasForeignKey(d => d.CnpjFranqueador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueador_tblFranqueadorTipoVeiculo");

                entity.HasOne(d => d.TipoVeiculoNavigation)
                    .WithMany(p => p.TblFranqueadorTipoVeiculo)
                    .HasForeignKey(d => d.TipoVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblTipoVeiculo_tblFranqueadorTipoVeiculo");
            });

            modelBuilder.Entity<TblFranqueadorTipoVeiculoVestigio>(entity =>
            {
                entity.HasKey(e => new { e.TipoVeiculo, e.CnpjFranqueador, e.GrupoVestigio, e.TipoVestigio });

                entity.ToTable("tblFranqueadorTipoVeiculoVestigio");

                entity.Property(e => e.TipoVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblFranqueadorTipoVeiculo)
                    .WithMany(p => p.TblFranqueadorTipoVeiculoVestigio)
                    .HasForeignKey(d => new { d.TipoVeiculo, d.CnpjFranqueador })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoVeiculo_tblFranqueadorTipoVeiculoVestigio");

                entity.HasOne(d => d.TblFranqueadorTipoVestigio)
                    .WithMany(p => p.TblFranqueadorTipoVeiculoVestigio)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.GrupoVestigio, d.TipoVestigio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoVestigio_tblFranqueadorTipoVeiculoVestigio");
            });

            modelBuilder.Entity<TblFranqueadorTipoVeiculoVestigioServico>(entity =>
            {
                entity.HasKey(e => new { e.TipoVeiculo, e.CnpjFranqueador, e.GrupoVestigio, e.TipoVestigio, e.TipoServico });

                entity.ToTable("tblFranqueadorTipoVeiculoVestigioServico");

                entity.Property(e => e.TipoVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblFranqueadorTipoServicoVestigio)
                    .WithMany(p => p.TblFranqueadorTipoVeiculoVestigioServico)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.GrupoVestigio, d.TipoVestigio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoServicoVestigio_tblFranqueadorTipoVeiculoVestigioServico");

                entity.HasOne(d => d.TblFranqueadorTipoVeiculoVestigio)
                    .WithMany(p => p.TblFranqueadorTipoVeiculoVestigioServico)
                    .HasForeignKey(d => new { d.TipoVeiculo, d.CnpjFranqueador, d.GrupoVestigio, d.TipoVestigio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoVeiculoVestigio_tblFranqueadorTipoVeiculoVestigioServico");
            });

            modelBuilder.Entity<TblFranqueadorTipoVestigio>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.GrupoVestigio, e.TipoVestigio });

                entity.ToTable("tblFranqueadorTipoVestigio");

                entity.HasIndex(e => new { e.GrupoVestigioId, e.TipoVestigioId })
                    .HasName("AK_tblFranqueadorTipoVestigio_GrupoVestigioId")
                    .IsUnique();

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Abreviacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipoVestigioId).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblFranqueadorGrupoVestigio)
                    .WithMany(p => p.TblFranqueadorTipoVestigio)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.GrupoVestigio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorGrupoVestigio_tblFranqueadorTipoVestigio");
            });

            modelBuilder.Entity<TblFranqueadorVestigio>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.TipoVeiculo, e.TipoServico, e.GrupoVestigio, e.TipoVestigio, e.StatusVestigioFranqueador, e.Vestigio });

                entity.ToTable("tblFranqueadorVestigio");

                entity.HasIndex(e => e.VestigioId)
                    .HasName("AK_tblFranqueadorVestigio_VestigioId")
                    .IsUnique();

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusVestigioFranqueador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vestigio)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.VestigioId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.TblFranqueadorStatusVestigio)
                    .WithMany(p => p.TblFranqueadorVestigio)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.StatusVestigioFranqueador })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorStatusVestigio_tblFranqueadorVestigio");

                entity.HasOne(d => d.TblFranqueadorTipoVeiculoVestigioServico)
                    .WithMany(p => p.TblFranqueadorVestigio)
                    .HasForeignKey(d => new { d.TipoVeiculo, d.CnpjFranqueador, d.GrupoVestigio, d.TipoVestigio, d.TipoServico })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoVeiculoVestigioServico_tblFranqueadorVestigio");
            });

            modelBuilder.Entity<TblGrupoEconomico>(entity =>
            {
                entity.HasKey(e => new { e.CnpjVistoria, e.GrupoEconomico });

                entity.ToTable("tblGrupoEconomico");

                entity.HasIndex(e => e.CnpjVistoria)
                    .HasName("IDX_tblGrupoEconomico_CnpjVistoria");

                entity.HasIndex(e => e.GrupoEconomicoPessoaId)
                    .HasName("AK_tblGrupoEconomico_GrupoEconomico_PessoaId")
                    .IsUnique();

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoEconomico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrupoEconomicoPessoaId).HasColumnName("GrupoEconomico_PessoaId");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjVistoriaNavigation)
                    .WithMany(p => p.TblGrupoEconomico)
                    .HasForeignKey(d => d.CnpjVistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoria_tblGrupoEconomico");
            });

            modelBuilder.Entity<TblLaudo>(entity =>
            {
                entity.HasKey(e => e.LaudoId);

                entity.ToTable("tblLaudo");

                entity.Property(e => e.AnoFab)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnoMod)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Chassi)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjCpf)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjFranqueador)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Combustivel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DthConferenteFinalizado)
                    .HasColumnName("DTH_ConferenteFinalizado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthConferenteInciado)
                    .HasColumnName("DTH_ConferenteInciado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthFinalizado)
                    .HasColumnName("DTH_Finalizado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthSolicitado)
                    .HasColumnName("DTH_Solicitado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthVistoriadorFinalizado)
                    .HasColumnName("DTH_VistoriadorFinalizado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthVistoriadorIniciado)
                    .HasColumnName("DTH_VistoriadorIniciado")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.Hodometro)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MunicipioDaPlaca)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCambio)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCrlv)
                    .HasColumnName("NumeroCRLV")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroLacre)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroMotor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Placa)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Renavam)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Segmento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusVestigioFranqueador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusVestigioVistoria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVeiculo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UfDaPlaca)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioIdConferente).HasColumnName("UsuarioId_Conferente");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdFinalizador).HasColumnName("UsuarioId_Finalizador");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.UsuarioIdVistoriador).HasColumnName("UsuarioId_Vistoriador");

                entity.Property(e => e.ValorDesconto).HasColumnType("smallmoney");

                entity.Property(e => e.ValorServicoCliente).HasColumnType("smallmoney");

                entity.Property(e => e.ValorServicoSegmento).HasColumnType("smallmoney");

                entity.HasOne(d => d.CnpjCpfNavigation)
                    .WithMany(p => p.TblLaudo)
                    .HasForeignKey(d => d.CnpjCpf)
                    .HasConstraintName("tblCliente_tblLaudo");

                entity.HasOne(d => d.SegmentoNavigation)
                    .WithMany(p => p.TblLaudo)
                    .HasForeignKey(d => d.Segmento)
                    .HasConstraintName("tblSegmento_tblLaudo");

                entity.HasOne(d => d.TblFranqueadorTipoVeiculo)
                    .WithMany(p => p.TblLaudo)
                    .HasForeignKey(d => new { d.TipoVeiculo, d.CnpjFranqueador })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoVeiculo_tblLaudo");

                entity.HasOne(d => d.TblVistoriaTipoServico)
                    .WithMany(p => p.TblLaudo)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.CnpjVistoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaTipoServico_tblLaudo");

                entity.HasOne(d => d.TblFranqueadorStatusVestigio)
                    .WithMany(p => p.TblLaudo)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.StatusVestigioFranqueador })
                    .HasConstraintName("tblFranqueadorStatusVestigio_tblLaudo");

                entity.HasOne(d => d.TblVistoriaStatusVestigio)
                    .WithMany(p => p.TblLaudo)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.CnpjVistoria, d.StatusVestigioVistoria })
                    .HasConstraintName("tblVistoriaStatusVestigio_tblLaudo");
            });

            modelBuilder.Entity<TblLaudoVestigio>(entity =>
            {
                entity.HasKey(e => e.LaudoId);

                entity.ToTable("tblLaudoVestigio");

                entity.Property(e => e.LaudoId).ValueGeneratedNever();

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrupoVestigio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusVestigioFranqueador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusVestigioVistoria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVestigio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.Vestigio)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Laudo)
                    .WithOne(p => p.TblLaudoVestigio)
                    .HasForeignKey<TblLaudoVestigio>(d => d.LaudoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblLaudo_tblLaudoVestigio");
            });

            modelBuilder.Entity<TblModuloSistema>(entity =>
            {
                entity.HasKey(e => e.RefHtmlItemPai);

                entity.ToTable("tblModuloSistema");

                entity.HasIndex(e => e.ModuloSistemaId)
                    .HasName("AK_tblModuloSistema_ModuloSistemaId")
                    .IsUnique();

                entity.Property(e => e.RefHtmlItemPai)
                    .HasColumnName("RefHtml_ItemPai")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblModuloSistemaFilho>(entity =>
            {
                entity.HasKey(e => new { e.RefHtmlItemPai, e.RefHtmlItemFilho });

                entity.ToTable("tblModuloSistemaFilho");

                entity.Property(e => e.RefHtmlItemPai)
                    .HasColumnName("RefHtml_ItemPai")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefHtmlItemFilho)
                    .HasColumnName("RefHtml_ItemFilho")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.RefHtmlItemPaiNavigation)
                    .WithMany(p => p.TblModuloSistemaFilho)
                    .HasForeignKey(d => d.RefHtmlItemPai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblModuloSistema_tblModuloSistemaFilho");
            });

            modelBuilder.Entity<TblObjetoFoto>(entity =>
            {
                entity.HasKey(e => e.Objeto);

                entity.ToTable("tblObjetoFoto");

                entity.Property(e => e.Objeto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPerfil>(entity =>
            {
                entity.HasKey(e => e.Perfil);

                entity.ToTable("tblPerfil");

                entity.HasIndex(e => e.PerfilId)
                    .HasName("AK_tblPerfil_PerfilId")
                    .IsUnique();

                entity.Property(e => e.Perfil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<TblPerfilModulo>(entity =>
            {
                entity.HasKey(e => new { e.RefHtmlItemPai, e.RefHtmlItemFilho, e.Perfil });

                entity.ToTable("tblPerfilModulo");

                entity.Property(e => e.RefHtmlItemPai)
                    .HasColumnName("RefHtml_ItemPai")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefHtmlItemFilho)
                    .HasColumnName("RefHtml_ItemFilho")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Perfil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.PerfilNavigation)
                    .WithMany(p => p.TblPerfilModulo)
                    .HasForeignKey(d => d.Perfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPerfil_tblPerfilModulo");

                entity.HasOne(d => d.RefHtmlItem)
                    .WithMany(p => p.TblPerfilModulo)
                    .HasForeignKey(d => new { d.RefHtmlItemPai, d.RefHtmlItemFilho })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblModuloSistemaFilho_tblPerfilModulo");
            });

            modelBuilder.Entity<TblPessoa>(entity =>
            {
                entity.HasKey(e => e.CnpjCpf);

                entity.ToTable("tblPessoa");

                entity.Property(e => e.CnpjCpf)
                    .HasMaxLength(19)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPessoaFisica>(entity =>
            {
                entity.HasKey(e => e.Cpf);

                entity.ToTable("tblPessoaFisica");

                entity.HasIndex(e => e.Email)
                    .HasName("AK_tblPessoaFisica_Email")
                    .IsUnique();

                entity.HasIndex(e => e.PessoaId)
                    .HasName("AK_tblPessoaFisica_PessoaId")
                    .IsUnique();

                entity.Property(e => e.Cpf)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Abreviacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cidade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Logradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CpfNavigation)
                    .WithOne(p => p.TblPessoaFisica)
                    .HasForeignKey<TblPessoaFisica>(d => d.Cpf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPessoa_tblPessoaFisica");
            });

            modelBuilder.Entity<TblPessoaJuridica>(entity =>
            {
                entity.HasKey(e => e.Cnpj);

                entity.ToTable("tblPessoaJuridica");

                entity.HasIndex(e => e.EmpresaId)
                    .HasName("AK_tblPessoaJuridica_EmpresaId")
                    .IsUnique();

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Abreviacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ie)
                    .IsRequired()
                    .HasColumnName("IE")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjNavigation)
                    .WithOne(p => p.TblPessoaJuridica)
                    .HasForeignKey<TblPessoaJuridica>(d => d.Cnpj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPessoa_tblPessoaJuridica");
            });

            modelBuilder.Entity<TblProvedor>(entity =>
            {
                entity.HasKey(e => e.CnpjProvedor);

                entity.ToTable("tblProvedor");

                entity.Property(e => e.CnpjProvedor)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CnpjProvedorNavigation)
                    .WithOne(p => p.TblProvedor)
                    .HasForeignKey<TblProvedor>(d => d.CnpjProvedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPessoaJuridica_tblProvedor");
            });

            modelBuilder.Entity<TblProvedorParametro>(entity =>
            {
                entity.HasKey(e => new { e.CnpjProvedor, e.ParametroDeEntrada });

                entity.ToTable("tblProvedorParametro");

                entity.Property(e => e.CnpjProvedor)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.ParametroDeEntrada)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CnpjProvedorNavigation)
                    .WithMany(p => p.TblProvedorParametro)
                    .HasForeignKey(d => d.CnpjProvedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblProvedor_tblProvedorParametro");
            });

            modelBuilder.Entity<TblRelacionamento>(entity =>
            {
                entity.HasKey(e => e.Relacionamento);

                entity.ToTable("tblRelacionamento");

                entity.HasIndex(e => e.PessoaTipoRelacionamentoId)
                    .HasName("AK_tblRelacionamento_PessoaTipoRelacionamentoId")
                    .IsUnique();

                entity.Property(e => e.Relacionamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSegmento>(entity =>
            {
                entity.HasKey(e => e.Segmento);

                entity.ToTable("tblSegmento");

                entity.HasIndex(e => e.PessoaSegmentoId)
                    .HasName("AK_tblSegmento_PessoaSegmentoId")
                    .IsUnique();

                entity.Property(e => e.Segmento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSetupFoto>(entity =>
            {
                entity.HasKey(e => new { e.TipoVeiculo, e.CnpjFranqueador, e.Objeto });

                entity.ToTable("tblSetupFoto");

                entity.HasIndex(e => e.SetupFotoId)
                    .HasName("AK_tblSetupFoto_SetupFotoId")
                    .IsUnique();

                entity.Property(e => e.TipoVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Objeto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetupFotoId).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblFranqueadorObjetoFoto)
                    .WithMany(p => p.TblSetupFoto)
                    .HasForeignKey(d => new { d.Objeto, d.CnpjFranqueador })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorObjetoFoto_tblSetupFoto");

                entity.HasOne(d => d.TblFranqueadorTipoVeiculo)
                    .WithMany(p => p.TblSetupFoto)
                    .HasForeignKey(d => new { d.TipoVeiculo, d.CnpjFranqueador })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoVeiculo_tblSetupFoto");
            });

            modelBuilder.Entity<TblTipoEndereco>(entity =>
            {
                entity.HasKey(e => e.TipoEndereco);

                entity.ToTable("tblTipoEndereco");

                entity.HasIndex(e => e.TipoEnderecoId)
                    .HasName("AK_tblTipoEndereco_TipoEnderecoId")
                    .IsUnique();

                entity.Property(e => e.TipoEndereco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblTipoVeiculo>(entity =>
            {
                entity.HasKey(e => e.TipoVeiculo);

                entity.ToTable("tblTipoVeiculo");

                entity.Property(e => e.TipoVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblUf>(entity =>
            {
                entity.HasKey(e => e.Uf);

                entity.ToTable("tblUF");

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblUsuario>(entity =>
            {
                entity.HasKey(e => e.UsuarioId);

                entity.ToTable("tblUsuario");

                entity.HasIndex(e => e.CnpjFranqueador)
                    .HasName("IDX_tblUsuario_CnpjFranqueador");

                entity.HasIndex(e => e.CnpjResponsavel)
                    .HasName("IDX_tblUsuario_CnpjResponsavel");

                entity.HasIndex(e => e.Cpf)
                    .HasName("IDX_tblUsuario_Cpf");

                entity.HasIndex(e => e.Perfil)
                    .HasName("IDX_tblUsuario_Perfil");

                entity.HasIndex(e => new { e.CnpjVistoria, e.CnpjFranqueador })
                    .HasName("IDX_tblUsuario_CnpjVistoria");

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjResponsavel)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.Perfil)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjFranqueadorNavigation)
                    .WithMany(p => p.TblUsuario)
                    .HasForeignKey(d => d.CnpjFranqueador)
                    .HasConstraintName("tblFranqueador_tblUsuario");

                entity.HasOne(d => d.CnpjResponsavelNavigation)
                    .WithMany(p => p.TblUsuario)
                    .HasForeignKey(d => d.CnpjResponsavel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPessoaJuridica_tblUsuario");

                entity.HasOne(d => d.CnpjVistoriaNavigation)
                    .WithMany(p => p.TblUsuario)
                    .HasForeignKey(d => d.CnpjVistoria)
                    .HasConstraintName("tblVistoria_tblUsuario");

                entity.HasOne(d => d.CpfNavigation)
                    .WithMany(p => p.TblUsuario)
                    .HasForeignKey(d => d.Cpf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPessoaFisica_tblUsuario");

                entity.HasOne(d => d.PerfilNavigation)
                    .WithMany(p => p.TblUsuario)
                    .HasForeignKey(d => d.Perfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPerfil_tblUsuario");
            });

            modelBuilder.Entity<TblUsuarioModulo>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioId, e.RefHtmlItemPai, e.RefHtmlItemFilho });

                entity.ToTable("tblUsuarioModulo");

                entity.HasIndex(e => e.UsuarioModuloSistemaId)
                    .HasName("AK_tblUsuarioModulo_Usuario_ModuloSistemaId")
                    .IsUnique();

                entity.Property(e => e.RefHtmlItemPai)
                    .HasColumnName("RefHtml_ItemPai")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefHtmlItemFilho)
                    .HasColumnName("RefHtml_ItemFilho")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.UsuarioModuloSistemaId)
                    .HasColumnName("Usuario_ModuloSistemaId")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.TblUsuarioModulo)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblUsuario_tblUsuarioModulo");

                entity.HasOne(d => d.RefHtmlItem)
                    .WithMany(p => p.TblUsuarioModulo)
                    .HasForeignKey(d => new { d.RefHtmlItemPai, d.RefHtmlItemFilho })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblModuloSistemaFilho_tblUsuarioModulo");
            });

            modelBuilder.Entity<TblVistoria>(entity =>
            {
                entity.HasKey(e => e.CnpjVistoria);

                entity.ToTable("tblVistoria");

                entity.HasIndex(e => e.CnpjFranqueador)
                    .HasName("IDX_tblVistoria_CnpjFranqueador");

                entity.HasIndex(e => e.CnpjVistoria)
                    .HasName("IDX_tblVistoria_CnpjVistoria");

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjFranqueador)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.ConsideracaoFinalImpressao)
                    .HasColumnName("ConsideracaoFinal_Impressao")
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjFranqueadorNavigation)
                    .WithMany(p => p.TblVistoria)
                    .HasForeignKey(d => d.CnpjFranqueador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueador_tblVistoria");

                entity.HasOne(d => d.CnpjVistoriaNavigation)
                    .WithOne(p => p.TblVistoria)
                    .HasForeignKey<TblVistoria>(d => d.CnpjVistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPessoaJuridica_tblVistoria");
            });

            modelBuilder.Entity<TblVistoriaGrupoVestigio>(entity =>
            {
                entity.HasKey(e => new { e.CnpjVistoria, e.GrupoVestigio });

                entity.ToTable("tblVistoriaGrupoVestigio");

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjVistoriaNavigation)
                    .WithMany(p => p.TblVistoriaGrupoVestigio)
                    .HasForeignKey(d => d.CnpjVistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoria_tblVistoriaGrupoVestigio");
            });

            modelBuilder.Entity<TblVistoriaProvedor>(entity =>
            {
                entity.HasKey(e => new { e.CnpjProvedor, e.CnpjVistoria });

                entity.ToTable("tblVistoriaProvedor");

                entity.Property(e => e.CnpjProvedor)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjProvedorNavigation)
                    .WithMany(p => p.TblVistoriaProvedor)
                    .HasForeignKey(d => d.CnpjProvedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblProvedor_tblVistoriaProvedor");

                entity.HasOne(d => d.CnpjVistoriaNavigation)
                    .WithMany(p => p.TblVistoriaProvedor)
                    .HasForeignKey(d => d.CnpjVistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoria_tblVistoriaProvedor");
            });

            modelBuilder.Entity<TblVistoriaProvedorParametro>(entity =>
            {
                entity.HasKey(e => new { e.CnpjProvedor, e.CnpjVistoria, e.ParametroDeEntrada });

                entity.ToTable("tblVistoriaProvedorParametro");

                entity.Property(e => e.CnpjProvedor)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.ParametroDeEntrada)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.ValorDeEntrada)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cnpj)
                    .WithMany(p => p.TblVistoriaProvedorParametro)
                    .HasForeignKey(d => new { d.CnpjProvedor, d.CnpjVistoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaProvedor_tblVistoriaProvedorParametro");

                entity.HasOne(d => d.TblProvedorParametro)
                    .WithMany(p => p.TblVistoriaProvedorParametro)
                    .HasForeignKey(d => new { d.CnpjProvedor, d.ParametroDeEntrada })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblProvedorParametro_tblVistoriaProvedorParametro");
            });

            modelBuilder.Entity<TblVistoriaSegmento>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.Segmento, e.CnpjVistoria });

                entity.ToTable("tblVistoriaSegmento");

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Segmento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjVistoriaNavigation)
                    .WithMany(p => p.TblVistoriaSegmento)
                    .HasForeignKey(d => d.CnpjVistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoria_tblVistoriaSegmento");

                entity.HasOne(d => d.TblFranqueadorSegmento)
                    .WithMany(p => p.TblVistoriaSegmento)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.Segmento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorSegmento_tblVistoriaSegmento");
            });

            modelBuilder.Entity<TblVistoriaSetupFoto>(entity =>
            {
                entity.HasKey(e => new { e.TipoVeiculo, e.CnpjFranqueador, e.Objeto, e.CnpjVistoria });

                entity.ToTable("tblVistoriaSetupFoto");

                entity.HasIndex(e => e.EmpresaSetupFotoId)
                    .HasName("AK_tblVistoriaSetupFoto_EmpresaSetupFotoId")
                    .IsUnique();

                entity.Property(e => e.TipoVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Objeto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.EmpresaSetupFotoId).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjVistoriaNavigation)
                    .WithMany(p => p.TblVistoriaSetupFoto)
                    .HasForeignKey(d => d.CnpjVistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoria_tblVistoriaSetupFoto");

                entity.HasOne(d => d.TblSetupFoto)
                    .WithMany(p => p.TblVistoriaSetupFoto)
                    .HasForeignKey(d => new { d.TipoVeiculo, d.CnpjFranqueador, d.Objeto })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSetupFoto_tblVistoriaSetupFoto");
            });

            modelBuilder.Entity<TblVistoriaStatusVestigio>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.TipoServico, e.CnpjVistoria, e.StatusVestigioVistoria });

                entity.ToTable("tblVistoriaStatusVestigio");

                entity.HasIndex(e => e.StatusVestigioId)
                    .HasName("AK_tblVistoriaStatusVestigio_StatusVestigioId")
                    .IsUnique();

                entity.HasIndex(e => new { e.CnpjFranqueador, e.TipoServico, e.CnpjVistoria, e.CorHexa })
                    .HasName("AK_tblVistoriaStatusVestigio_CnpjFranqueador")
                    .IsUnique();

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.StatusVestigioVistoria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorHexa)
                    .IsRequired()
                    .HasColumnName("Cor_Hexa")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusVestigioId).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblVistoriaTipoServico)
                    .WithMany(p => p.TblVistoriaStatusVestigio)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.CnpjVistoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaTipoServico_tblVistoriaStatusVestigio");
            });

            modelBuilder.Entity<TblVistoriaTipoServico>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.TipoServico, e.CnpjVistoria });

                entity.ToTable("tblVistoriaTipoServico");

                entity.HasIndex(e => e.CnpjVistoria)
                    .HasName("IDX_tblVistoriaTipoServico_CnpjVistoria");

                entity.HasIndex(e => e.TipoServicoId)
                    .HasName("AK_tblVistoriaTipoServico_TipoServicoId");

                entity.HasIndex(e => new { e.CnpjFranqueador, e.TipoServico })
                    .HasName("IDX_tblVistoriaTipoServico_CnpjFranqueadorTipoServico");

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.CnpjVistoriaNavigation)
                    .WithMany(p => p.TblVistoriaTipoServico)
                    .HasForeignKey(d => d.CnpjVistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoria_tblVistoriaTipoServico");

                entity.HasOne(d => d.TblFranqueadorTipoServico)
                    .WithMany(p => p.TblVistoriaTipoServico)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoServico_tblVistoriaTipoServico");
            });

            modelBuilder.Entity<TblVistoriaTipoServicoCliente>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.TipoServico, e.CnpjVistoria, e.CnpjCpf });

                entity.ToTable("tblVistoriaTipoServicoCliente");

                entity.HasIndex(e => e.TipoServicoPessoaValorId)
                    .HasName("AK_tblVistoriaTipoServicoCliente_TipoServico_Pessoa_ValorId")
                    .IsUnique();

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjCpf)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipoServicoPessoaValorId)
                    .HasColumnName("TipoServico_Pessoa_ValorId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.ValorServicoCliente).HasColumnType("smallmoney");

                entity.Property(e => e.ValorServicoClienteCusto).HasColumnType("smallmoney");

                entity.Property(e => e.ValorServicoClienteRetorno).HasColumnType("smallmoney");

                entity.HasOne(d => d.CnpjCpfNavigation)
                    .WithMany(p => p.TblVistoriaTipoServicoCliente)
                    .HasForeignKey(d => d.CnpjCpf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCliente_tblVistoriaTipoServicoCliente");

                entity.HasOne(d => d.TblVistoriaTipoServico)
                    .WithMany(p => p.TblVistoriaTipoServicoCliente)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.CnpjVistoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaTipoServico_tblVistoriaTipoServicoCliente");
            });

            modelBuilder.Entity<TblVistoriaTipoServicoSegmento>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.TipoServico, e.CnpjVistoria, e.Segmento });

                entity.ToTable("tblVistoriaTipoServicoSegmento");

                entity.HasIndex(e => e.TipoServicoSegmentoValorId)
                    .HasName("AK_tblVistoriaTipoServicoSegmento_TipoServico_Segmento_ValorId")
                    .IsUnique();

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Segmento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipoServicoSegmentoValorId)
                    .HasColumnName("TipoServico_Segmento_ValorId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.ValorServicoSegmento).HasColumnType("smallmoney");

                entity.Property(e => e.ValorServicoSegmentoCusto).HasColumnType("smallmoney");

                entity.Property(e => e.ValorServicoSegmentoRetorno).HasColumnType("smallmoney");

                entity.HasOne(d => d.TblVistoriaSegmento)
                    .WithMany(p => p.TblVistoriaTipoServicoSegmento)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.Segmento, d.CnpjVistoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaSegmento_tblVistoriaTipoServicoSegmento");

                entity.HasOne(d => d.TblVistoriaTipoServico)
                    .WithMany(p => p.TblVistoriaTipoServicoSegmento)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.CnpjVistoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaTipoServico_tblVistoriaTipoServicoSegmento");
            });

            modelBuilder.Entity<TblVistoriaTipoServicoVestigio>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.TipoServico, e.CnpjVistoria, e.GrupoVestigio, e.TipoVestigio });

                entity.ToTable("tblVistoriaTipoServicoVestigio");

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblVistoriaTipoServico)
                    .WithMany(p => p.TblVistoriaTipoServicoVestigio)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.CnpjVistoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaTipoServico_tblVistoriaTipoServicoVestigio");

                entity.HasOne(d => d.TblVistoriaTipoVestigio)
                    .WithMany(p => p.TblVistoriaTipoServicoVestigio)
                    .HasForeignKey(d => new { d.CnpjVistoria, d.GrupoVestigio, d.TipoVestigio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaTipoVestigio_tblVistoriaTipoServicoVestigio");
            });

            modelBuilder.Entity<TblVistoriaTipoVeiculoVestigio>(entity =>
            {
                entity.HasKey(e => new { e.CnpjVistoria, e.GrupoVestigio, e.TipoVestigio, e.TipoVeiculo, e.CnpjFranqueador });

                entity.ToTable("tblVistoriaTipoVeiculoVestigio");

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblFranqueadorTipoVeiculo)
                    .WithMany(p => p.TblVistoriaTipoVeiculoVestigio)
                    .HasForeignKey(d => new { d.TipoVeiculo, d.CnpjFranqueador })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblFranqueadorTipoVeiculo_tblVistoriaTipoVeiculoVestigio");

                entity.HasOne(d => d.TblVistoriaTipoVestigio)
                    .WithMany(p => p.TblVistoriaTipoVeiculoVestigio)
                    .HasForeignKey(d => new { d.CnpjVistoria, d.GrupoVestigio, d.TipoVestigio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaTipoVestigio_tblVistoriaTipoVeiculoVestigio");
            });

            modelBuilder.Entity<TblVistoriaTipoVeiculoVestigioServico>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.TipoServico, e.CnpjVistoria, e.GrupoVestigio, e.TipoVestigio, e.TipoVeiculo });

                entity.ToTable("tblVistoriaTipoVeiculoVestigioServico");

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblVistoriaTipoServicoVestigio)
                    .WithMany(p => p.TblVistoriaTipoVeiculoVestigioServico)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.CnpjVistoria, d.GrupoVestigio, d.TipoVestigio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaTipoServicoVestigio_tblVistoriaTipoVeiculoVestigioServico");

                entity.HasOne(d => d.TblVistoriaTipoVeiculoVestigio)
                    .WithMany(p => p.TblVistoriaTipoVeiculoVestigioServico)
                    .HasForeignKey(d => new { d.CnpjVistoria, d.GrupoVestigio, d.TipoVestigio, d.TipoVeiculo, d.CnpjFranqueador })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaTipoVeiculoVestigio_tblVistoriaTipoVeiculoVestigioServico");
            });

            modelBuilder.Entity<TblVistoriaTipoVestigio>(entity =>
            {
                entity.HasKey(e => new { e.CnpjVistoria, e.GrupoVestigio, e.TipoVestigio });

                entity.ToTable("tblVistoriaTipoVestigio");

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Abreviacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblVistoriaGrupoVestigio)
                    .WithMany(p => p.TblVistoriaTipoVestigio)
                    .HasForeignKey(d => new { d.CnpjVistoria, d.GrupoVestigio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaGrupoVestigio_tblVistoriaTipoVestigio");
            });

            modelBuilder.Entity<TblVistoriaVestigio>(entity =>
            {
                entity.HasKey(e => new { e.CnpjFranqueador, e.TipoVeiculo, e.TipoServico, e.GrupoVestigio, e.TipoVestigio, e.StatusVestigioVistoria, e.CnpjVistoria, e.Vestigio });

                entity.ToTable("tblVistoriaVestigio");

                entity.Property(e => e.CnpjFranqueador)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVeiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVestigio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusVestigioVistoria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnpjVistoria)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Vestigio)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.HasOne(d => d.TblVistoriaStatusVestigio)
                    .WithMany(p => p.TblVistoriaVestigio)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.CnpjVistoria, d.StatusVestigioVistoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaStatusVestigio_tblVistoriaVestigio");

                entity.HasOne(d => d.TblVistoriaTipoVeiculoVestigioServico)
                    .WithMany(p => p.TblVistoriaVestigio)
                    .HasForeignKey(d => new { d.CnpjFranqueador, d.TipoServico, d.CnpjVistoria, d.GrupoVestigio, d.TipoVestigio, d.TipoVeiculo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblVistoriaTipoVeiculoVestigioServico_tblVistoriaVestigio");
            });

            modelBuilder.Entity<TipoCobranca>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaIdFranqueador, e.EmpresaId, e.Descricao });

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipoCobrancaId).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<TipoServicoPessoaValor>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaIdFranqueador, e.EmpresaId, e.TipoServicoId, e.PessoaId });

                entity.ToTable("TipoServico_Pessoa_Valor");

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipoServicoPessoaValorId)
                    .HasColumnName("TipoServico_Pessoa_ValorId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.Valor).HasColumnType("smallmoney");

                entity.Property(e => e.ValorRetorno).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<TipoServicoSegmentoValor>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaIdFranqueador, e.EmpresaId, e.TipoServicoId, e.PessoaSegmentoId });

                entity.ToTable("TipoServico_Segmento_Valor");

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipoServicoSegmentoValorId)
                    .HasColumnName("TipoServico_Segmento_ValorId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.Valor).HasColumnType("smallmoney");

                entity.Property(e => e.ValorRetorno).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<TipoVeiculo>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaIdFranqueador, e.TipoVeiculo1 });

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.TipoVeiculo1)
                    .HasColumnName("TipoVeiculo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoVeiculoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TipoVestigio>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaIdFranqueador, e.EmpresaId, e.GrupoVestigioId, e.TipoVeiculoId, e.TipoServicoId, e.TipoVestigio1 });

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.TipoVestigio1)
                    .HasColumnName("TipoVestigio")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Abreviacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdemPrint).HasColumnName("Ordem_Print");

                entity.Property(e => e.TipoVestigioId).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<UsuarioModuloSistema>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioId, e.ModuloSistemaId });

                entity.ToTable("Usuario_ModuloSistema");

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioModuloSistemaId)
                    .HasColumnName("Usuario_ModuloSistemaId")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Vestigio>(entity =>
            {
                entity.HasKey(e => new { e.EmpresaIdFranqueador, e.EmpresaId, e.TipoVestigioId, e.StatusVestigioId, e.Vestigio1 });

                entity.Property(e => e.EmpresaIdFranqueador).HasColumnName("EmpresaId_Franqueador");

                entity.Property(e => e.Vestigio1)
                    .HasColumnName("Vestigio")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.VestigioId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VistoriaConsultaVeicular>(entity =>
            {
                entity.HasKey(e => new { e.VistoriaId, e.EmpresaConsultaVeicularId, e.DthInsert });

                entity.ToTable("Vistoria_ConsultaVeicular");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AnoFabBaseNacional)
                    .HasColumnName("AnoFab_BaseNacional")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnoModBaseNacional)
                    .HasColumnName("AnoMod_BaseNacional")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CambioBaseNacional)
                    .HasColumnName("Cambio_BaseNacional")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadeCarga)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Categoria)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChassiBaseNacional)
                    .HasColumnName("Chassi_BaseNacional")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Cilindrada)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CombustivelBaseNacional)
                    .HasColumnName("Combustivel_BaseNacional")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CorBaseNacional)
                    .HasColumnName("Cor_BaseNacional")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthSolicitado)
                    .HasColumnName("DTH_Solicitado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.MarcaBaseNacional)
                    .HasColumnName("Marca_BaseNacional")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloBaseNacional)
                    .HasColumnName("Modelo_BaseNacional")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MunicipioBaseNacional)
                    .HasColumnName("Municipio_BaseNacional")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroMotorBaseNacional)
                    .HasColumnName("NumeroMotor_BaseNacional")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlacaBaseNacional)
                    .HasColumnName("Placa_BaseNacional")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Potencia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RenavamBaseNacional)
                    .HasColumnName("Renavam_BaseNacional")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.RetornoConsultaVeicular)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TipoEspecie)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UfBaseNacional)
                    .HasColumnName("Uf_BaseNacional")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UlrPrint)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdSolicitado).HasColumnName("UsuarioId_Solicitado");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.VistoriaConsultaVeicularId)
                    .HasColumnName("Vistoria_ConsultaVeicularId")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VistoriaFoto>(entity =>
            {
                entity.ToTable("Vistoria_Foto");

                entity.Property(e => e.VistoriaFotoId).HasColumnName("Vistoria_FotoId");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CaminhoFisico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObservacaoFoto)
                    .HasColumnName("Observacao_Foto")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");
            });

            modelBuilder.Entity<VistoriaFotoAvaria>(entity =>
            {
                entity.ToTable("Vistoria_FotoAvaria");

                entity.Property(e => e.VistoriaFotoAvariaId).HasColumnName("Vistoria_FotoAvariaId");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CaminhoFisico)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatahoraFotoAvaria)
                    .HasColumnName("Datahora_FotoAvaria")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObservacaoFotoAvaria)
                    .HasColumnName("Observacao_FotoAvaria")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.ValorSugeridoFotoAvaria)
                    .HasColumnName("ValorSugerido_FotoAvaria")
                    .HasColumnType("smallmoney");
            });

            modelBuilder.Entity<VistoriaLogAcao>(entity =>
            {
                entity.HasKey(e => new { e.VistoriaId, e.UsuarioIdLogAcao, e.LogAcao });

                entity.ToTable("Vistoria_LogAcao");

                entity.Property(e => e.UsuarioIdLogAcao).HasColumnName("UsuarioId_LogAcao");

                entity.Property(e => e.LogAcao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthLogAcao)
                    .HasColumnName("DTH_LogAcao")
                    .HasColumnType("datetime");

                entity.Property(e => e.VistoriaLogAcaoId)
                    .HasColumnName("Vistoria_LogAcaoId")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VistoriaVestigio>(entity =>
            {
                entity.HasKey(e => new { e.VistoriaId, e.VestigioId });

                entity.ToTable("Vistoria_Vestigio");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Dar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthDelete)
                    .HasColumnName("DTH_Delete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DthInsert)
                    .HasColumnName("DTH_Insert")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DthUpdate)
                    .HasColumnName("DTH_Update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioIdDelete).HasColumnName("UsuarioId_Delete");

                entity.Property(e => e.UsuarioIdInsert).HasColumnName("UsuarioId_Insert");

                entity.Property(e => e.UsuarioIdUpdate).HasColumnName("UsuarioId_Update");

                entity.Property(e => e.VistoriaVestigioId)
                    .HasColumnName("Vistoria_VestigioId")
                    .ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
