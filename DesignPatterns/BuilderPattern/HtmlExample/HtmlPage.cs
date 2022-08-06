namespace DesignPatterns.BuilderPattern.HtmlExample;

public class HtmlPage
{
    private string _content, _title, _footer;
    private List<string> _stylesheets = new();
    
    public void SetTitle(string title)
    {
        _title = title;
    }

    public void SetFooter(string footer)
    {
        _footer = footer;
    }

    public void AddStylesheet(string stylesheet)
    {
        _stylesheets.Add($"<link rel='stylesheet' href='{stylesheet}' />");
    }

    public void AddHeader(string header)
    {
        _content += $"<h2>{header}</h2>";
    }

    public void AddText(string text)
    {
        _content += $"<span>{text}</span>";
    }

    public string Render()
    {
        return $@"
                <html>
                    <head>
                        <title>{_title}</title>
                        {string.Join("\n", _stylesheets)}
                    </head>
                <body>
                {_content}
                <footer>{_footer}</footer>
                </body>
                </html>";
    }
}
