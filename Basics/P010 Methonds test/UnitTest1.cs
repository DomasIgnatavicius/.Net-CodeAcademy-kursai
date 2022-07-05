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

        [TestMethod]
        public void arYraZodisMokausiTest1()
        {

            var fake = " as labai mokausi programuoti     ";
            var expected = "Tiesa";
            var actual = P010_Methods_Uzduotys.Program.arYraZodisMokausi(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void arYraZodisMokausiTest2()
        {

            var fake = "aslabaimokausiprogramuoti";
            var expected = "Netiesa";
            var actual = P010_Methods_Uzduotys.Program.arYraZodisMokausi(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void arYraZodisMokausiTest3()
        {

            var fake = "mokausi programuoti labai    ";
            var expected = "Tiesa";
            var actual = P010_Methods_Uzduotys.Program.arYraZodisMokausi(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void arYraZodisMokausiTest4()
        {

            var fake = "as mokausi, labai stipriai";
            var expected = "Tiesa";
            var actual = P010_Methods_Uzduotys.Program.arYraZodisMokausi(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void arYraZodisMokausiTest5()
        {

            var fake = "as mokausi!";
            var expected = "Tiesa";
            var actual = P010_Methods_Uzduotys.Program.arYraZodisMokausi(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void arYraZodisMokausiTest6()
        {

            var fake = "as mokausi?";
            var expected = "Tiesa";
            var actual = P010_Methods_Uzduotys.Program.arYraZodisMokausi(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void arYraZodisMokausiTest7()
        {

            var fake = "as studijuoju (mokausi)";
            var expected = "Tiesa";
            var actual = P010_Methods_Uzduotys.Program.arYraZodisMokausi(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void arYraZodisMokausiTest8()
        {

            var fake = "as studijuojumokausi)";
            var expected = "Netiesa";
            var actual = P010_Methods_Uzduotys.Program.arYraZodisMokausi(fake);

            Assert.AreEqual(expected, actual);
        }
    }
}