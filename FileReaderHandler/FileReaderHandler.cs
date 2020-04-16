using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReaderHandler
{
    public enum FileType
    {
        Text
    }
    public class FileReaderHandler
    {
        protected string Path { get; set; }
        public FileReaderHandler(string path)
        {
            Path = path;
        }

        protected string ReadFile()
        {
            try
            {
                StreamReader streamReader = new StreamReader(Path);
                string result = streamReader.ReadToEnd();
                streamReader.Close();

                return result;
            }
            catch (Exception e)
            {
                return ("Error " + e.Message);
            }
        }
    }
}
