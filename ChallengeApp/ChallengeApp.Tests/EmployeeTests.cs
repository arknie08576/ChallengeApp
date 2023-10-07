namespace ChallengeApp.Tests
{
    public class Tests
    {


        [Test]
        public void CheckMinScore()
        {
            //arrange
            var user = new Employee("Adam", "Taki", 45);
            //act
            user.AddPoints(9);
            user.AddPoints(10);
            user.AddPoints(16);
            user.AddPoints(3);
            user.AddPoints(15);

            var result = user.GetStatistics();
            //assert
            Assert.AreEqual(3, result.Min);
        }
        [Test]
        public void CheckMaxPlusScore()
        {
            //arrange
            var user = new Employee("Adam", "Taki", 45);
            //act
            user.AddPoints(9);
            user.AddPoints(10);
            user.AddPoints(16);
            user.AddPoints(3);
            user.AddPoints(15);

            var result = user.GetStatistics();
            //assert
            Assert.AreEqual(16, result.Max);
        }
        [Test]
        public void CheckAverageScore()
        {
            //arrange
            var user = new Employee("Adam", "Taki", 45);
            //act
            user.AddPoints(9);
            user.AddPoints(10);
            user.AddPoints(16);
            user.AddPoints(3);
            user.AddPoints(15);

            var result = user.GetStatistics();
            //assert
            Assert.AreEqual(10.6, result.Average, 0.1);



        }
    }
}