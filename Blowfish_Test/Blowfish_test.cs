using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlowfishLib;

namespace Blowfish_Test
{
    [TestClass]
    public class UnitTest1
    {
        private string key = "{123ABC9F-AFBC-36DC-8FF8-00BDAFF1584DGFQQ}";
        private string value = "BlowFish";
        private string encrypted = "NuLZ/cP9jQoCPmJ2vtTspA==";

        [TestMethod]
        public void Encipher()
        {
            Blowfish blowfish = new Blowfish(key);
            Assert.AreEqual(blowfish.Encipher(value), encrypted);
        }
        [TestMethod]
        public void Decipher()
        {
            Blowfish blowfish = new Blowfish(key);
            Assert.AreEqual(blowfish.Decipher(encrypted), value);
        }

    }
}
