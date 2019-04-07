using System;
using System.Text;
using System.Collections.Generic;
using FilePartReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilePartReader
{
    /// <summary>
    /// Summary description for FileWordAnalyzer
    /// </summary>
    [TestClass]
    public class FileWordAnalyzerTest
    {
        public FileWordAnalyzerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        FileWordAnalyzer sut;

        [TestInitialize]
        public void TestSetup()
        {
            FilePartReader reader = new FilePartReader();
            reader.Setup(@"C:\Users\doram\OneDrive\Desktop\Test.txt", 1, 10);
            sut = new FileWordAnalyzer(reader);
        }

        [TestMethod]
        public void ShouldInstantializeWordAnalyzer()
        {
            Assert.IsNotNull(sut);
        }


        /*calls FilePartReader.ReadLines()
        returns the words ordered by alphabetically as an List<string>*/

        [TestMethod]
        public void ShouldWordByABCReturnListInAlphabeticalOrder()
        {
            var expectedResult = sut.WordByABC();
            Assert.AreEqual(expectedResult, "");
        }

        //How to assert with list?


    }
}
