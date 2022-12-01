using Injection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InjectionTest
{
    /// <summary>
    /// Summary description for SampleTest
    /// </summary>
    [TestClass]
    public class SampleTest
    {
        public SampleTest()
        {
            
        }
        [TestMethod]
        public void SampleAdd_Price_LessThanZero_Failed_Test()
        {
            var product = new Product();
            product.price = -10;

            var sample = new Sample();
			var expected = new Response();
			var actual = sample.Add(product);

            expected.IsSucces = false;
            expected.Mesaage = "The product has not been add";
            
            Assert.AreEqual(expected.Mesaage, actual);
        }
    }
}
