using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SH_MusicPlayer.Lib.Files
{
    public class Data
    {
        public static List<string> load(string path)
        {
            return File.ReadAllLines(path).ToList();
        }

    }
}
