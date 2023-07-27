using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KenzeApplication.Services
{
    public class DocumentReader : IDocumentReader
    {
        public DocumentReader()
        {

        }
        public string[] ReadDocument(string docName)
        {
            string[] words = new string[] { };

            if (File.Exists($"Documents\\{docName}"))
            {
                words = File.ReadAllLines($"Documents\\{docName}");
            }

            return words;
        }
    }
}
