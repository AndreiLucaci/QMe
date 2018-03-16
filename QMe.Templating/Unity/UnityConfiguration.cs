using QMe.Templating.Controllers;
using Unity;
using Unity.Injection;

namespace QMe.Templating.Unity
{
	public static class UnityConfiguration
	{
		public static void RegisterTypes(this IUnityContainer container)
		{
			container.ConfigureWithViews();
			container.ConfigureWithControllers();

			container.RegisterType<TemplateManager>(
				new InjectionConstructor(
					container.Resolve<AddNewTemplateController>()
				)
			);
		}
	}
}
