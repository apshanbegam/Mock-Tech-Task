using Models;
using FluentAssertions;
using NUnit.Framework;
using Models.CsvHelper;

namespace Models.Test
{
    public class Tests
    {
        private ValidationPeople vp;
        [SetUp]
        public void Setup()
        {
            vp = new ValidationPeople();
            PeopleQueries people1 = new PeopleQueries();
        }

        
        [Test]
        public void IsComapnywithEsqTests()
        {
            //Arrange
            string companyName = "Elliott, John W Esq";
            string companyName1 = "Cap Gemini America";
            //Act
            var result1 = vp.IsComapnywithEsq(companyName);
            var result2 = vp.IsComapnywithEsq(companyName1);
            //Assert
            result1.Should().Be(true);
            result2.Should().Be(false);
        }

        [Test]
        public void IscountyisDerbyShireTests()
        {
            //Arrange
            string county1 = "Derbyshire";
            string county2 = "Kent";
            //Act
            var result1 = vp.IsCountyisDerbyshire(county1);
            var result2 = vp.IsCountyisDerbyshire(county2);
            //Assert
            result1.Should().Be(true);
            result2.Should().Be(false);
        }

        [Test]
        public void IsHouseNumberis3DigitsTest()
        {
            //Arrange
            string address1 = "505 Exeter Rd";
            string address2 = "9472 Lind St";
            //Act
            var result1 = vp.IsHosueNumber3Digit(address1);
            var result2 = vp.IsHosueNumber3Digit(address2);
            //Assert
            result1.Should().Be(true);
            result2.Should().Be(false);
        }

        [Test]
        public void IsLongerWebTest()
        {
            //Arrange
            string web1 = "http://www.alandrosenburgcpapc.co.uk";
            string web2 = "http://www.apshan.co.uk";
            //Act
            var result1 = vp.IsLongerWeb(web1);
            var result2 = vp.IsLongerWeb(web2);
            //Assert
            result1.Should().Be(true);
            result2.Should().Be(false);
        }

        [Test]
        public void IsPostCodeOneDigitTest()
        {
            //Arrange
            string postcode = "CT2 7PP";
            string postcode1 = "M56 3FN";
            //Act
            var result1 = vp.IsPostcodeOneDigit(postcode);
            var result2 = vp.IsPostcodeOneDigit(postcode1);
            //Assert
            result1.Should().Be(true);
            result2.Should().Be(false);
        }


        [Test]
        public void IsLargerPhoneNumberTest()
        {
            //Arrange
            string Phone1 = "12345-56789";
            string Phone2 = "01101-78786";
            //Act
            bool result1 = vp.IsLargePhoneNumber(Phone1,Phone2);
            //Assert
            result1.Should().Be(true);
        }
        [Test]
        public void IsLargerPhoneNumberTestNegative()
        {
            //Arrange
            string Phone1 = "01276-816806";
            string Phone2 = "22101-78786";
            //Act
            bool result1 = vp.IsLargePhoneNumber(Phone1, Phone2);
            //Assert
            result1.Should().Be(false);
        }

        [Test]
        public void MergeTests()
        {
            //Arrange
            List<PeopleElements> p1 = new List<PeopleElements>();
            CsvParserHelper cvb = new CsvParserHelper();

            p1 = cvb.CsvParser();

            var list1 = p1[0];
            var list2 = p1[1];

            //Act

            PeopleElements result = vp.ConcatTwoLists(list1, list2);

            //Result
            result.Phone2.Should().Be(list2.Phone2);
        }
    }


}

