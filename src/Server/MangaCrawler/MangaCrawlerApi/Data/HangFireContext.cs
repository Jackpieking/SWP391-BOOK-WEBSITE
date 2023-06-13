using Microsoft.EntityFrameworkCore;

namespace MangaCrawlerApi.Data;

public class HangFireContext : DbContext
{
    public HangFireContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
