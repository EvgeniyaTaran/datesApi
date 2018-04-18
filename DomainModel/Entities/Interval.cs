using System;

namespace DomainModel.Entities
{
	public class Interval:IEntity
	{
		public int Id { get; set; }
		public DateTime DateStart { get; set; }
		public DateTime DateFinish { get; set; }
	}
}
