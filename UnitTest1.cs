using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace AnalyseMoodTesting
{
    [TestClass]
    public class MoodTesting
    {
        [TestMethod]
        public void AnalyseMoodTest1()
        {
            //Arrange
            string Mood = "I am in Sad Mood";
            string expected = "Sad";
            //Act 

            AnalyseMood analyseMood = new AnalyseMood();
            string actual = analyseMood.AnalysingMood("I am in Sad Mood");


            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void AnalyseMoodTest2()
        {
            //Arrange
            string Mood = "I am in Any Mood";
            string expected = "Happy";
            //Act 

            AnalyseMood analyseMood = new AnalyseMood();
            string actual = analyseMood.AnalysingMood("I am in Any Mood");


            //Assert
            Assert.AreEqual(actual, expected);

        }
    }
}