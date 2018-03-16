using QMe.Business.Forms;

namespace QMe.Business.Controllers
{
	public abstract class Controller
	{
		protected FormController View;

		public abstract FormController GenerateView(object model = null);
	}
}
