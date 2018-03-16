using System.Windows.Forms;
using QMe.Business.Controllers;

namespace QMe.Business.Forms
{
	public class FormController : Form
	{
		protected Controller Controller;

		public FormController SetController<T>(T controller) 
			where T : Controller
		{
			Controller = controller;
			return this;
		}
	}
}
