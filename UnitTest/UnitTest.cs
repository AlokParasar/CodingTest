using Bal;
using Bal.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string folder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\Assignment\\";
            var partnerJson = File.ReadAllText(folder + "TrackerDataFoo1.json");
            var companyJson = File.ReadAllText(folder + "TrackerDataFoo2.json");
            var partner = JsonConvert.DeserializeObject<Partner>(partnerJson);
            var company = JsonConvert.DeserializeObject<CompanyData>(companyJson);

            var merge = new Merge();
            var partnerList = merge.GetMergedList(partner);
            var companyList = merge.GetMergedList(company);

            var mergedList = partnerList.Union(companyList).ToList();
            Assert.AreEqual(mergedList.Count, 12);
        }


        [TestMethod]
        public void TestMethodNotEquual()
        {
            var merge = new Merge();
            var partner = new Partner();
            var company = new CompanyData();
            var partnerList = merge.GetMergedList(partner);
            var companyList = merge.GetMergedList(company);

            var mergedList = partnerList.Union(companyList).ToList();
            Assert.AreNotEqual(mergedList.Count, 12);
        }
    }
}
