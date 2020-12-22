﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DataDumper.Managers;

namespace DataDumper.Utilities
{
    public static class PathUtil
    {
        public static bool CheckPath(string path, out string CombinedPath)
        {
            CombinedPath = Path.Combine(ConfigManager.CustomPath, path);
            if (File.Exists(CombinedPath)) return true;
            return false;
        }
    }
}