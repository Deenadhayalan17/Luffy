using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luffy
{
    [TestFixture]
    class GradingCalculatorNUnit
    {
        private  Gradingcalculator GCalculator { get; set; }
        [SetUp]
        public void Setup()
        {
            GCalculator = new Gradingcalculator();

        }
        [Test]

        public void GetGrade_Score95Attendance90_returnA()
        {
            //arrange
            GCalculator.Score = 95;
            GCalculator.AttendancePercentage = 90;
            //act
            var output=  GCalculator.GetGrade();
            //assert
            Assert.AreEqual("A", output);
        }
        [Test]
        public void GetGrade_Score85Attendance90_returnB()
        {
            //arrange
            GCalculator.Score = 85;
            GCalculator.AttendancePercentage = 90;
            //act
            var output = GCalculator.GetGrade();
            //assert
            Assert.AreEqual("B", output);
        }
        [Test]
        public void GetGrade_Score65Attendance90_returnC()
        {
            //arrange
            GCalculator.Score = 65;
            GCalculator.AttendancePercentage = 90;
            //act
            var output = GCalculator.GetGrade();
            //assert
            Assert.AreEqual("C", output);
        }
        [Test]
        public void GetGrade_Score95Attendance65_returnB()
        {
            //arrange
            GCalculator.Score = 95;
            GCalculator.AttendancePercentage = 65;
            //act
            var output = GCalculator.GetGrade();
            //assert
            Assert.AreEqual("B", output);
        }
        [Test]
        [TestCase(95,55)]
        [TestCase(65, 55)]
        [TestCase( 55, 90)]
        public void GetGrade_ScoreAttendance_returnF(int score, int attendance)
        {
            //arrange
            GCalculator.Score = score;
            GCalculator.AttendancePercentage = attendance;
            //act
            var output = GCalculator.GetGrade();
            //assert
            Assert.AreEqual("F", output);
        }

        [Test]
        [TestCase(95,90,ExpectedResult ="A")]
        [TestCase(85, 90, ExpectedResult = "B")]
        [TestCase(65, 90, ExpectedResult = "C")]
        [TestCase(95, 65, ExpectedResult = "B")]
        [TestCase(95, 55, ExpectedResult = "F")]
        [TestCase(65, 55, ExpectedResult = "F")]
        [TestCase(50, 90, ExpectedResult = "F")]

        public string Get_Grade_scoreAttendanceAll_ReturnGrade(int score, int attendance)
        {
            //arrange
            GCalculator.Score = score;
            GCalculator.AttendancePercentage = attendance;
            //act
            var output = GCalculator.GetGrade();
            //assert
            // Assert.AreEqual("F", output);
            return output;
        }


    }
}
