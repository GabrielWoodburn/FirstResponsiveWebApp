using System;
using Xunit;
using FirstResponsiveWebAppWoodburn.Models;

namespace AgeUnitTestingTests
{
    public class AgeUnitTests
    {
        [Fact]
        public void PassAgeThisYear()
        {
            // Tests a birthdate of 3/1/2000 with method AgeThisYear()
            // Arrange
            AgeModel age = new AgeModel();
            age.BirthDate = new DateTime(2000, 3, 1, 7, 0, 0);
            int expected = 20;

            // Act
            int actual = age.AgeThisYear();

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PassAgeThisYearTwo()
        {
            // Tests a birthdate of 2/9/2000 with method AgeThisYear()
            // Arrange
            AgeModel age = new AgeModel();
            age.BirthDate = new DateTime(2000, 2, 9, 12, 0, 0);
            int expected = 21;

            // Act
            int actual = age.AgeThisYear();

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PassAgeThisYearThree()
        {
            // Tests a birthdate of 6/9/1990 with method AgeThisYear()
            // Arrange
            AgeModel age = new AgeModel();
            age.BirthDate = new DateTime(1990, 6, 9, 23, 0, 0);
            int expected = 30;

            // Act
            int actual = age.AgeThisYear();

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PassAgeThisYearFour()
        {
            // Tests a birthdate of 12/31/2021 with method AgeThisYear()
            // Arrange
            AgeModel age = new AgeModel();
            age.BirthDate = new DateTime(2021, 12, 31, 23, 0, 0);
            int expected = 0;

            // Act
            int actual = age.AgeThisYear();

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PassAgeThisYearFive()
        {
            // Tests a birthdate of 2/9/2020 with method AgeThisYear()
            // Arrange
            AgeModel age = new AgeModel();
            age.BirthDate = new DateTime(2020, 2, 9, 12, 0, 0);
            int expected = 1;

            // Act
            int actual = age.AgeThisYear();

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PassAgeAtEndOfYear()
        {
            // Tests a birthdate of 12/31/2021 with method AgeByEndOfYear()
            // Arrange
            AgeModel age = new AgeModel();
            age.BirthDate = new DateTime(2021, 12, 31, 12, 0, 0);
            int expected = 0;

            // Act
            int actual = age.AgeByEndOfYear();

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PassAgeAtEndOfYearTwo()
        {
            // Tests a birthdate of 12/31/2000 with method AgeByEndOfYear()
            // Arrange
            AgeModel age = new AgeModel();
            age.BirthDate = new DateTime(2000, 12, 31, 12, 0, 0);
            int expected = 21;

            // Act
            int actual = age.AgeByEndOfYear();

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PassAgeAtEndOfYearThree()
        {
            // Tests a birthdate of 1/1/2000 with method AgeByEndOfYear()
            // Arrange
            AgeModel age = new AgeModel();
            age.BirthDate = new DateTime(2000, 1, 1, 12, 0, 0);
            int expected = 21;

            // Act
            int actual = age.AgeByEndOfYear();

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PassAgeAtEndOfYearFour()
        {
            // Tests a future birthdate of 1/1/2022 with method AgeByEndOfYear()
            // Arrange
            AgeModel age = new AgeModel();
            age.BirthDate = new DateTime(2022, 1, 1, 12, 0, 0);
            int expected = 0;

            // Act
            int actual = age.AgeByEndOfYear();

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PassAgeAtEndOfYearFive()
        {
            // Tests a future birthdate of 12/31/2022 with method AgeByEndOfYear()
            // Arrange
            AgeModel age = new AgeModel();
            age.BirthDate = new DateTime(2022, 12, 31, 12, 0, 0);
            int expected = -1;

            // Act
            int actual = age.AgeByEndOfYear();

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
