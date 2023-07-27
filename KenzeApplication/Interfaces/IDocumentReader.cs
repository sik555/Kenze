using System;
using System.Collections.Generic;
using System.Text;

namespace KenzeApplication
{
    interface IDocumentReader
    {
        public string[] ReadDocument(string docName);
    }
}
