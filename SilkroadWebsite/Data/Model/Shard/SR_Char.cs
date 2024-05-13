using System.ComponentModel.DataAnnotations;

namespace SilkroadWebsite.Data.Model.Shard
{
	public class SR_Char
	{
		[Key]
		public int CharID { get; set; }
		public string? CharName16 { get; set; }
		public string? NickName16 { get; set; }
		public int RefObjID { get; set; }
		public byte CurLevel { get; set; }
		public short Strength { get; set; }
		public short Intellect { get; set; }
		public int HP { get; set; }
		public int MP { get; set; }
	}
}
