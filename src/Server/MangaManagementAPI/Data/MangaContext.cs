using Microsoft.EntityFrameworkCore;

namespace MangaManagementAPI.Data;

public class MangaContext : DbContext
{
	public MangaContext(DbContextOptions options) : base(options) { }
}
