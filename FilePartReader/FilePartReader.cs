using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FilePartReader
{
    public class FilePartReader
    {
        private string filePath;
        private int fromLine;
        private int toLine;

        public string FilePath { get => filePath; set => filePath = value; }
        public int FromLine { get => fromLine; set => fromLine = value; }
        public int ToLine { get => toLine; set => toLine = value; }

        public void FilePathReader()
        {
            FilePath = 0;
            FromLine = "a";
            ToLine = "b";
        }


        public void Setup(string filePath, int fromLine, int toLine)
        {
            if (toLine < fromLine || fromLine < 1)
            {
                throw new System.ArgumentException("Invalid parameters");
            }
            else
            {
                FilePath = filePath;
                FromLine = fromLine;
                ToLine = toLine;
            }
        }

        public String Read()
        {
            FileInfo fileToRead = new FileInfo(FilePath);
            string text;
            FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))
            {
                text = streamReader.ReadToEnd();
            }
            return text;
        }





        public String ReadLines()
        {
            FileInfo fileToRead = new FileInfo(FilePath);
            string lines;
            int numOfLines = ToLine - (FromLine - 1);
            FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))
            {
                lines = streamReader.ReadLine().Skip(FromLine - 1).Take(numOfLines).ToString();
            }
            return lines;
        }

    }
}
