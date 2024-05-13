using Microsoft.EntityFrameworkCore;
using SilkroadWebsite.Data.Model.Shard;

namespace SilkroadWebsite.Data
{
	public class ShardDbContext : DbContext
	{
		public ShardDbContext(DbContextOptions<ShardDbContext> options) : base(options)
		{
		}

		public DbSet<SR_Char> _Char { get; set; }
		public DbSet<SR_Guild> _Guild { get; set; }
		public DbSet<SR_GuildMember> _GuildMember { get; set; }


	}
}
