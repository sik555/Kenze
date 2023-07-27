using KenzeApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using KenzeApplication.ExtensionMethods;
using System.Linq;

namespace KenzeApplication.Services
{
    public class StringCombiner : IStringCombiner
    {
        string[] _fileStrings = new string[] { };
        List<string> _alreadyPrinted;
        int _maxLetters;
        int _line =0;

        public StringCombiner(string[] fileStrings)
        {
            _fileStrings = fileStrings;
            _alreadyPrinted = new List<string>();
            _maxLetters = fileStrings.OrderBy(x => x.Length).LastOrDefault().Length;
        }
        public void PrintCombinations()
        {
            for (int i = 0; i < _fileStrings.Length; i++)
            {
                ValidWords(_fileStrings[i]);
            }
        }

        private void ValidWords(string part)
        {
            List<string> validWords = new List<string>();
            validWords = _fileStrings.Where(x => x.Length + part.Length <= _maxLetters && !_alreadyPrinted.Contains(x)).ToList();
            
            for (int x = 0; x < validWords.Count; x++)
            {
                string word = "";
                word = part + validWords[x];

                if (validWords.Contains(word)&& !_alreadyPrinted.Contains(word))
                {
                    _line++;
                    PrintService.print(part, validWords[x], word, _line);
                    _alreadyPrinted.Add(word);
                    if (_fileStrings.Contains(word) && word.Length < _maxLetters)
                    {
                        ValidWords(word);
                    }
                }
            }
        }
    }
}
