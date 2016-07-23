using System.Collections.Generic;

namespace Spire.Doc.Client
{
    public class DocFiller
    {
        public void Fill(string templatePath, string filePath, IEnumerable<DocItem> items)
        {
            using (var doc = new Document(templatePath))
            {
                foreach (var item in items)
                {
                    doc.Replace(item.Placeholder, item.Value, true, false);
                }

                doc.SaveToFile(filePath, FileFormat.Docx);
            }
        }
    }
}