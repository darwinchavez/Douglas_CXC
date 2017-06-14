namespace CXC.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CXCDbContext : DbContext
    {
        public CXCDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public virtual DbSet<Abono> Abonos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Credito> Creditos { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tarjeta> Tarjetas { get; set; }
        public virtual DbSet<Transaccione> Transacciones { get; set; }
        public virtual DbSet<EstCta1> EstCta1 { get; set; }
        public virtual DbSet<FirstFiltro> FirstFiltroes { get; set; }
        public virtual DbSet<PrimEstCta> PrimEstCtas { get; set; }
        public virtual DbSet<RdeFactura> RdeFacturas { get; set; }
        public virtual DbSet<RegistrosSalAnt> RegistrosSalAnts { get; set; }
        public virtual DbSet<RegistrosxCliente> RegistrosxClientes { get; set; }
        public virtual DbSet<RepAbono> RepAbonos { get; set; }
        public virtual DbSet<RepDetAbono> RepDetAbonos { get; set; }
        public virtual DbSet<RepDetCredito> RepDetCreditos { get; set; }
        public virtual DbSet<RepTarjeta> RepTarjetas { get; set; }
        public virtual DbSet<RepVenta> RepVentas { get; set; }
        public virtual DbSet<SalAntAbono> SalAntAbonos { get; set; }
        public virtual DbSet<SalAntCredito> SalAntCreditos { get; set; }
        public virtual DbSet<SaldoAnteriorCre> SaldoAnteriorCres { get; set; }
        public virtual DbSet<SalIni> SalInis { get; set; }
        public virtual DbSet<SalxCli> SalxClis { get; set; }
        public virtual DbSet<SalxCli2> SalxCli2 { get; set; }
        public virtual DbSet<TSaldoAnterior> TSaldoAnteriors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abono>()
                .Property(e => e.FechaAbono)
                .HasPrecision(0);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Transacciones)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Credito>()
                .Property(e => e.FechaCredito)
                .HasPrecision(0);

            modelBuilder.Entity<Tarjeta>()
                .Property(e => e.FechaIngreso)
                .HasPrecision(0);

            modelBuilder.Entity<Transaccione>()
                .Property(e => e.FechaTransaccion)
                .HasPrecision(0);

            modelBuilder.Entity<EstCta1>()
                .Property(e => e.Fecha)
                .HasPrecision(0);

            modelBuilder.Entity<EstCta1>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<FirstFiltro>()
                .Property(e => e.Fecha)
                .HasPrecision(0);

            modelBuilder.Entity<FirstFiltro>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PrimEstCta>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<RdeFactura>()
                .Property(e => e.FechaTransaccion)
                .HasPrecision(0);

            modelBuilder.Entity<RdeFactura>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<RegistrosSalAnt>()
                .Property(e => e.FechaTransaccion)
                .HasPrecision(0);

            modelBuilder.Entity<RegistrosSalAnt>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<RegistrosxCliente>()
                .Property(e => e.FechaTransaccion)
                .HasPrecision(0);

            modelBuilder.Entity<RepAbono>()
                .Property(e => e.FechaTransaccion)
                .HasPrecision(0);

            modelBuilder.Entity<RepAbono>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<RepDetAbono>()
                .Property(e => e.FechaAbono)
                .HasPrecision(0);

            modelBuilder.Entity<RepDetCredito>()
                .Property(e => e.FechaCredito)
                .HasPrecision(0);

            modelBuilder.Entity<RepTarjeta>()
                .Property(e => e.FechaIngreso)
                .HasPrecision(0);

            modelBuilder.Entity<RepTarjeta>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<RepVenta>()
                .Property(e => e.FechaTransaccion)
                .HasPrecision(0);

            modelBuilder.Entity<RepVenta>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<SalAntAbono>()
                .Property(e => e.FechaAbono)
                .HasPrecision(0);

            modelBuilder.Entity<SalAntCredito>()
                .Property(e => e.FechaCredito)
                .HasPrecision(0);

            modelBuilder.Entity<SalAntCredito>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<SaldoAnteriorCre>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<SalIni>()
                .Property(e => e.Fecha)
                .HasPrecision(0);

            modelBuilder.Entity<SalIni>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<SalxCli>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<SalxCli2>()
                .Property(e => e.Fecha)
                .HasPrecision(0);

            modelBuilder.Entity<SalxCli2>()
                .Property(e => e.MFactura)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalxCli2>()
                .Property(e => e.MRecibo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TSaldoAnterior>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();
        }
    }
}
