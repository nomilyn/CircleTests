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
        public void GetArea_Input0_Returns0()
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
        public void GetArea_Input5point5_Returns95point03()
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
        public void GetArea_Input10_Returns314point16()
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
        public void GetCircumference_Input0_Returns0()
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
        public void GetCircumference_Input5_Returns31point42()
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
        public void GetCircumference_Input20point75_Returns130point38()
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
        [Test]
        public void AddToRaidius_InputInitialRadius25AndNewRadius10_Returns35()
        {
            //Arrange
            double initialRadius = 25; double newRadius = 10; double expectedResult = 0;
            
            if (newRadius >= 0)
            {
                expectedResult = initialRadius + newRadius;
            }
            
            Circle addRadius = new Circle(newRadius);

            //Act
            double actualResult = addRadius.AddToRadius(initialRadius );

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void AddToRaidius_InputInitialRadius5point7AndNewRadius2point5_Returns8point2()
        {
            //Arrange
            double initialRadius = 5.7; double newRadius = 2.5; double expectedResult = 0;

            if (newRadius >= 0)
            {
                expectedResult = initialRadius + newRadius;
            }

            Circle addRadius = new Circle(newRadius);

            //Act
            double actualResult = addRadius.AddToRadius(initialRadius);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void AddToRaidius_InputInitialRadius0AndNewRadius10point75_Returns10point75()
        {
            //Arrange
            double initialRadius = 0; double newRadius = 10.75; double expectedResult = 0;

            if (newRadius >= 0)
            {
                expectedResult = initialRadius + newRadius;
            }

            Circle addRadius = new Circle(newRadius);

            //Act
            double actualResult = addRadius.AddToRadius(initialRadius);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SubtractFromRaidius_InputRadiusToSubtract2AndCurrentRadius5_Returns3()
        {
            //Arrange
            double currentRadius = 5; double radiusToSubtract = 2; double expectedResult = 0;

            //if (!(expectedResult - radiusToSubtract < 0) && radiusToSubtract >= 0)
            //{
                expectedResult = currentRadius - radiusToSubtract;
            //}

            Circle subtractRadius = new Circle(currentRadius);

            //Act
            double actualResult = subtractRadius.SubtractFromRadius(radiusToSubtract);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SubtractFromRaidius_InputRadiusToSubtract0AndCurrentRadius10_Returns10()
        {
            //Arrange
            double currentRadius = 10; double radiusToSubtract = 0; double expectedResult = 0;

            //if (!(expectedResult - radiusToSubtract < 0) && radiusToSubtract >= 0)
            //{
                expectedResult = currentRadius - radiusToSubtract;
            //}

            Circle subtractRadius = new Circle(currentRadius);

            //Act
            double actualResult = subtractRadius.SubtractFromRadius(radiusToSubtract);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SubtractFromRaidius_InputRadiusToSubtra10point25AndCurrentRadius15point75_Returns5point5()
        {
            //Arrange
            double currentRadius = 15.75; double radiusToSubtract = 10.25; double expectedResult = 0;

            //if (!(expectedResult - radiusToSubtract < 0) && radiusToSubtract >= 0)
            //{
            expectedResult = currentRadius - radiusToSubtract;
            //}

            Circle subtractRadius = new Circle(currentRadius);

            //Act
            double actualResult = subtractRadius.SubtractFromRadius(radiusToSubtract);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
