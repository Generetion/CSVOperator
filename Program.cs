// See https://aka.ms/new-console-template for more information
using CsvHelper;
using System.Globalization;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicFormatList = new List<BasicInfoFormat>();
            using (var reader = new StreamReader("MOCK_DATA.csv")) //it is the mock data
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var users = csv.GetRecords<BasicInfo>();
                IEnumerable<BasicInfo> records = csv.GetRecords<BasicInfo>();


                foreach (BasicInfo record in records)
                {
                    if (record.Name1 != "")
                    {

                        basicFormatList.Add(new BasicInfoFormat()
                        {
                            Flag1 = record.Flag1,
                            Flag2 = record.Flag2,
                            Flag3 = record.Flag3,
                            Flag4 = record.Flag4,
                            Flag5 = record.Flag5,
                            Name = record.Name1,
                            Address = record.Address1,
                            City = record.City1,
                            State = record.State1,
                            Zip = record.Zip1
                        });
                    }

                    if (record.Name2 != "")
                    {

                        basicFormatList.Add(new BasicInfoFormat()
                        {
                            Flag1 = record.Flag1,
                            Flag2 = record.Flag2,
                            Flag3 = record.Flag3,
                            Flag4 = record.Flag4,
                            Flag5 = record.Flag5,
                            Name = record.Name2,
                            Address = record.Address2,
                            City = record.City2,
                            State = record.State2,
                            Zip = record.Zip2
                        });
                    }

                    if (record.Name3 != "")
                    {

                        basicFormatList.Add(new BasicInfoFormat()
                        {
                            Flag1 = record.Flag1,
                            Flag2 = record.Flag2,
                            Flag3 = record.Flag3,
                            Flag4 = record.Flag4,
                            Flag5 = record.Flag5,
                            Name = record.Name3,
                            Address = record.Address3,
                            City = record.City3,
                            State = record.State3,
                            Zip = record.Zip3
                        });
                    }

                    if (record.Name4 != "")
                    {

                        basicFormatList.Add(new BasicInfoFormat()
                        {
                            Flag1 = record.Flag1,
                            Flag2 = record.Flag2,
                            Flag3 = record.Flag3,
                            Flag4 = record.Flag4,
                            Flag5 = record.Flag5,
                            Name = record.Name4,
                            Address = record.Address4,
                            City = record.City4,
                            State = record.State4,
                            Zip = record.Zip4
                        });
                    }
                }
            }
            using (var writer = new StreamWriter("Result.csv")) //should be a user inputo or config file containing the file name, but for testing pourpuse just change the name
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(basicFormatList);
            }
        }
    }
}