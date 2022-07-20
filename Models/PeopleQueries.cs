using System;
using System.Linq;
using System.Collections.Generic;
using Models.CsvHelper;


namespace Models
{
    public class PeopleQueries
    {
        
        ValidationPeople vp = new ValidationPeople();

        List<PeopleElements> Records = new List<PeopleElements>();
        

        public List<PeopleElements> Csvhelp()
        {
            
            CsvParserHelper cvb = new CsvParserHelper();

            Records = cvb.CsvParser();
            return Records;
        }
        

        public void RecordsWithCompanyEsq()
        {
            var CompanywithEsq = from record in Records where record.CompanyName.Contains("Esq") select record;
            int count = CompanywithEsq.Count();
            Console.WriteLine($"Count: {count}");

            for (int item = 0; item < Records.Count; item++)
            {
                string companyName = Records[item].CompanyName;
                if (vp.IsComapnywithEsq(companyName))
                {

                    Console.WriteLine($"{item + 2} - {Records[item].FirstName} {Records[item].LastName}  -  {Records[item].CompanyName}");

                }

            }
        }

        public void  PeopleinDerbyshire()
        {
           var PeopleinDerbyshireList = from record in Records where record.County.Contains("Derbyshire") select record;
           Console.WriteLine($"Count: {PeopleinDerbyshireList.Count()}");

            for (int item = 0; item < Records.Count; item++)
            {
                string county = Records[item].County;
                if (vp.IsCountyisDerbyshire(county))
                {

                    Console.WriteLine($"{item + 2} - {Records[item].FirstName} {Records[item].LastName}  -  {Records[item].CompanyName}");

                }
            }
            
        }

        public void HouseNumber3Digits()
        {
            int count = 0;
            string Address;

            foreach (var record in Records)
            {
                Address = record.Address;
                if(vp.IsHosueNumber3Digit(Address))
                {
                    count++;
                }
            }
            Console.WriteLine($"Count: {count}");

            for (int item = 0; item < Records.Count; item++)
            {
                Address = Records[item].Address;
                if (vp.IsHosueNumber3Digit(Address))
                {
                    Console.WriteLine($"{item + 2} - {Records[item].FirstName} {Records[item].LastName}  -  {Records[item].CompanyName}");

                }
            }
        }



        public void LongerWeb()
        {
            var LongerWebList = from record in Records where record.Web.Length > 35 select record;
            Console.WriteLine($"Count: {LongerWebList.Count()}");
            int item = 0;
            for (; item < Records.Count; item++)
            {
                string web = Records[item].Web;
                if (vp.IsLongerWeb(web))
                {
                    Console.WriteLine($"{item + 2} - {Records[item].FirstName} {Records[item].LastName}  -  {Records[item].CompanyName}");
                }
            }
           
        }

        
        public void LargerPhoneNumber()
        {
            int count = 0;
            string phone1;
            string phone2;
          
            foreach (var record in Records)
            {
                phone1 = record.Phone1;
                phone2 = record.Phone2;
                if (vp.IsLargePhoneNumber(phone1,phone2))
                {
                    count++;
                }
            }
            Console.WriteLine($"Count: {count}");


            for (int item = 0; item < Records.Count; item++)
            {
                phone1 = Records[item].Phone1;
                phone2 = Records[item].Phone2;
                if (vp.IsLargePhoneNumber(phone1, phone2))
                {
                    Console.WriteLine($"{item + 2} - {Records[item].FirstName} {Records[item].LastName}  -  {Records[item].CompanyName}");
                }
            }
        }

        public void OneDigitPostCode()
        {
            int count = 0;
            string postcode;

            foreach (var record in Records)
            {
                postcode = record.Postal;
                if (vp.IsPostcodeOneDigit(postcode))
                {
                    count++;
                }

            }
            Console.WriteLine($"Count: {count}");

            for (int item = 0; item < Records.Count; item++)
            {
                postcode = Records[item].Postal;
                if (vp.IsPostcodeOneDigit(postcode))
                {
                    Console.WriteLine($"{item + 2} - {Records[item].FirstName} {Records[item].LastName}  -  {Records[item].CompanyName}");
                }
            }
           
        }

        public  void MergePerson()
        {

            var partitions = Extensions.partition(Records, 2);
            Console.WriteLine($"Count: {partitions.Count()}");
            foreach (var record in partitions)
            {
                var list = vp.ConcatTwoLists(record[0], record[1]);
                Console.WriteLine($"{list.FirstName}   {list.Phone2}");
            }
        }



    }
}

