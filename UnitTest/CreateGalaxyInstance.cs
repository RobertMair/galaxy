using galaxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CreateGalaxyInstance
    {
        [TestMethod]
        public void CreateGalaxy()
        {
            string name = "Test";
            uint lightYears = 10;

            var testGalaxy = new Galaxy(name, lightYears);
            Assert.AreEqual(name, testGalaxy.Name);
            Assert.AreEqual(lightYears, testGalaxy.LightYears);
        }
    }
}