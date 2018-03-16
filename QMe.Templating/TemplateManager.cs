using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using QMe.Templating.Controllers;
using QMe.Templating.ViewModels;

namespace QMe.Templating
{
	public partial class TemplateManager : Form
	{
		private readonly AddNewTemplateController _addNewTemplateController;

		private readonly List<AddTemplateViewModel> _templates;

		public TemplateManager(AddNewTemplateController addNewTemplateController)
		{
			InitializeComponent();

			_addNewTemplateController = addNewTemplateController;
			_templates = _addNewTemplateController.LoadTemplates();
		}

		private void addNewTemplateBtn_Click(object sender, EventArgs e)
		{
			ShowNewFormAsync(_addNewTemplateController.GenerateView(), async () =>
			{
				var model = _addNewTemplateController.GetTemplateViewModel();

				_templates.Add(model);

				await RefreshListAsync();
			});
		}

		private async Task RefreshListAsync()
		{
			await Task.Run(() =>
			{
				listView1.Invoke((Action) (() =>
				{
					listView1.Clear();
					
					_templates.ForEach(i =>
					{
						var lwi = new ListViewItem(new [] {i.Title, i.Description});
						listView1.Items.Add(lwi);
					});
				}));
			});
		}

		private void ShowNewFormAsync(Form form, Func<Task> onClosing = null)
		{
			Hide();

			form.ShowDialog(this);

			onClosing?.Invoke();

			Show();
		}

		private void ShowNewForm(Form form, Action onClosing = null)
		{
			Hide();

			form.ShowDialog(this);

			onClosing?.Invoke();

			Show();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 1)
			{
				var item = listView1.SelectedItems[0];
				var model = new AddTemplateViewModel
				{
					Title = item.SubItems[0].Text,
					Description = item.SubItems[1].Text,
				};

				ShowNewForm(_addNewTemplateController.GenerateView(model));
			}
		}
	}
}
