using System.Collections.Generic;
using QMe.Business.Controllers;
using QMe.Business.Forms;
using QMe.Templating.Forms;
using QMe.Templating.ViewModels;

namespace QMe.Templating.Controllers
{
	public class AddNewTemplateController : Controller
	{
		public override FormController GenerateView(object model = null)
		{
			View = new AddNewTemplate();

			if (model is AddTemplateViewModel viewModel)
			{
				((AddNewTemplate) View)?.SetModel(viewModel);
			}

			return View.SetController(this);
		}

		public AddTemplateViewModel GetTemplateViewModel()
		{
			return (View as AddNewTemplate)?.GetModel();
		}

		public List<AddTemplateViewModel> LoadTemplates()
		{
			return new List<AddTemplateViewModel>();
		}
	}
}
