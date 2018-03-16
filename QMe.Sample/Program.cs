using QMe.Business.POC;

namespace QMe.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var poc = new POCSampleDocumentProcessor();

            var docx = poc.CreatePOCDocument();

            docx.Save();
        }
    }
}
