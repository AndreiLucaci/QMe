using Xceed.Words.NET;

namespace QMe.Models.Styles
{
    public interface IStyle
    {
        Formatting Title { get; set; }
        Formatting Heading1 { get; set; }
        Formatting Heading2 { get; set; }
        Formatting Heading3 { get; set; }
        Formatting Heading4 { get; set; }
        Formatting Normal { get; set; }
    }
}
