using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hacker.Rank.Library
{
    class SaveHostsCountClass
    {

        public static void Answer()
        {
            SaveHostsCount();
        }

        public static void SaveHostsCount()
        {
            // read the string filename
            var filename = Console.ReadLine();
            
            var dictionary = new Dictionary<string, int>();
            using (var r = new StreamReader(filename))
            {
                var textline = string.Empty;
                while ((textline = r.ReadLine()) != null)
                {
                    var textblocks = textline.Trim().Split(' ').ToList();
                    if (dictionary.ContainsKey(textblocks.First()))
                        dictionary[textblocks.First()]++;
                    else dictionary.Add(textblocks.First(), 1);
                }
                filename = "records_" + filename;
                var writer = new StreamWriter(filename);
                foreach (var d in dictionary)
                    writer.WriteLine(d.Key + " " + d.Value);
                writer.Close();
            }
        }

    }
}