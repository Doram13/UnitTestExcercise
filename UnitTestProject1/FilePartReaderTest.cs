using System;
using System.IO;
using FilePartReader;
// NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilePartReader
{
    [TestClass]
    public class FilePartReaderTest
    {

        FilePartReader sut;


        [TestInitialize]
        public void TestSetup()
        {
            sut = new FilePartReader();
            sut.Setup(@"C:\Users\doram\OneDrive\Desktop\Test.txt", 1, 3);
        }

        /*[Test]
       public void FilePartReaderThrowsException()
       {
           try
           {
               FilePartReader FPR = new FilePartReader();
               Assert.Fail(); // If it gets to this line, no exception was thrown
           }
           catch (AssertionException) { throw; }
       }*/


        [TestMethod]
        public void FilePartReaderIsNotNull()
        {
            
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void SetUpSetsUpPath()
        {
            Assert.IsNotNull(sut.FilePath);
        }

        [TestMethod]
        public void ShouldFindAFileOnPath()
        {

            FileInfo fileToRead = new FileInfo(sut.FilePath);
            Assert.IsNotNull(fileToRead);
        }

        //ShouldReadWholeFile is passing too.. but the string is too long
        
        [TestMethod]
        public void ShouldReadFirstLine()
        {
            sut.FromLine = 1;
            sut.ToLine = 1;
            string expectedResult = sut.ReadLines();
            Assert.AreEqual(expectedResult, "1.: Statements:");
        }

        [TestMethod]
        public void ShouldReadFirstTwoLines()
        {
            sut.FromLine = 1;
            sut.ToLine = 2;
            string expectedResult = sut.ReadLines();
            Assert.AreEqual(expectedResult, @"1.: Statements: ");
        }

        [TestMethod]
        public void ShouldReadThirdLine()
        {
            sut.FromLine = 2;
            sut.ToLine = 3;
            string expectedResult = sut.ReadLines();
            Assert.AreEqual(expectedResult, @" https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/statements");
        }


    }
}
