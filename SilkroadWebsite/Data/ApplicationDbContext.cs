using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SilkroadWebsite.Data.Model.Ranking;
using SilkroadWebsite.Data.Model.Web;

namespace SilkroadWebsite.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<PlayerEntity> _Ranking_Player { get; set; }
		public DbSet<GuildEntity> _Ranking_Guild { get; set; }
        public DbSet<Post> _Posts { get; set; }
        public DbSet<DownloadLinks> _DownloadLinks { get; set; }

    }
}
