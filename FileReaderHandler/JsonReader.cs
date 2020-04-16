using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderHandler
{
    class JsonReader : FileReaderHandler
    {
        JsonReader(string path) : base(path)
        {

        }
        JsonReader(string path, Boolean IsEncryptionActive) : base(path, IsEncryptionActive)
        {

        }
        public new string ReadFile()
        {
            return ReadFile();
        }

        public string ReadFileByRole(Role userRole)
        {
            return ReadFileBySecurityrRole(userRole);
        }
    }
}
