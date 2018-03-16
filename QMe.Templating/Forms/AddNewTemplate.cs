using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using QMe.Business.Forms;
using QMe.Templating.ViewModels;
using Unity.Interception.Utilities;

namespace QMe.Templating.Forms
{
	public partial class AddNewTemplate : FormController
	{
		public AddNewTemplate()
		{
			InitializeComponent();
		}

		public AddTemplateViewModel GetModel()
		{
			return new AddTemplateViewModel
			{
				Title = titleTextBox.Text,
				Description = titleTextBox.Text
			};
		}

		public void SetModel(AddTemplateViewModel viewModel)
		{
			DisableAll();

			titleTextBox.Text = viewModel.Title;
			descriptionTextBox.Text = viewModel.Title;
		}

		private void DisableAll() =>
			new Control[] {titleTextBox, descriptionTextBox, submitButton}.ForEach(i => i.Enabled = false);

		private void label1_Click(object sender, System.EventArgs e)
		{

		}

		private void submitButton_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
