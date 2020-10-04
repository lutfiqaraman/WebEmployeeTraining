using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest.InfrastructureLayer
{
    [TestClass]
    public class InfrastrctureUnitTest
    {

        public List<string> StringList
        { get; set; }

        [TestMethod]
        public void TestMethod()
        {
            StringList = new List<string>()
            {
                "Test",
                "Unit"
            };

            Assert.IsNotNull(StringList);
            Assert.AreEqual(2, StringList.Count);
        }
    }
}