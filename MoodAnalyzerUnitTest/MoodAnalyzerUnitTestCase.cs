using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerApp;

namespace MoodAnalyzerUnitTest
{
    [TestClass]   
    public class MoodAnalyzerUnitTestCase
    { 
        [TestMethod]
        public void GivenMood_ShouldReturn_Sad()
        {
            string expected = "Sad";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am Sad");
            Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }
        [TestMethod]
        public void GivenMood_ShouldReturn_Happy()
        {
            string expected = "Happy";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am Happy");
            Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }
        //[TestMethod]
        //public void GivenNullMood_ShouldReturn_Happy()
        //{
        //  string expected = "Happy";
        //    MoodAnalyzer moodAnalyzer = new MoodAnalyzer(null);
        //    Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        //}
        [TestMethod]
        [DataRow("")]
        public void GivenEmptyMood_ShouldThrow_MoodAnalysisEmptyTypeException(string message)
        {
            try
            {
                string expected = "Happy";
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Message should not be Empty", e.Message);
            }
        }
        [TestMethod]
        [DataRow(null)]
        public void GivenNullMood_ShouldThrow_MoodAnalysisEmptyTypeException(string message)  
        {
            try
            {
                string expected = "Happy";
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Message should not be Null", e.Message);
            }
        }
        [TestMethod]
        public void GivenMooadAnalyzerClassName_WhenAnalyze_ShouldReturnObject()
        {
            object obj = new MoodAnalyzer(null);
            object actual = MoodAnalyzerReflection.CreateMoodAnalysis("MoodAnalyzerApp.MoodAnalyzer", "MoodAnalyzer");
            //obj.Equals(actual);
            Assert.AreEqual(obj.GetType().Equals(actual.GetType()), true);
        }
        [TestMethod]
        public void GivenMooadAnalyzerClassName_WhenAnalyze_ShouldReturnObjectWithParameter()
        {
            object obj = new MoodAnalyzer(null);
            object actual = MoodAnalyzerReflection.CreateMooadAnalyzeUsingParameterizedConstructor("MoodAnalyzerApp.MoodAnalyzer", "MoodAnalyzer");

            Assert.AreEqual(obj.GetType().Equals(actual.GetType()), true);
        }

    }
}
