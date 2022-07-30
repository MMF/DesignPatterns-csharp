namespace DesignPatterns.ProxyPattern;

// 3rd-Party library (Can not be changed)
public class YouTubeLib
{
    public string ListVideos()
    {
        Console.WriteLine("[API Call] Fetch Videos.");
        return "Video 1, Video 2, Video 3";
    }

    public string GetVideoInfo(int id)
    {
        Console.WriteLine("[API Call] Get Video Information.");
        return $"Video Info for #{id}";
    }
}
