using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Path.GetFullPath(args[0]));

            var obj = new AsyncWaitSample();
            obj.Execute(args[0]);

            Console.WriteLine("async:");
            obj.ExecuteAsync(args[0]);

            Console.WriteLine("await:");
            obj.Execute(args[0]);
        }
    }

    class AsyncWaitSample
    {
        public async void ExecuteAsync(string dir)
        {
            int workMin;
            int ioMin;
            ThreadPool.GetMinThreads(out workMin, out ioMin);
            ThreadPool.SetMinThreads(8, ioMin);
            var start = DateTime.Now;
            var files = Directory.EnumerateFiles(dir, "*.cs", SearchOption.AllDirectories);
            var tasks = new List<Task>();
            foreach (var file in files)
            {
                var task = Task.Run(() => {
                    if (Find(file))
                        Console.WriteLine(Path.GetFullPath(file));
                });
                tasks.Add(task);
            }
            await Task.WhenAll(tasks);

            Console.WriteLine("async {0}", (DateTime.Now - start).TotalSeconds);
        }

        public void Execute(string dir)
        {
            var start = DateTime.Now;
            var files = Directory.EnumerateFiles(dir, "*.cs", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                if (Find(file))
                    Console.WriteLine(Path.GetFullPath(file));
            }
            Console.WriteLine("await {0}", (DateTime.Now - start).TotalSeconds);
        }

        private bool Find(string file)
        {
            bool useAsync = false;
            bool useAwait = false;
            foreach (var line in File.ReadAllLines(file))
            {
                if (Regex.IsMatch(line, @"\basync\b"))
                    useAsync = true;
                if (Regex.IsMatch(line, @"\bawait\b"))
                    useAwait = true;
                if (useAsync && useAwait)
                    return true;
            }
            return false;
        }
    }
}
