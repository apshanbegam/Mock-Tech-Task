﻿using System;
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
            string HouseNumber = AddressSplit(address);
            if (HouseNumber.Length == 3)
            {
                return true;
            }
            else return false;
        }


        public string AddressSplit(string address)
        {

            List<string> AddressSplit = address.Split(" ").ToList();
           
            string HouseNumber = AddressSplit[0];
            return HouseNumber;
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


    }
}
