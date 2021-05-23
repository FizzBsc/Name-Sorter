using Microsoft.VisualStudio.TestTools.UnitTesting;
using Name_Sorter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Name_Sorter.Tests
{
    [TestClass()]
    public class FileImportTests
    {
        [TestMethod()]
        public void importNamesTest()
        {
            var givenNames = new List<String> {
                "John",
                "Thomas",
                "Tony",

            };
            var lastNames = new List<String> {
                "Wick",
                "Anderson",
                "Stark",

            };
            var names = new List<Name> { };
            for (int i = 0; i < givenNames.Count; ++i)
            {
                names.Add(new Name(givenNames[i], lastNames[i]));

            }
            var testNames = FileImport.importNames("../../../simpleimport.txt");

            Assert.AreEqual(testNames[0].ToString(), names[0].ToString());
            Assert.AreEqual(testNames[1].ToString(), names[1].ToString());
            Assert.AreEqual(testNames[2].ToString(), names[2].ToString());
        }
        [TestMethod()]
        public void importGivenNamesTest()
        {
            var givenNames = new List<String> {
                "John Bob",
                "Thomas Doe",
                "Tony Robert Downey",

            };
            var lastNames = new List<String> {
                "Wick",
                "Anderson",
                "Stark",

            };
            var names = new List<Name> { };
            for (int i = 0; i < givenNames.Count; ++i)
            {
                names.Add(new Name(givenNames[i], lastNames[i]));

            }
            var testNames = FileImport.importNames("../../../simplegivenimport.txt");

            Assert.AreEqual(testNames[0].givenNames, names[0].givenNames);
            Assert.AreEqual(testNames[1].givenNames, names[1].givenNames);
            Assert.AreEqual(testNames[2].givenNames, names[2].givenNames);


        }
        [TestMethod()]
        public void wrongFileException()
        {
            Assert.ThrowsException<InvalidFileException>(() => FileImport.importNames("../../../NoFile.txt"));
        }
    }
}