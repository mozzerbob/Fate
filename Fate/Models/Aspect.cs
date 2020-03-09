using System;

namespace Fate.Models
{
	public class Aspect : Entity
	{
		public string Desc { get; set; }
		public long Type { get; set; }
		public long Assignee { get; set; }
		public bool Compeled { get; set; }
		public bool Activated { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime ActivatedDate { get; set; }
		public DateTime CompleteDate { get; set; }
	}
}
