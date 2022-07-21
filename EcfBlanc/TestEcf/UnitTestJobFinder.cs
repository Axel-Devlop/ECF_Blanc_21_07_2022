using EcfBlanc;

namespace TestEcf
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestJobFinder()
        {
            JobFinder jf = new JobFinder();

            JobSeeker js = new JobSeeker("jean", "jarre", DateTime.Now.Year, trainingLevel.InfBac, "Bac à sable", DateTime.Now.Year, jf);

            Assert.AreEqual(1, jf.JobSeekers.Count);


            Assert.AreEqual(30, JobFinder.CalculateEmployability(js));

            Assert.AreEqual(70, JobFinder.CalculateEmployability(js2));

        }


    }
}