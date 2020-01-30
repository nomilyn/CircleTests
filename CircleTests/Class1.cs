using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SENG8040A1;
using NUnit.Framework;


namespace CircleTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetArea_Input0_Results0()
        {
            //Arrange
            double radius = 0;

            double expectedResult = Math.Round(Math.PI * Math.Pow(radius,2), 2);

            Circle area = new Circle(radius);

            //Act
            double actualResult = area.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetArea_Input5point5_Results95point03()
        {
            //Arrange
            double radius = 5.5;

            double expectedResult = Math.Round(Math.PI * Math.Pow(radius, 2), 2);

            Circle area = new Circle(radius);

            //Act
            double actualResult = area.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetArea_Input10_Results314point16()
        {
            //Arrange
            double radius = 10;

            double expectedResult = Math.Round(Math.PI * Math.Pow(radius, 2), 2);

            Circle area = new Circle(radius);

            //Act
            double actualResult = area.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetCircumference_Input0_Results0()
        {
            //Arrange
            double radius = 0;
            
            double expectedResult = Math.Round((2 * Math.PI * radius),2);

            Circle circumference = new Circle(radius);

            //Act
            double actualResult = circumference.GetCircumference();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetCircumference_Input5_Results31point42()
        {
            //Arrange
            double radius = 5;

            double expectedResult = Math.Round((2 * Math.PI * radius), 2);

            Circle circumference = new Circle(radius);

            //Act
            double actualResult = circumference.GetCircumference();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetCircumference_Input20point75_Results130point38()
        {
            //Arrange
            double radius = 20.75;

            double expectedResult = Math.Round((2 * Math.PI * radius), 2);

            Circle circumference = new Circle(radius);

            //Act
            double actualResult = circumference.GetCircumference();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

