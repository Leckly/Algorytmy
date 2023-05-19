using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorytmy;

namespace AlgorithmsTests
{
    [TestClass]
    public class MatrixShiftATests
    {
        [TestMethod]
        public void EncodeTest()
        {
            Assert.AreEqual("YCPRGTROHAYPAOS", MatrixShiftA.Encode("CRYPTOGRAPHYOSA", "3-1-4-2"));
        }

        [TestMethod]
        public void DecodeTest()
        {
            Assert.AreEqual("CRYPTOGRAPHYOSA", MatrixShiftA.Decode("YCPRGTROHAYPAOS", "3-1-4-2"));
        }

        [TestMethod]
        public void EncodeTest2()
        {
            Assert.AreEqual("ANFCRJA", MatrixShiftA.Encode("FRANCJA", "3-4-1-5-2"));
        }

        [TestMethod]
        public void DecodeTest2()
        {
            Assert.AreEqual("FRANCJA", MatrixShiftA.Decode("ANFCRJA", "3-4-1-5-2"));
        }

        [TestMethod]
        public void EncodeTest3()
        {
            Assert.AreEqual("BRDYOIEDNZ", MatrixShiftA.Encode("DOBRYDZIEN", "3-4-1-5-2"));
        }

        [TestMethod]
        public void DecodeTest3()
        {
            Assert.AreEqual("DOBRYDZIEN", MatrixShiftA.Decode("BRDYOIEDNZ", "3-4-1-5-2"));
        }

        [TestMethod]
        public void EncodeTest4()
        {
            Assert.AreEqual("LIPTOHNEICKA", MatrixShiftA.Encode("POLITECHNIKA", "3-4-1-5-2"));
        }

        [TestMethod]
        public void DecodeTest4()
        {
            Assert.AreEqual("POLITECHNIKA", MatrixShiftA.Decode("LIPTOHNEICKA", "3-4-1-5-2"));
        }

        [TestMethod]
        public void EncodeTest5()
        {
            Assert.AreEqual("IVUENITRYS", MatrixShiftA.Encode("UNIVERSITY", "3-4-1-5-2"));
        }

        [TestMethod]
        public void DecodeTest5()
        {
            Assert.AreEqual("UNIVERSITY", MatrixShiftA.Decode("IVUENITRYS", "3-4-1-5-2"));
        }
    }
}
