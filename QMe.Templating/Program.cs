using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

			UnityConfiguration.RegisterTypes(container);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(container.Resolve<TemplateManager>());
		}

		static IUnityContainer CreateContainer()
		{
			return new UnityContainer();
		}
	}
}
