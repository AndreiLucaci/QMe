using System;
using System.Windows.Forms;
using QMe.Templating.Unity;
using Unity;

namespace QMe.Templating
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var container = CreateContainer();

			container.RegisterTypes();

			var template = container.Resolve<TemplateManager>();
			Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);

			Run(template);
		}

		public static void Run(Form template)
		{
			Application.Run(template);
		}

		public static IUnityContainer CreateContainer()
		{
			return new UnityContainer();
		}
	}
}
