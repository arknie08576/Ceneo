using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Ceneo.Tests
{
    public class ProductInFileTests
    {

        [Test]
        public void Test()
        {

            var p1 = new ProductInFile("Aparat");
            File.WriteAllText(p1.filename, "");
            p1.AddPoints("4");
            p1.AddPoints("73");
            p1.AddPoints("5");
            p1.AddPoints("99");
            p1.AddPoints("46");

            var result = p1.GetStatistics();

            Assert.AreEqual(result.Count, 5);
            Assert.AreEqual(result.Min, 4, 0.1);
            Assert.AreEqual(result.Max, 99, 0.1);
            Assert.AreEqual(result.Average, 45.4, 0.1);

        }



    }
}
