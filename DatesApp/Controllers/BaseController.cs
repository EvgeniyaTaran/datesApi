using DomainModel;
using System.Web.Http;

namespace DatesApp.Controllers
{
	public class BaseController : ApiController
    {
	    protected EntityContext Db;
		//Dryioc wants a public parameterless constructor
		public BaseController() { }
		protected BaseController(EntityContext ctx)
		{
			Db = ctx;
		}
        
    }
}