using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void AreIntsEqual()
        {
            //arrange
            int a = 10;
            int b = 10;
            //act
            //assert
            Assert.AreEqual(a, b);
        }

        [Test]
        public void AreFloatsEqual()
        {
            //arrange
            float a = 3.4f;
            float b = 3.4f;
            //act
            //assert
            Assert.AreEqual(a, b);
        }


        [Test]
        public void AreStringsEqual()
        {
            //arrange
            string a = "Adam";
            string b = "Adam";
            //act
            //assert
            Assert.AreEqual(a, b);
        }

        public void AreEmployesNotEqual()
        {
            //arrange
            Employee a = new Employee("Adam","Jaki",44);
            Employee b = new Employee("Adam", "Jaki", 44);
            //act
            //assert
            Assert.AreNotEqual(a, b);
        }


    }
}
