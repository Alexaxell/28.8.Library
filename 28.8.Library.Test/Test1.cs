using _28._8.Library;

namespace _28._8.Library.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test_GetPrezzoTotaleNoleggiDallaTarga()
        {
            var gestoreNoleggi = new GetsoreNoleggi();

            Assert.AreEqual(gestoreNoleggi.GetPrezzoTotaleNoleggiDallaTarga("D4F5NGNV"), 0);
        }
    }
}
