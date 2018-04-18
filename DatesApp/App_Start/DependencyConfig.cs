using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DomainModel;
using DryIoc;

namespace DatesApp.App_Start
{
	public class DependencyConfig
	{
		public static void RegisterDependencies(IContainer container)
		{
			container.Register<EntityContext>(Reuse.InWebRequest);
		}
	}
}