using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderHandler
{
    class XmlReader : FileReaderHandler
    {
        XmlReader(string path) : base(path)
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
