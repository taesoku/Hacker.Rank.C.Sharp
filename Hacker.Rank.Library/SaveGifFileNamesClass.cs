using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hacker.Rank.Library
{
    class SaveGifFileNamesClass
    {

        public static void Answer()
        {
            SaveGifFileNames();
        }

        public static void SaveGifFileNames()
        {
            // read the string filename
            var filename = Console.ReadLine();
            var hashset = new HashSet<string>();
            using (var r = new StreamReader(filename))
            {
                var textline = string.Empty;
                while ((textline = r.ReadLine()) != null)
                {
                    var textblocks = textline.Trim().Split(' ').ToList();
                    if (!textblocks[textblocks.Count - 2].Contains("200")) continue;
                    var regex = new Regex(@"([a-zA-Z0-9\-_?%.]+?)\.(gif|GIF)");
                    var match = regex.Match(textline);
                    if (match.Success) hashset.Add(match.ToString());                    
                }
                filename = "gifs_" + filename;
                var writer = new StreamWriter(filename);
                writer.Write(string.Join("\n", hashset));
                writer.Close();
            }
        }

    }
}