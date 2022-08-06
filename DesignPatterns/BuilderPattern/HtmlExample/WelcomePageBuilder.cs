namespace DesignPatterns.BuilderPattern.HtmlExample;

public class WelcomePageBuilder
{
    private HtmlPage _page = new();

    public WelcomePageBuilder()
    {
        
        
        _page.AddHeader("Greetings");
        _page.AddText("Good day to you");
        _page.SetFooter("Copyrights reserved &copy 2022");
    }
    
    public void SetTitle() 
        => _page.SetTitle("Welcome Page");

    public void AddStylesheets()
        => _page.AddStylesheet("welcome.css");

    public string Build()
        => _page.Render();
}
