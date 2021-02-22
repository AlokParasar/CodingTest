using Bal;
using Bal.Model;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            Console.WriteLine("Starting reading file TrackerDataFoo1.json");
            var partnerJson = File.ReadAllText("TrackerDataFoo1.json");
            var companyJson = File.ReadAllText("TrackerDataFoo2.json");
            var partner = JsonConvert.DeserializeObject<Partner>(partnerJson);
            var company = JsonConvert.DeserializeObject<CompanyData>(companyJson);

            var merge = new Merge();
            var partnerList = merge.GetMergedList(partner);
            var companyList = merge.GetMergedList(company);

            var mergedList = partnerList.Union(companyList).ToList();

            var tracker1 = mergedList.Where(m => m.TrackerId == 1).ToList();
            var tracker2 = mergedList.Where(m => m.TrackerId == 2).ToList();
            //average temperature and average humidity
            var averageTemperature1 = tracker1.Sum(t => t.AvgTemp) / tracker1.Count;
            var averageHumidity1 = tracker1.Sum(t => t.AvgHumidity) / tracker1.Count;
            var averageTemperature2 = tracker2.Sum(t => t.AvgTemp) / tracker2.Count;
            var averageHumidity2 = tracker2.Sum(t => t.AvgHumidity) / tracker2.Count;
            Console.WriteLine($"Tracker 1: Average Temperature {averageTemperature1} Tracker 1: Average Humidity {averageHumidity1}");
            Console.WriteLine($"Tracker 2: Average Temperature {averageTemperature2} Tracker 2: Average Humidity {averageHumidity2}");

            //Calculate the total record count for both temperature and humidity (when applicable) for each tracker
            Console.WriteLine($"Tracker 1: Total Temperature record count {tracker1.Where(t => t.AvgTemp != null).Count()} Tracker 1: Total Humidity record count {tracker1.Where(t => t.AvgHumidity != null).Count()}");
            Console.WriteLine($"Tracker 2: Total Temperature record count {tracker2.Where(t => t.AvgTemp != null).Count()} Tracker 2: Total Humidity record count {tracker2.Where(t => t.AvgHumidity != null).Count()}");
            
            //Calculate the time of the First and Last reported sensor record for each tracker (regardless of sensor type)
            Console.WriteLine($"Tracker 1: First reported sensor record {tracker1.OrderBy(t => t.FirstCrumbDtm).First().FirstCrumbDtm} Tracker 1: Last reported sensor record {tracker1.OrderBy(t => t.FirstCrumbDtm).Last().FirstCrumbDtm}");
            Console.WriteLine($"Tracker 2: First reported sensor record {tracker1.OrderBy(t => t.FirstCrumbDtm).First().FirstCrumbDtm} Tracker 2: Last reported sensor record {tracker1.OrderBy(t => t.FirstCrumbDtm).Last().FirstCrumbDtm}");
        }
    }
}
