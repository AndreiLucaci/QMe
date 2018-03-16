using QMe.Templating.Controllers;
using Unity;

namespace QMe.Templating.Unity
{
	public static class ControllerConfiguration
	{
		public static void ConfigureWithControllers(this IUnityContainer container)
		{
			container.RegisterType<AddNewTemplateController>();
		}
	}
}
