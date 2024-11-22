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
    }
}
