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
        [TestMethod]
        public void GivenNullMood_ShouldReturn_Happy()
        {
            string expected = "Happy";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(null);
            Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }
    }
}
