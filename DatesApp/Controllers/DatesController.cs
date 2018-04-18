using DomainModel;
using DomainModel.Entities;
using DomainModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DatesApp.Controllers
{
	public class DatesController : BaseController
	{
		private readonly EntityContext _ctx;
		private readonly Intervals _intervals;
		public DatesController(EntityContext context):base(context)
		{
			_ctx = context;
			_intervals = new Intervals(_ctx);
		}
		//For test purposes
		[HttpGet]
		public string Get()
		{
			return "test";
		}

		[HttpGet]
		public List<Interval> Get(DateTime dateStart, DateTime dateFinish)
		{
			var intervals = _intervals.GetWithinDateRange(dateStart, dateFinish).ToList();
			return intervals;
		}

		//[System.Web.Mvc.HttpPost]
		public IHttpActionResult AddInterval([FromBody]Interval interval)
		{
			var interv = _intervals.Create(interval.DateStart, interval.DateFinish);
			_ctx.Intervals.Add(interv);
			_ctx.SaveChanges();
			return Ok(true);

		}

	}
}
