using System.ComponentModel.DataAnnotations;

namespace SilkroadWebsite.Data.Model.Ranking
{
	public class PlayerEntity
	{
		[Key]
		public int CharID { get; set; }
		public string? CharName { get; set; }
		public string? Guild { get; set; }
		public byte Level { get; set; }
		public int ItemPoints { get; set; }
	}
}
