using DomainModel.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DomainModel.Repositories
{
	public class Repository <T> where T : class, IEntity
	{
		protected readonly EntityContext Db;
		public Repository(EntityContext context)
		{
			Db = context;
			Db.Configuration.LazyLoadingEnabled = false;
			Db.Configuration.ProxyCreationEnabled = false;
		}

		protected virtual DbSet<T> DbSet => Db.Set<T>();

		public virtual T WithId(int id)
		{
			return DbSet.FirstOrDefault(e => e.Id == id);
		}

		public virtual ICollection<T> All()
		{
			return DbSet.ToList();
		}
	}
}
