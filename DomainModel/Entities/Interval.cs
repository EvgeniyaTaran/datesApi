using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
	public class Interval:IEntity
	{
		public int Id { get; set; }
		public DateTime DateStart { get; set; }
		public DateTime DateFinish { get; set; }
	}
}
