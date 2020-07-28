using System;
using System.Diagnostics;
using System.Reflection;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAssemblyVersion();
            PrintFileversion();
        }

        private static void PrintAssemblyVersion()
        {
            var asm = Assembly.GetExecutingAssembly();
            var ver = asm.GetName().Version;
            Console.WriteLine("Assembly Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision);
        }

        private static void PrintFileversion()
        {
            var loc = Assembly.GetExecutingAssembly().Location;
            var ver = FileVersionInfo.GetVersionInfo(loc);
            Console.WriteLine("File Version: {0}.{1}.{2}.{3}", ver.FileMajorPart, ver.FileMinorPart, ver.FileBuildPart, ver.FilePrivatePart);
        }
    }
}
