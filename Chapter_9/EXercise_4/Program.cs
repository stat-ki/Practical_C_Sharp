using System;
using System.IO;

namespace EXercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceDir = args[0];
            var destDir = args[1];
            CopyFiles(sourceDir, destDir);
        }

        private static void CopyFiles(string sourceDir, string destDir)
        {
            var files = Directory.EnumerateFiles(sourceDir, "*.*");
            if (!Directory.Exists(destDir))
                Directory.CreateDirectory(destDir);
            foreach (var file in files)
            {
                var dest = GetBakFilePath(destDir, file);
                Console.WriteLine(dest);
                File.Copy(file, dest, overwrite: true);
            }
        }

        private static string GetBakFilePath(string destDir, string file)
        {
            var name = Path.GetFileNameWithoutExtension(file) + "_bak";
            var ext = Path.GetExtension(file);
            return Path.Combine(destDir, name + ext);
        }
    }
}
