using check_personal_nr;
using Xunit;
using Xunit.Sdk;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestLengthYes()
        {
            Checker checker = new Checker();

            string testString = "0009302561";

            bool expectedResult = true;

            bool actualResult = checker.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestLengthNo()
        {
            Checker checker = new Checker();

            string testString = "000930256145";

            bool expectedResult = false;

            bool actualResult = checker.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestOnlyDigitsYes()
        {
            Checker checker = new Checker();

            string testString = "0009307878";

            bool expectedResult = true;

            bool actualResult = checker.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void TestOnlyDigitsYNo()
        {
            Checker checker = new Checker();

            string testString = "ölkorv6969";

            bool expectedResult = false;

            bool actualResult = checker.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void TestTwelveMonthsYes()
        {
            Checker checker = new Checker();

            string testString = "0009307878";

            bool expectedResult = true;

            bool actualResult = checker.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestTwelveMonthsNo()
        {
            Checker checker = new Checker();

            string testString = "0048307878";

            bool expectedResult = false;

            bool actualResult = checker.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestThirtyOneDaysYes()
        {
            Checker checker = new Checker();

            string testString = "0009307878";

            bool expectedResult = true;

            bool actualResult = checker.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestThirtyOneDaysNo()
        {
            Checker checker = new Checker();

            string testString = "0009897878";

            bool expectedResult = true;

            bool actualResult = checker.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
