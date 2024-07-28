namespace MCVP
{
    public static class Program
    {
        public const string FFMPEGEmbeddedResourceName = "MCVP.FFMPEG.exe";
        [System.STAThread()]
        public static void Main()
        {
            ExtractFFMPEG(FFMPEGEmbeddedResourceName, "ffmpeg.exe");
            ExtractOGGAudio("ffmpeg.exe", "DESKTOP\\BadApple.mkv", "DESKTOP\\BadAppleAudio.ogg");
            System.IO.File.Delete("ffmpeg.exe");
        }
        public static void ExtractFFMPEG(string embeddedResourceName, string outputExecutablePath)
        {
            System.Reflection.Assembly assembly = typeof(Program).Assembly;
            System.IO.Stream embeddedResourceStream = assembly.GetManifestResourceStream(embeddedResourceName);
            System.IO.FileStream outputExecutableStream = System.IO.File.Open(outputExecutablePath, System.IO.FileMode.CreateNew, System.IO.FileAccess.Write);
            embeddedResourceStream.CopyTo(outputExecutableStream);
            outputExecutableStream.Close();
            outputExecutableStream.Dispose();
            embeddedResourceStream.Close();
            embeddedResourceStream.Dispose();
        }
        public static void ExtractOGGAudio(string ffmpegExecutablePath, string sourceVideoPath, string outputFilePath)
        {
            System.Diagnostics.ProcessStartInfo ffmpegStartInfo = new System.Diagnostics.ProcessStartInfo();
            ffmpegStartInfo.FileName = ffmpegExecutablePath;
            ffmpegStartInfo.Arguments = $"-i \"{sourceVideoPath}\" \"{outputFilePath}\"";
            ffmpegStartInfo.CreateNoWindow = true;
            ffmpegStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            System.Diagnostics.Process ffmpeg = System.Diagnostics.Process.Start(ffmpegStartInfo);
            ffmpeg.WaitForExit();
        }
        public static void ExtractVideoFrames(string ffmpegExecutablePath, string sourceVideoPath, string outputDirectoryPath)
        {
            System.Diagnostics.ProcessStartInfo ffmpegStartInfo = new System.Diagnostics.ProcessStartInfo();
            ffmpegStartInfo.FileName = ffmpegExecutablePath;
            ffmpegStartInfo.Arguments = $"-i \"{sourceVideoPath}\" -r 20 \"{outputDirectoryPath}\\%d.bmp\"";
            ffmpegStartInfo.CreateNoWindow = true;
            ffmpegStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            System.Diagnostics.Process ffmpeg = System.Diagnostics.Process.Start(ffmpegStartInfo);
            ffmpeg.WaitForExit();
        }
        public static void ResizeImage(string sourcePath, string destinationPath, int width, int height)
        {
            System.Drawing.Bitmap source = new System.Drawing.Bitmap(sourcePath);
            System.Drawing.Bitmap output = new System.Drawing.Bitmap(source, new System.Drawing.Size(width, height));
            source.Dispose();
            output.Save(destinationPath);
            output.Dispose();
        }
        public static void ResizeImages(string sourceDirectoryPath, string destinationDirectoryPath, int width, int height)
        {
            System.Drawing.Size size = new System.Drawing.Size(width, height);
            foreach (string sourcePath in System.IO.Directory.GetFiles(sourceDirectoryPath))
            {
                System.Drawing.Bitmap source = new System.Drawing.Bitmap(sourcePath);
                System.Drawing.Bitmap output = new System.Drawing.Bitmap(source, size);
                source.Dispose();
                output.Save($"{destinationDirectoryPath}\\{System.IO.Path.GetFileName(sourcePath)}");
                output.Dispose();
            }
        }

    }
}

/*
            //Get the assembly and it's path.
            Assembly assembly = Assembly.GetCallingAssembly();
            string exePath = assembly.Location;
            string exeFolder = Path.GetDirectoryName(exePath);
            //Get the source path and make sure there is something there.
            string sourcePath = exeFolder + @"\Source.mp4";
            if (!File.Exists(sourcePath))
            {
                throw new Exception("Please create a Source.mp4 file and place it next to the exe.");
            }
            //Get the output path and delete the previous output then create a new output folder.
            string outputFolder = exeFolder + @"\Output";
            if (Directory.Exists(outputFolder))
            {
                Directory.Delete(outputFolder, true);
            }
            Directory.CreateDirectory(outputFolder);
            //Get the output frames path and create a new folder.
            string outputFramesFolder = outputFolder + @"\Frames";
            Directory.CreateDirectory(outputFramesFolder);
            //Separate the video into it's frames as PNGs and scale the framerate to 20 FPS.
            VideoFileReader videoReader = new VideoFileReader();
            videoReader.Open(sourcePath);
            int frameCount = (int)(videoReader.FrameCount / videoReader.FrameRate.ToDouble() * 20.0);
            for (int i = 0; i < frameCount; i++)
            {
                double time = i / 20.0;
                int frameIndex = (int)(time * videoReader.FrameRate.ToDouble());
                Bitmap frame = videoReader.ReadVideoFrame(frameIndex);
                frame.Save(outputFramesFolder + @"\Frame " + i.ToString() + ".png", ImageFormat.Png);
                frame.Dispose();
            }
            videoReader.Close();
            videoReader.Dispose();
            //Make All the frames 256x256
            foreach (string framePath in Directory.GetFiles(outputFramesFolder))
            {
                Bitmap frame = new Bitmap(framePath);
                Bitmap scaledFrame = new Bitmap(256, 256);
                for (int x = 0; x < 256; x++)
                {
                    for (int y = 0; y < 256; y++)
                    {
                        Color pixelColor = frame.GetPixel((int)(x / 256.0 * frame.Width), (int)(y / 256.0 * frame.Height));
                        scaledFrame.SetPixel(x, y, pixelColor);
                    }
                }
                frame.Dispose();
                scaledFrame.Save(framePath, ImageFormat.Png);
                scaledFrame.Dispose();
            }
            string output = "";
            for (int i = 0; i < 89; i++)
            {
                output += "execute if score <Global> MCVPTimer matches " + i.ToString() + " run summon item_frame ~ ~ ~ {Facing:3,Tags:[MCVPDisplay],Fixed:1b,Invisible:1,ItemDropChance:0.0f,ItemRotation:0,Item:{id:\"minecraft: filled_map\",Count:1,tag:{map:" + i.ToString() + "}}}" + "\n";
            }
            File.WriteAllText(@"C:\Users\rando\Desktop\Test.txt", output);
        }
        public static void WriteCompressedFileBytes(string filePath, byte[] contents)
        {
            WriteFileBytes(filePath, CompressByteArray(contents));
        }
        public static byte[] CompressByteArray(byte[] sourceBytes)
        {
            System.IO.MemoryStream sourceStream = new System.IO.MemoryStream(sourceBytes);
            System.IO.Compression.GZipStream sourceGZipStream = new System.IO.Compression.GZipStream(sourceStream, System.IO.Compression.CompressionMode.Compress);
            byte[] output = new byte[sourceGZipStream.Length];
            sourceGZipStream.Read(output, 0, output.Length);
            sourceGZipStream.Dispose();
            sourceStream.Dispose();
            return output;
        }
        public static void WriteFileBytes(string filePath, byte[] contents)
        {
            System.IO.File.WriteAllBytes(filePath, contents);
        }
        public static byte[] ReadCompressedFileBytes(string filePath)
        {
            return DecompressByteArray(ReadFileBytes(filePath));
        }
        public static byte[] DecompressByteArray(byte[] sourceBytes)
        {
            System.IO.MemoryStream sourceStream = new System.IO.MemoryStream(sourceBytes);
            System.IO.Compression.GZipStream sourceGZipStream = new System.IO.Compression.GZipStream(sourceStream, System.IO.Compression.CompressionMode.Decompress);
            byte[] output = new byte[System.BitConverter.ToUInt32(sourceBytes, sourceBytes.Length - 4)];
            sourceGZipStream.Read(output, 0, output.Length);
            sourceGZipStream.Dispose();
            sourceStream.Dispose();
            return output;
        }
        public static byte[] ReadFileBytes(string filePath)
        {
            return System.IO.File.ReadAllBytes(filePath);
        }
*/