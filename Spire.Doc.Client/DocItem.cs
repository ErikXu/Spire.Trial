namespace Spire.Doc.Client
{
    public class DocItem
    {
        public DocItem(string placeholder, string value)
        {
            Placeholder = placeholder;
            Value = value;
        }

        public string Placeholder { get; set; }

        public string Value { get; set; } 
    }
}