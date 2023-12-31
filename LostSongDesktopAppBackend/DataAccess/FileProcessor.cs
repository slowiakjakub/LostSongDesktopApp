﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostSongDesktopAppBackend.DataAccess
{
    public static class FileProcessor
    {
        public static void RenameFile(ref string sourceFilePath, string finalFileName)
        {
            FileInfo fi = new FileInfo(sourceFilePath);
            if (fi.Exists)
            {
                string newFilePath = $@"{fi.Directory.FullName}\{finalFileName}{fi.Extension}";
                fi.MoveTo(newFilePath);
                sourceFilePath = newFilePath;
            }
        }
    }
}
