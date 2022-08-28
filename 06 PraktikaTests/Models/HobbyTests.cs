using Microsoft.VisualStudio.TestTools.UnitTesting;
using P038_Praktika.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Praktika.Models.Tests
{
    [TestClass()]
    public class HobbyTests
    {
        [TestMethod()]
        public void EncodeCsvTest()
        {
            var fake = "1,Astrology,Astrologija";
            var hobby = new Hobby();
            hobby.EncodeCsv(fake);
            var expected = new Hobby(1, "Astrology", "Astrologija");

            Assert.AreEqual(expected.Text, hobby.Text);
            Assert.AreEqual(expected.TextLt, hobby.TextLt);
        }

        [TestMethod()]
        public void EncodeCsvTest2()
        {
            var fake = "2,Art,Menas";
            var hobby = new Hobby();
            hobby.EncodeCsv(fake);
            var expected = new Hobby(1, "Astrology", "Astrologija");

            Assert.AreNotEqual(expected.Text, hobby.Text);
            Assert.AreNotEqual(expected.TextLt, hobby.TextLt);
        }
    }
}