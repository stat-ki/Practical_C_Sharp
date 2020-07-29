using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            UnzipTxt("../../../sample.zip", "../../../output");
        }

        static void UnzipTxt(string file, string outputDir)
        {
            using (var zip = ZipFile.OpenRead(file))
            {
                var entries = zip.Entries.Where(x => Path.GetExtension(x.Name) == ".txt");
                if (entries.Any() && !Directory.Exists(outputDir))
                {
                    Directory.CreateDirectory(outputDir);
                }
                foreach (var entry in entries)
                {
                    var destPath = Path.Combine(outputDir, entry.FullName);
                    var destDir = Path.GetDirectoryName(destPath);
                    if (!Directory.Exists(destDir))
                    {
                        Directory.CreateDirectory(destDir);
                    }
                    entry.ExtractToFile(destPath, overwrite: true);
                }
            }
        }
    }
}
