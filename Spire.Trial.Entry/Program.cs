using System;
using System.Collections.Generic;
using System.IO;
using Spire.Doc.Client;

namespace Spire.Trial.Entry
{
    class Program
    {
        static void Main()
        {
            TestFill();
        }

        private static void TestFill()
        {
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "Letter.docx");
            var items = new List<DocItem>
            {
                new DocItem ("[收件人]", "张三"),
                new DocItem ("[公司名称]", "Spire公司"),
                new DocItem ("[商业类型]", "Spire使用"),
                new DocItem ("[电话号码]", "400-123-456"),
                new DocItem ("[销售代表]", "李四"),
                new DocItem ("[发件人]", "王五"),
                new DocItem ("[职位]", "首席执行官")
            };

            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fill.docx");

            var filler = new DocFiller();
            filler.Fill(templatePath, filePath, items);
        }
    }
}
