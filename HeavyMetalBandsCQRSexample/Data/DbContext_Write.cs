using HeavyMetalBandsCQRSexample.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace HeavyMetalBandsCQRSexample.Data
{
    public class DbContext_Write : DbContext
    {
        public DbContext_Write(DbContextOptions<DbContext_Write> options) : base(options) { }

        public DbSet<Band> Bands { get; set; }
    }
}
