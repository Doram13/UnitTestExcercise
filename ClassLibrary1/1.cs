﻿using System;
using System.IO;
using NUnit.Framework;
using NUnit;


namespace FilePartReader.Tests
{
    [TestFixture]
    public class FilePartReaderTest
    {
        FilePartReader sut;
       


        [SetUp]
        public void TestSetup()
        {
            sut = new FilePartReader();
            sut.Setup(@"‪C:\Users\doram\OneDrive\Desktop\.NET module\C# questions.txt", 1, 3);
        }

        [Test]
        public void FilePartReaderIsNotNull()
        {
            //FilePartReader sut = new FilePartReader();
            Assert.IsNotNull(sut);
        }

        [Test]
        public void SetUpSetsUpPath()
        {
            Assert.IsNotNull(sut.FilePath);
        }

        [Test]
        public void ShouldFindAFileOnPath()
        {
            var fileToRead = new FileInfo(sut.FilePath);
            Assert.IsNotNull(fileToRead);
        }


        //PM Warning] No test is available in C:\Users\doram\OneDrive\Desktop\.NET module\SI assignments\3rd week\SI assignments\FilePartReader\ClassLibrary1\bin\Debug\netstandard2.0\FilePartReader.Test.dll. Make sure that test discoverer & executors are registered and platform & framework version settings are appropriate and try again.




    }
}
