using check_personal_nr;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestLengthYes()
        {
            

            string testString = "0009302561";

            bool expectedResult = true;

            bool actualResult = IsValid.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestLengthNo()
        {
            

            string testString = "000930256145";

            bool expectedResult = false;

            bool actualResult = IsValid.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestOnlyDigitsYes()
        {
           

            string testString = "0009307878";

            bool expectedResult = true;

            bool actualResult = IsValid.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void TestOnlyDigitsYNo()
        {
            

            string testString = "ölkorv6969";

            bool expectedResult = false;

            bool actualResult = IsValid.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void TestTwelveMonthsYes()
        {
            

            string testString = "0009307878";

            bool expectedResult = true;

            bool actualResult = IsValid.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestTwelveMonthsNo()
        {
            

            string testString = "0048307878";

            bool expectedResult = false;

            bool actualResult = IsValid.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestThirtyOneDaysYes()
        {
            

            string testString = "0009307878";

            bool expectedResult = true;

            bool actualResult = IsValid.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestThirtyOneDaysNo()
        {
            

            string testString = "0009897878";

            bool expectedResult = true;

            bool actualResult = IsValid.IsValidPersonalNumber(testString);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
