using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser_UC5;

namespace MoodAnalyzerTest.UC5
{
    [TestClass]
    public class MoodAnlyzerTest
    {
       
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyse();
            object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerTutorial.UseCases.UC5.MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);
        }

        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerApp.DemoClass", "DemoClass");

            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        [TestMethod]
        public void GivenImproperConstructorShouldThrowMoodAnalysisException()
        {

            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyse("DemoClass", "MoodAnalyse");
            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyse("HAPPY");
            object obj = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerTutorial.UseCases.UC5.MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);
        }

        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerTutorial.UseCases.UC5.DemoClass", "MoodAnalyse");

            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
     
        [TestMethod]
        public void GivenImproperConstructorNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerTutorial.UseCases.UC5.MoodAnalyse", "DemoConstructor");

            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}