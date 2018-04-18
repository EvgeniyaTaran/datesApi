using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DomainModel.Repositories
{
	public class Intervals: Repository<Interval>
	{
		public Intervals(EntityContext ctx) : base(ctx){}

		public Interval Create(DateTime dateStart, DateTime dateFinish)
		{
			return new Interval()
			{
				DateStart = dateStart,
				DateFinish = dateFinish
			};
		}

		public IEnumerable<Interval> GetWithinDateRange(DateTime dateStart, DateTime dateFinish)
		{
			return DbSet.Where(p => !(p.DateStart > dateFinish || p.DateFinish < dateStart));
		}
	}
}
