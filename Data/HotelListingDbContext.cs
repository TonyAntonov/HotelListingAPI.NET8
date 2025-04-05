using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
         
                new Country 
                {
                    Id = 1,
                    Name = "Bulgaria",
                    ShortName = "BG"
                },
                new Country
                {
                    Id = 2,
                    Name = "Greece",
                    ShortName = "GR"
                },
                new Country
                {
                    Id = 3,
                    Name = "Spain",
                    ShortName = "ES"
                },
                new Country
                {
                    Id = 4,
                    Name = "Italy",
                    ShortName = "IT"
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Marriott",
                    Address = "Sofia",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "Thessoloniki",
                    CountryId = 2,
                    Rating = 4.0
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hilton",
                    Address = "Madrid",
                    CountryId = 3,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Grand Palladium",
                    Address = "Rome",
                    CountryId = 4,
                    Rating = 4.8
                }
            );
        }
    }
}
