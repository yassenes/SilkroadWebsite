using System.ComponentModel.DataAnnotations;

namespace SilkroadWebsite.Data.Model.Shard
{
	public class SR_GuildMember
	{
		public int GuildID { get; set; }
		[Key]
		public int CharID { get; set; }
		public string? CharName { get; set; }
		public byte MemberClass { get; set; }
		public string? Nickname { get; set; }
	}
}
