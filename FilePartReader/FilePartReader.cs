using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FilePartReader
{
    public class FilePartReader
    {

        //it sets the class' instance variables to some invalid default value
        public FilePartReader()
        {
            /*FilePath = 0;
            FromLine = "a";
            ToLine = "b";*/
        }

        public string FilePath { get; set; }
        public int FromLine { get; set; }
        public int ToLine { get; set; }




        /* it's parameters are: filePath as a string; fromLine as an int
toLine as an int. it should throws an ArgumentException:
if toLine is smaller than fromLine; if fromLine is smaller than 1*/

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
        /*opens the file on filePath , and gives back it's content as a String
it doesn't catch the exception being raised, if the file isn't present on filePath, so actually the method throws the exception it received
*/
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

        /*
reads the file with Read()
it gives back every line from it's content between fromLine and toLine (both of them are included), and returns these lines as a String. Take care because if fromLine is 1, it means the very first row in the file. Also, if fromLine is 1 and toLine is 1 also, we will read only the very first line.*/

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
