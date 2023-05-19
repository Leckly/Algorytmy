using Algorytmy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTests
{
    [TestClass]
    public class MatrixShiftBTests
    {
        [TestMethod]
        public void EncodeTest()
        {
            Assert.AreEqual("HECRN CEYI ISEP SGDI RNTO AAES RMPN SSRO EEBT ETIA EEHS", MatrixShiftB.Encode("HERE IS A SECRET MESSAGE ENCIPHERED BY TRANSPOSITION", "CONVENIENCE"));
        }

        [TestMethod]
        public void DecodeTest()
        {
            Assert.AreEqual("HEREISASECRETMESSAGEENCIPHEREDBYTRANSPOSITION", MatrixShiftB.Decode("HECRNCEYIISEPSGDIRNTOAAESRMPNSSROEEBTETIAEEHS", "CONVENIENCE"));
        }

        [TestMethod]
        public void EncodeTest2()
        {
            Assert.AreEqual("ACFJRAN", MatrixShiftB.Encode("FRANCJA", "BCADA"));
        }

        [TestMethod]
        public void DecodeTest2()
        {
            Assert.AreEqual("FRANCJA", MatrixShiftB.Decode("ACFJRAN", "BCADA"));
        }

        [TestMethod]
        public void EncodeTest3()
        {
            Assert.AreEqual("BIYNDDOZRE", MatrixShiftB.Encode("DOBRYDZIEN", "BCADA"));
        }

        [TestMethod]
        public void DecodeTest3()
        {
            Assert.AreEqual("DOBRYDZIEN", MatrixShiftB.Decode("BIYNDDOZRE", "BCADA"));
        }

        [TestMethod]
        public void EncodeTest4()
        {
            Assert.AreEqual("LHTIPEKOCAIN", MatrixShiftB.Encode("POLITECHNIKA", "BCADA"));
        }

        [TestMethod]
        public void DecodeTest4()
        {
            Assert.AreEqual("POLITECHNIKA", MatrixShiftB.Decode("LHTIPEKOCAIN", "BCADA"));
        }

        [TestMethod]
        public void EncodeTest5()
        {
            Assert.AreEqual("IIEYURNSVT", MatrixShiftB.Encode("UNIVERSITY", "BCADA"));
        }

        [TestMethod]
        public void DecodeTest5()
        {
            Assert.AreEqual("UNIVERSITY", MatrixShiftB.Decode("IIEYURNSVT", "BCADA"));
        }
    }
}
