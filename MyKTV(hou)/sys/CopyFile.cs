using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTV.sys
{
    class CopyFile
    {
        private static string _sourcePath;

        public static string SourcePath
        {
            get
            {
                return _sourcePath;
            }

            set
            {
                _sourcePath = value;
            }
        }


        public static bool ToCopyFile(string targetPath)
        {
            try
            {
                string fileName = Path.GetFileName(targetPath);
                new FileInfo(targetPath).CopyTo(SourcePath + "\\" +fileName);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                if (ex.GetType().ToString().Equals("System.IO.FileNotFoundException")||ex.GetType().ToString().Equals("System.IO.IOException"))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
