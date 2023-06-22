using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SkillsTest;

namespace SkillsTest
{
    [TestFixture]
    public class UnitTesting
    {
        public string ShouldBeSortedAscending(string tbinput, string cbstrategy)
        {
            return Logic.SortString(tbinput, cbstrategy);
        }

        [Test]
        public void SortString_ShouldReturnAscendingLowerCaseString()
        {
            // Arrange
            string input = "eabhdc";
            string strategy = "Ascending";
            string expected = "abcdeh";

            // Act
            string result = Logic.SortString(input, strategy);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SortString_ShouldReturnDescendingLowerCaseString()
        {
            // Arrange
            string input = "eabhdc";
            string strategy = "Descending";
            string expected = "hedcba";

            // Act
            string result = Logic.SortString(input, strategy);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SortString_ShouldReturnAscendingUpperAndLowerCaseString()
        {
            // Arrange
            string input = "hEbDcA";
            string strategy = "Ascending";
            string expected = "AbcDEh";

            // Act
            string result = Logic.SortString(input, strategy);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SortString_ShouldReturnDescendingUpperAndLowerCaseString()
        {
            // Arrange
            string input = "hEbDcA";
            string strategy = "Descending";
            string expected = "hEDcbA";

            // Act
            string result = Logic.SortString(input, strategy);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SortString_ShouldReturAscendingUpperAndLowerCaseWithNumbersString()
        {
            // Arrange
            string input = "78hEbDc31A";
            string strategy = "Ascending";
            string expected = "1378AbcDEh";

            // Act
            string result = Logic.SortString(input, strategy);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SortString_ShouldReturnDescendingUpperAndLowerCaseWithNumbersString()
        {
            // Arrange
            string input = "78hEbDc31A";
            string strategy = "Descending";
            string expected = "hEDcbA8731";

            // Act
            string result = Logic.SortString(input, strategy);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SortString_ShouldReturAscendingUpperAndLowerCaseWithNumbersAndSymbolsString()
        {
            // Arrange
            string input = "78h_EbD!c31A@";
            string strategy = "Ascending";
            string expected = "!1378@_AbcDEh";

            // Act
            string result = Logic.SortString(input, strategy);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SortString_ShouldReturDescendingUpperAndLowerCaseWithNumbersAndSymbolsString()
        {
            // Arrange
            string input = "78h_EbD!c31A@";
            string strategy = "Descending";
            string expected = "hEDcbA_@8731!";

            // Act
            string result = Logic.SortString(input, strategy);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}
