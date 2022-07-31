namespace DesignPatterns.FacadePattern.VideoConverterExample.VideoLibrary;

public class CodecFactory
{
    public ICompressionCodec Extract(VideoFile videoFile)
    {
        if (videoFile.FileName.EndsWith("mp4"))
            return new MPEG4CompressionCodec();

        return new OggCompressionCodec();
    }
}
