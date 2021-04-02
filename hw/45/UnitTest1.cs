using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using defaultp; // My namespace wont import? Not sure but test set up is correct.
using cars;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testla()
        {
            //arrange
            
            cars newcar1 = new cars();

            //act
            string make = "ford";
            string model = "civic";
            newcar1.Car1(make, model);

            //assert
            Assert.IsTrue(newcar1.Car1(make, model) == ("Tesla", "Model 3") );

        }
    }
}
