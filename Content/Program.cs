namespace Classes
{
    public class Content
    {
        public string Content { get; set; }

        public Content(string content)
        {
            Content = content;
        }

        public void Show()
        {
            Console.WriteLine($"Содержание: {Content}");
        }
    }
}