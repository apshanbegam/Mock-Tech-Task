using System;
using CsvHelper;
using System.IO;
using System.Globalization;
namespace Models.CsvHelper
{
    public class CsvParserHelper
    {

        public List<PeopleElements> Records;

        public List<PeopleElements> CsvParser()
        {
            using (var streamReader = new StreamReader(@"input.csv"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    Records = csvReader.GetRecords<PeopleElements>().ToList();

                }
            }
            return Records;
        }
    }
}

