using System;
using Xceed.Words.NET;

namespace QMe.Business.POC
{
    public class POCSampleDocumentProcessor
    {
        public DocX CreatePOCDocument()
        {
            // Adjust the path so suit your machine:
            string fileName = @"DocXExample.docx";

            // Set up our paragraph contents:
            string headerText = "Rejection Letter";
            string letterBodyText = DateTime.Now.ToShortDateString();
            string paraTwo = ""
                             + "Dear %APPLICANT%" + Environment.NewLine + Environment.NewLine
                             + "I am writing to thank you for your resume. Unfortunately, your skills and "
                             + "experience do not match our needs at the present time. We will keep your "
                             + "resume in our circular file for future reference. Don't call us, "
                             + "we'll call you. "

                             + Environment.NewLine + Environment.NewLine
                             + "Sincerely, "
                             + Environment.NewLine + Environment.NewLine
                             + "Jim Smith, Corporate Hiring Manager";

            // Title Formatting:
            var titleFormat = new Formatting
            {
                FontFamily = new Font("Arial Black"),
                Size = 18D,
                Position = 12
            };

            // Body Formatting
            var paraFormat = new Formatting
            {
                FontFamily = new Font("Calibri"),
                Size = 10D
            };
            titleFormat.Position = 12;

            // Create the document in memory:
            var doc = DocX.Create(fileName);

            // Insert each prargraph, with appropriate spacing and alignment:
            Paragraph title = doc.InsertParagraph(headerText, false, titleFormat);
            title.Alignment = Alignment.center;

            doc.InsertParagraph(Environment.NewLine);
            Paragraph letterBody = doc.InsertParagraph(letterBodyText, false, paraFormat);
            letterBody.Alignment = Alignment.both;

            doc.InsertParagraph(Environment.NewLine);
            doc.InsertParagraph(paraTwo, false, paraFormat);

            return doc;
        }
    }
}
