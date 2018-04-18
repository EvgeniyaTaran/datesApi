using DatesApp.App_Start;
using DryIoc;
using DryIoc.WebApi;
using System.Web.Http;

namespace DatesApp
{
	public static class WebApiConfig
	{
		public static IContainer Container { get; private set; }
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services
			var container = new Container(rules => rules
				.WithUnknownServiceResolvers(Rules.AutoResolveConcreteTypeRule())).WithWebApi(config);
			DependencyConfig.RegisterDependencies(container);
			Container = container;

			// Web API routes
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "GetDates",
				routeTemplate: "api/{controller}/{dateStart}/{dateFinish}",
				defaults: new
				{
					dateStart = RouteParameter.Optional,
					dateFinish = RouteParameter.Optional
				}
			);

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}
