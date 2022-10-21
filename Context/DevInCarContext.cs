using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using P1M3DevInCar.Models;
using P1M3DevInCar.Seeds;

namespace P1M3DevInCar.Context
{
    public class DevInCarContext : DbContext
    {
        public DevInCarContext() { }

        public DevInCarContext(DbContextOptions<DevInCarContext> options) : base(options) { }

        
        public DbSet<Camionete> Camionetes { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<MotoTriciclo> MotoTriciclos { get; set; }
        public DbSet<TipoVeiculo> TipoVeiculos { get; set; }
        public DbSet<TokenSetting> TokenSettings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Camionete>().HasData(CamioneteSeed.CamioneteSeeder);
            modelBuilder.Entity<Carro>().HasData(CarroSeed.CarroSeeder);
            modelBuilder.Entity<MotoTriciclo>().HasData(MotoTricicloSeed.MotoTricicloSeeder);
            modelBuilder.Entity<TipoVeiculo>().HasData(TipoVeiculoSeed.TipoVeiculoSeeder);
            modelBuilder.Entity<Veiculo>().HasData(VeiculoSeed.VeiculoSeeder);

        }
        

    }
}
