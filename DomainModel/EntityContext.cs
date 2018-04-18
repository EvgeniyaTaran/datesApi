using System.Data.Entity;
using DomainModel.Entities;

namespace DomainModel
{
	public class EntityContext : DbContext
	{
		public DbSet<Interval> Intervals { get; set; }
		public EntityContext()
			: base("dates_app")
		{
			Configuration.LazyLoadingEnabled = false;
			Configuration.ProxyCreationEnabled = false;
		}
	}
}
