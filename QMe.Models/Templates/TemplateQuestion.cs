using System.Collections.Generic;

namespace QMe.Models.Templates
{
	public class TemplateQuestion
	{
		public string Question { get; set; }
		public IEnumerable<TemplateAnswer> Answers { get; set; }
	}
}
