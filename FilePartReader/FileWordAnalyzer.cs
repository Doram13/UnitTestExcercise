using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilePartReader
{
    class FileWordAnalyzer : FilePartReader
    {
        public FilePartReader FilePartReader;

        //1 constructor. It's parameter is a FilePartReader object

        public FileWordAnalyzer(FilePartReader _filePartReader)
        {
            FilePartReader = _filePartReader;
        }

        /*calls FilePartReader.ReadLines()
        returns the words ordered by alphabetically as an List<string>*/

        public List<string> WordByABC()
        {

            String text = FilePartReader.ReadLines();
            List<String> textList = text.Split(' ').ToList();
            textList.Sort();
            return textList;
        }

        /*  calls FilePartReader.ReadLines()
            returns the words from the string which are palindrome*/
        public List<string> WordsArePalindrome()
        {
            String text = FilePartReader.ReadLines();
            List<String> textList = text.Split(' ').ToList();
            List<String> palindromes = new List<String>();
            foreach (String word in textList)
            {
                string reverse;
                char[] letters = word.ToArray();
                Array.Reverse(letters);
                reverse = new string(letters);
                if (word.Equals(reverse, StringComparison.OrdinalIgnoreCase))
                {
                    palindromes.Add(word);
                }
            }
            return palindromes;
        }



    }
}
