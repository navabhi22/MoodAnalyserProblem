using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace AnalyseMoodTesting
{
    [TestClass]
    public class MoodTesting
    {
        //TC-1.1
        [TestMethod]
        public void AnalyseMoodTest1()
        {
            //Arrange
            string Mood = "I am in Sad Mood";
            string expected = "Sad";
            //Act 

            AnalyseMood analyseMood = new AnalyseMood("I am in Sad Mood");
            string actual = analyseMood.AnalysingMood();


            //Assert
            Assert.AreEqual(actual, expected);

        }

        //TC-1.2
        [TestMethod]
        public void AnalyseMoodTest2()
        {
            //Arrange
            string Mood = "I am in Happy Mood";
            string expected = "Sad";
            //Act 

            AnalyseMood analyseMood = new AnalyseMood("I am in Happy Mood");
            string actual = analyseMood.AnalysingMood();


            //Assert
            Assert.AreEqual(actual, expected);

        }

        //TC-2.1
        [TestMethod]
        public void AnalyseMoodTest3()
        {
            //Arrange
            string Mood = null;
            string expected = "Happy";
            //Act 

            AnalyseMood analyseMood = new AnalyseMood(null);
            string actual = analyseMood.AnalysingMood();


            //Assert
            Assert.AreEqual(actual, expected);

        }

    }
}