using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderHandler
{
    class TextReader : FileReaderHandler
    {
        TextReader(string path) : base(path)
        {

        }

        TextReader(string path, Boolean IsEncryptionActive) : base(path, IsEncryptionActive)
        {

        }

        public new string ReadFile()
        {
            return ReadFile();
        }
    }
}
