using System;
using CsvHelper;
using System.IO;
using System.Linq;
using System.Globalization;



namespace Models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var people = new People();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("OPTION 1. Every person who has “Esq” in their company name.");
                Console.WriteLine("OPTION 2: Every person who lives in “Derbyshire”.");
                Console.WriteLine("OPTION 3: Every person whose house number is exactly three digits.");
                Console.WriteLine("OPTION 4: Every person whose website URL is longer than 35 characters");
                Console.WriteLine("OPTION 5: Every person who lives in a postcode area with a single-digit value.");
                Console.WriteLine("OPTION 6: Every person whose first phone number is numerically larger than their second phone number.");
                var opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        people.RecordsWithCompanyEsq();
                        break;
                    case "2":
                        people.PeopleinDerbyshire();
                        break;
                    case "3":
                        people.HouseNumber3Digits();
                        break;
                    case "4":
                        people.LongerWeb();
                        break;
                    case "5":
                        people.OneDigitPostCode();
                        break;
                    case "6":
                        people.LargerPhoneNumber();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
