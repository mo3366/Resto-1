
namespace Resto.DAL.DataBase
{
    public class RestoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VCK5CED; Database=Rosto;Trusted_Connection=True;MultipleActiveResultSets=true; TrustServerCertificate=true");
        }

        public DbSet<Booking> Bookings { get; set; }


        public DbSet<Table> Tables { get; set; }

    }
}
