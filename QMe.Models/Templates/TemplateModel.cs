using System.Collections.Generic;

namespace QMe.Models.Templates
{
	public class TemplateModel
	{
		public string Title { get; set; }
		public string Description { get; set; }

		public IEnumerable<TemplateQuestion> Questions { get; set; }
	}
}
