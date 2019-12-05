using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        bilgiguvenligi.Form1 nesne = new bilgiguvenligi.Form1();
        [TestMethod]
        public void Ceasar()
        {
            string sonuc = nesne.Ceasar("yasin",0);
            Assert.AreEqual("yasin", sonuc);
        }
        [TestMethod]
        public void Sutun()
        {
            string sonuc = nesne.Sutun("yasinevismek", 3);
            Assert.AreEqual("yivmaniesesk", sonuc);
        }
        [TestMethod]
        public void Cit()
        {
            string sonuc = nesne.Cit("yasin");
            Assert.AreEqual("ysnai",sonuc);
        }
        [TestMethod]
        public void PolybiusKucuk()
        {
            string sonuc = nesne.Polybius("yasin");
            Assert.AreEqual("43 00 32 13 23", sonuc);
        }
        [TestMethod]
        public void PolybiusBuyuk()
        {
            string sonuc = nesne.Polybius("YASİN");
            Assert.AreEqual("43 00 32 13 23", sonuc);
        }
        [TestMethod]
        public void MatrisYardimiyla()
        {
            string sonuc = nesne.MatrisYardimiyla("yasin");
            Assert.AreEqual("81350111510523197", sonuc);
        }
    }
}
