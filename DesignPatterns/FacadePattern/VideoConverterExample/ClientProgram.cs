namespace DesignPatterns.FacadePattern.VideoConverterExample;

public class ClientProgram
{
    public static void Run()
    {
        var videoConverter = new HrFacade();
        var videoFile = videoConverter.ConvertVideo("D://media/funny_cat.avi", "video.mp4");

        videoFile.Save("D://media/funny_cat.mp4");

        Console.WriteLine("Video converted successfully!");
    }
}
