using Microsoft.VisualStudio.TestTools.UnitTesting;
using Name_Sorter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Name_Sorter.Tests
{
    [TestClass()]
    public class SortNameTests
    {
        [TestMethod()]
        public void sortTest()
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
            var sort = SortName.sort(names);
            for (int i = 0; i < givenNames.Count; ++i)
            {
                Console.WriteLine(sort[i].ToString());
            }

            var sortGivenNames = new List<String> {
                "Thomas",
                "Tony",
                "John",

            };
            var sortLastNames = new List<String> {
                "Anderson",
                "Stark",
                "Wick",

            };
            var sortNames = new List<Name> { };
            for (int i = 0; i < sortGivenNames.Count; ++i)
            {
                sortNames.Add(new Name(sortGivenNames[i], sortLastNames[i]));
                Console.WriteLine(sortNames[i].ToString());
            }
            Assert.AreEqual(sort[0].ToString(), sortNames[0].ToString());
            Assert.AreEqual(sort[1].ToString(), sortNames[1].ToString());
            Assert.AreEqual(sort[2].ToString(), sortNames[2].ToString());

        }
        [TestMethod()]
        public void sortGivenNameTest()
        {
            var givenNames = new List<String> {
                "John",
                "Thomas",
                "Tony",

            };
            var lastNames = new List<String> {
                "Wick",
                "Wick",
                "Stark",

            };
            var names = new List<Name> { };
            for (int i = 0; i < givenNames.Count; ++i)
            {
                names.Add(new Name(givenNames[i], lastNames[i]));

            }
            var sort = SortName.sort(names);
            for (int i = 0; i < givenNames.Count; ++i)
            {
                Console.WriteLine(sort[i].ToString());
            }

            var sortGivenNames = new List<String> {
                "Tony",
                "John",
                "Thomas",

            };
            var sortLastNames = new List<String> {
                "Stark",
                "Wick",
                "Wick",

            };
            var sortNames = new List<Name> { };
            for (int i = 0; i < sortGivenNames.Count; ++i)
            {
                sortNames.Add(new Name(sortGivenNames[i], sortLastNames[i]));
                Console.WriteLine(sortNames[i].ToString());
            }
            Assert.AreEqual(sort[0].ToString(), sortNames[0].ToString());
            Assert.AreEqual(sort[1].ToString(), sortNames[1].ToString());
            Assert.AreEqual(sort[2].ToString(), sortNames[2].ToString());

        }
    }
}