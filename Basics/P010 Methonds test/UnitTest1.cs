namespace P010_Methonds_test
{
    [TestClass]
    public class P010_Methods_tests
    {
        [TestMethod]
        public void kiekSakinyjeZodziuTest()
        {
            // Kiekvienas testas turi 3 dalykus: fake duomenis, expected rezultata ir actual rezultata
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = P010_Methods_Uzduotys.Program.kiekSakinyjeZodziu(fake);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void kiekSakinyjeZodziuTest1()
        {
            
            var fake = "as mokausi programuoti                          ";
            var expected = 3;
            var actual = P010_Methods_Uzduotys.Program.kiekSakinyjeZodziu(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void kiekSakinyjeZodziuTest2()
        {

            var fake = "as mokausi                            programuoti                          ";
            var expected = 3;
            var actual = P010_Methods_Uzduotys.Program.kiekSakinyjeZodziu(fake);

            Assert.AreEqual(expected, actual);
        }
    }
}