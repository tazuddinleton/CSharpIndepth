using CSharpIndepth.Generics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpIndepth.Generics
{

    [TestClass]
    public class TestCircularBuffer
    {
        [TestMethod]
        public void Should_Insert_Items_When_Write_Method_Is_Called()
        {
            var buffer = new CircularBuffer<int>(3);
            var values = new List<int>() { 1, 2, 3 };
            values.ForEach(buffer.Write);

            Assert.AreEqual(values[0], buffer.Read());
            Assert.AreEqual(values[1], buffer.Read());
            Assert.AreEqual(values[2], buffer.Read());
        }

        [TestMethod]
        public void Should_Overwrite_When_Items_Exceeds_Capacity()
        {
            var buffer = new CircularBuffer<int>(3);
            var values = new List<int>() { 1, 2, 3, 4, 5 };
            values.ForEach(buffer.Write);

            Assert.AreEqual(values[2], buffer.Read());
            Assert.AreEqual(values[3], buffer.Read());
            Assert.AreEqual(values[4], buffer.Read());
        }
    }
}
