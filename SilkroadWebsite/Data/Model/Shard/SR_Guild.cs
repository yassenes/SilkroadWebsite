using System.ComponentModel.DataAnnotations;

namespace SilkroadWebsite.Data.Model.Shard
{
	public class SR_Guild
	{
		[Key]
		public int ID { get; set; }
		public string? Name { get; set; }
		public byte Lvl { get; set; }
		public int GuildPoints { get; set; }
	}
}
