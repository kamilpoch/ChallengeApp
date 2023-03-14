using System.Reflection.Metadata;

namespace ChallengeApp.Test1
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeAddScore_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Kamil", "Kowalski", 40);
            employee.AddScore(5);
            employee.AddScore(5);
            employee.AddScore(-7);

            // act
            var result = employee.Result;

            ///assert
            Assert.AreEqual(3, result);
        }
    }
}