namespace Ceneo.Tests
{
    public class TypeTests
    {
        [Test]
        public void CompareTwoObjects()
        {
            var p1 = new ProductInFile("Aparat");
            var p2 = new ProductInFile("Komputer");
            Assert.AreNotEqual(p1, p2);

        }

        [Test]
        public void CompareTwoReferencesOnSameObj()
        {

            var p1 = new ProductInFile("Aparat");
            var p2 = p1;

            Assert.AreEqual(p1, p2);

        }

    }
}