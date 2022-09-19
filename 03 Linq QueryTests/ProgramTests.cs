using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Linq_Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Linq_Query.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void pirmaUzduotisTest()
        {
            var actual = Program.pirmaUzduotis();
            var expected = new int[]{ 0,2,4,6,8};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void antraUzduotisTest()
        {
            var actual = Program.antraUzduotis();
            var expected = new int[] {-2,-4,-7,-3,-8};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void treciaUzduotisTest()
        {
            var actual = Program.treciaUzduotis();
            var expected = new int[] {9,81,4,64,36,25};
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}