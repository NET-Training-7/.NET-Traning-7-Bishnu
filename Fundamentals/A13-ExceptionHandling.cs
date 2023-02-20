using System;
using System.IO;

class ExceptionHandling
{
    public void CreateNewFile()
    {
        FileStream stream = default;
        try
        {
            var folderPath = @"D:\Apps\.NET Training 7\.NET-Traning-7-Bishnu\Fundamentals\FDHandling1";
            var file = "abc.me";
            var fileFullPath = $"{folderPath}\\{file}";

            if (!Directory.Exists(folderPath))
            {
                throw new IOException("'FDHandling1' folder does not exit.");
            }
            
            stream = File.Create(fileFullPath);
            stream.WriteByte(255);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Can't create new file.\nERROR:{ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Can't create new file.\nGeneric Error:{ex.Message}");
        }
        finally
        {
            stream.Close();
        }
    }
}
