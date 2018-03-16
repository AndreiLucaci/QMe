using QMe.Business.Forms;
using QMe.Templating.Forms;
using Unity;

namespace QMe.Templating.Unity
{
	public static class FormsConfiguration
	{
		public static void ConfigureWithViews(this IUnityContainer container)
		{
			container.RegisterType<FormController, AddNewTemplate>();
		}
	}
}
