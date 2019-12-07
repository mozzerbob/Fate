using System;

namespace Fate.Models
{
	public class Aspect
	{
		public long Id;
		public string Name;
		public string Desc;
		public long Type;
		public long Assignee;
		public bool Compeled;
		public bool Activated;
		public DateTime CreateDate;
		public DateTime ActivatedDate;
		public DateTime CompleteDate;
	}
}
