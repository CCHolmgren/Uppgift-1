using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Scalene: triangle med tre olika sidor
        //Equilateral: liksidig triangel
        //Isosceles: likbent triangel
        [TestMethod]
        public void isScaleneTest()
        {
            Assert.IsTrue(new Triangle(1.0, 2.0, 3.0).isScalene());
            Assert.IsTrue(new Triangle(1.5, 1.6, 1.7).isScalene());

            Assert.IsFalse(new Triangle(1.0, 1.0, 1.0).isScalene());
            Assert.IsFalse(new Triangle(1.5, 1.5, 1.5).isScalene());
        }
    }
}
