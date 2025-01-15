
using check_personal_nr.Application;
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
            bool actualResult = LenghtChecker.NumberandLengthChecker(testString);

            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestLengthNo()
        {

            string testString = "00093025614";
            bool expectedResult = false;
            bool actualResult = LenghtChecker.NumberandLengthChecker(testString);

            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestOnlyDigitsYes()
        {
            string testString = "0009307878";
            bool expectedResult = true;

            bool actualResult = LenghtChecker.NumberandLengthChecker(testString);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestOnlyDigitsYNo()
        {
            string testString = "ölkorv6969";
            bool expectedResult = false;

            bool actualResult = LenghtChecker.NumberandLengthChecker(testString);
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestTwelveMonthsYes()
        {
            string teststring = "0009302918";
            int[] testArray = {0, 0, 0, 9, 3, 0, 2, 9, 4, 5};
            bool expectedResult = true;
            bool actualResult = DateChecker.DateofBirth(testArray);

            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestTwelveMonthsNo()
        {

            string teststring = "0014302918";
            int[] testArray = { 0, 0, 1, 4, 3, 0, 2, 9, 4, 5 };
            bool expectedResult = false;
            bool actualResult = DateChecker.DateofBirth(testArray);
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestControlNumberYes()
        {

            string testString = "0009302910";
            bool expectedResult = true;
            bool actualResult = ControlNumber.ConrtolCheckNumber(testString);
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestControlNumberNo()
        {
            string testString = "0009302917";
            bool expectedResult = false;
            bool actualResult = ControlNumber.ConrtolCheckNumber(testString);
            Assert.Equal(expectedResult, actualResult);
        }

    }
}
