namespace ChallengeApp.Tests
{
    public class Tests
    {


        [Test]
        public void CheckAddingPlusScores()
        {
            //arrange
            var user = new Employee("Adam", "Taki", 45);


            //act
            user.AddPoints(9);
            user.AddPoints(10);
            user.AddPoints(16);
            user.AddPoints(3);
            user.AddPoints(15);

            int result = user.Result;

            //assert
            Assert.AreEqual(53, result);
        }
        [Test]
        public void CheckAddingPlusAndMinusScores()
        {
            //arrange
            var user = new Employee("Adam", "Taki", 45);


            //act
            user.AddPoints(9);
            user.AddPoints(10);
            user.AddPoints(16);
            user.AddPoints(-3);
            user.AddPoints(-15);

            int result = user.Result;

            //assert
            Assert.AreEqual(17, result);
        }
    }
}