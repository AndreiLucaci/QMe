using QMe.Models.Constants;
using Xceed.Words.NET;

namespace QMe.Models.Styles
{
	public class DefaultStyle : IStyle
	{
		public Formatting Title { get; set; } = GetTitleFormatting();

		private static Formatting GetTitleFormatting()
		{
			return new Formatting
			{
				FontFamily = FontConstants.Arial,
				Size = 20D,
				Position = 12
			};
		}

		public Formatting Heading1 { get; set; } = new Formatting
		{
			FontFamily = FontConstants.Arial,
			Size = 24D,
			Position = 12
		};

		public Formatting Heading2 { get; set; } = new Formatting
		{
			FontFamily = FontConstants.Arial,
			Size = 20D,
			Position = 12
		};

		public Formatting Heading3 { get; set; } = new Formatting
		{
			FontFamily = FontConstants.Arial,
			Size = 18D,
			Position = 12
		};

		public Formatting Heading4 { get; set; } = new Formatting
		{
			FontFamily = FontConstants.Arial,
			Size = 16D,
			Position = 12
		};

		public Formatting Normal { get; set; } = new Formatting
		{
			FontFamily = FontConstants.Arial,
			Size = 14D,
			Position = 12
		};
	}
}
