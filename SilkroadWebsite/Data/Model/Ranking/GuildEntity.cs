using System.ComponentModel.DataAnnotations;

namespace SilkroadWebsite.Data.Model.Ranking
{
	public class GuildEntity
	{
		[Key]
		public string? Name { get; set; }
		public int MemberCount { get; set; }
		public byte Level { get; set; }
		public int GuildPoints { get; set; }
	}
}
