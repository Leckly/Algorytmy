using Algorytmy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTests
{
    [TestClass]
    public class RailFenceTests
    {
        [TestMethod]
        public void EncodeTest()
        {
            Assert.AreEqual("CTARPORPYYGH", RailFence.Encode("CRYPTOGRAPHY", 3));
        }
        [TestMethod]
        public void DecodeTest()
        {
            Assert.AreEqual("CRYPTOGRAPHY", RailFence.Decode("CTARPORPYYGH", 3));
        }

        [TestMethod]
        public void EncodeTest2()
        {
            Assert.AreEqual("FCRNJAA", RailFence.Encode("FRANCJA", 3));
        }

        [TestMethod]
        public void DecodeTest2()
        {
            Assert.AreEqual("FRANCJA", RailFence.Decode("FCRNJAA", 3));
        }

        [TestMethod]
        public void EncodeTest3()
        {
            Assert.AreEqual("DYEORDINBZ", RailFence.Encode("DOBRYDZIEN", 3));
        }

        [TestMethod]
        public void DecodeTest3()
        {
            Assert.AreEqual("DOBRYDZIEN", RailFence.Decode("DYEORDINBZ", 3));
        }

        [TestMethod]
        public void EncodeTest4()
        {
            Assert.AreEqual("PTNOIEHIALCK", RailFence.Encode("POLITECHNIKA", 3));
        }

        [TestMethod]
        public void DecodeTest4()
        {
            Assert.AreEqual("POLITECHNIKA", RailFence.Decode("PTNOIEHIALCK", 3));
        }

        [TestMethod]
        public void EncodeTest5()
        {
            Assert.AreEqual("UETNVRIYIS", RailFence.Encode("UNIVERSITY", 3));
        }

        [TestMethod]
        public void DecodeTest5()
        {
            Assert.AreEqual("UNIVERSITY", RailFence.Decode("UETNVRIYIS", 3));
        }
    }
}
