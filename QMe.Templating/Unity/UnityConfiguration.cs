using Unity;

namespace QMe.Templating.Unity
{
	public class UnityConfiguration
	{
		public static void RegisterTypes(IUnityContainer container)
		{
			container.RegisterType<TemplateManager>();
		}
	}
}
