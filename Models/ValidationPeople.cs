using System;
using System.Text.RegularExpressions;
namespace Models
{
    public class ValidationPeople
    {
        public bool IsComapnywithEsq(string companyName)
        {
            if (companyName.Contains("Esq"))
                return true;
            else
                return false;
        }

        public bool IsCountyisDerbyshire(string county)
        {
            if (county.Equals("Derbyshire"))
                return true;
            else
                return false;
        }

        public bool IsHosueNumber3Digit(string address)
        {
            string pattern = "^\\d{3}\\s";
            if (Regex.IsMatch(address,pattern))
            {
                return true;
            }
            else return false;
        }

        public bool IsLongerWeb(string web)
        {
            if (web.Length > 35)
            {
                return true;
            }
            else return false;
        }

        public bool IsPostcodeOneDigit(string postcode)
        {
            var postsplit = postcode.Split(" ");
            var firstpart = postsplit[0].Reverse().ToList();
            if (Char.IsDigit(firstpart[0]) && Char.IsLetter(firstpart[1]))
            {
                return true;
            }
            else return false;
        }

        public bool IsLargePhoneNumber(string phone1,string phone2)
        {

            long p1 = Int64.Parse(String.Join("", phone1.Split("-")));
            long p2 = Int64.Parse(String.Join("", phone2.Split("-")));
           
            if (p1 > p2)
            {
                return true;
            }
            else return false;
        }

        public PeopleElements ConcatTwoLists(PeopleElements list1, PeopleElements list2)
        {
            var newRecord = new PeopleElements() {
               FirstName = list1.FirstName,
                LastName = list1.LastName,
                CompanyName = list1.CompanyName,
                Address = list1.Address,
                Phone1 = list1.Phone1,
                Phone2 = list2.Phone2,
                City= list2.City,
                County = list2.County,
                Email=list2.County,
                Web= list1.Web,
                Postal=list1.Postal

            };
            return newRecord;

        }

    }
}

