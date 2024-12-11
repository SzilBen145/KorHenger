using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KorHenger_UnitTest
{
    [TestClass]
    public class Kor_Test
    {
        [TestMethod]
        public void Kerület_Teszt()
        {
            double sugár = 5;
            Kör kör = new Kör(sugár);
            kör.SetKerület();
            double vártEredm = 31.4;
        }
        [TestMethod]
        public void Terület_Teszt()
        {
            double sugar = 10;
            Kor kor = new Kor(sugar);
            double vártEredm = 314.16;
            kor.SetTerület();
            double kapottEredm = kor.GetTerület();
 
            Assert.AreEqual(vártEredm, kapottEredm);
        }
    }
}
