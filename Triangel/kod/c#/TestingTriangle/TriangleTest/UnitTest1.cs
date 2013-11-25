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

        //If it is Equilateral all sides are the same
        //So we would expect a Triangle with all sides the same to return true
        [TestMethod]
        public void isEquilateralTest()
        {
            //These are expected to Assert to true
            Assert.IsTrue(new Triangle(1.0, 1.0, 1.0).isEquilateral());
            Assert.IsTrue(new Triangle(1.5, 1.5, 1.5).isEquilateral());

            //These shouldn't assert
            Assert.IsFalse(new Triangle(1.0, 2.0, 3.0).isEquilateral());
            Assert.IsFalse(new Triangle(1.5, 1.6, 1.7).isEquilateral());
        }
    }
}
