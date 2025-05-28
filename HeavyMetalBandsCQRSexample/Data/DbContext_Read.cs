using HeavyMetalBandsCQRSexample.Data.DbModels; 
using Microsoft.EntityFrameworkCore;

namespace HeavyMetalBandsCQRSexample.Data
{
    public class DbContext_Read : DbContext
    {
        public DbContext_Read(DbContextOptions<DbContext_Read> options) : base(options) { }


        public DbSet<Band> Bands { get; set; }
    }
}
