﻿using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            TagLower(args[0]);
        }

        static void TagLower(string file)
        {
            var lines = File.ReadAllLines(file);
            var sb = new StringBuilder();
            foreach (var line in lines)
            {
                var s = Regex.Replace(line,
                            @"<(/?)([A-Z][A-Z0-9]*)(.*?)>",
                            m => {
                                return string.Format("<{0}{1}{2}>", m.Groups[1].Value, m.Groups[2].Value.ToLower(), m.Groups[3].Value);
                            }
                        );
                sb.AppendLine(s);
                File.WriteAllText(file, sb.ToString());
            }
        }
    }
}
