namespace DesignPatterns.FacadePattern.VideoConverterExample.VideoLibrary;

public class VideoFile
{
    public string FileName { get; set; }

    public VideoFile(string filePath)
    {
        FileName = filePath;
    }

    public VideoFile(byte[] fileData)
    {
        FileName = "";
    }

    public void Save(string filePath)
    {
    }
}
