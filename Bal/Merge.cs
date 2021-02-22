using Bal.Model;
using System.Collections.Generic;
using System.Linq;

namespace Bal
{
    public class Merge
    {
        public List<Merged> GetMergedList(CompanyData company)
        {
            var companyList = new List<Merged>();
            
            if (company.Devices != null && company.Devices.Count > 0)
            foreach (var tracker in company.Devices)
            {
                foreach (var sensor in tracker.SensorData)
                {
                    var merged = new Merged
                    {
                        CompanyId = company.CompanyId,
                        CompanyName = company.Company
                    };
                    merged.FirstCrumbDtm = sensor.DateTime;
                    merged.TrackerId = tracker.DeviceID;
                    merged.TrackerName = tracker.Name;
                    merged.StartDate = tracker.StartDateTime;
                    merged.AvgTemp = sensor.SensorType == "TEMP" ? sensor.Value : null;
                    merged.AvgHumidity = sensor.SensorType.Equals("HUM") ? sensor.Value : null;
                    var match = companyList.Where(x => x.CompanyId == merged.CompanyId && x.FirstCrumbDtm == merged.FirstCrumbDtm).FirstOrDefault();
                    if (match == null)
                    {
                        companyList.Add(merged);
                    }
                    else
                    {
                        if (merged.AvgTemp.HasValue)
                            match.AvgTemp = merged.AvgTemp;

                        if (merged.AvgHumidity.HasValue)
                            match.AvgHumidity = merged.AvgHumidity;
                    }
                }
            }

            return companyList;
        }

        public List<Merged> GetMergedList(Partner partner)
        {
            var partnerList = new List<Merged>();
            if(partner.Trackers != null && partner.Trackers.Count > 0)
            foreach (var tracker in partner.Trackers)
            {
                foreach (var sensor in tracker.Sensors)
                {
                    foreach (var crumbs in sensor.Crumbs)
                    {
                        var merged = new Merged
                        {
                            CompanyId = partner.PartnerId,
                            CompanyName = partner.PartnerName
                        };
                        merged.FirstCrumbDtm = crumbs.CreatedDtm;
                        merged.TrackerId = tracker.Id;
                        merged.TrackerName = tracker.Model;
                        merged.StartDate = tracker.ShipmentStartDtm;
                        merged.AvgTemp = sensor.Name == "Temperature" ? crumbs.Value : null;
                        merged.AvgHumidity = sensor.Name.Equals("Humidty") ? crumbs.Value : null;
                        var match = partnerList.Where(x => x.CompanyId == merged.CompanyId && x.FirstCrumbDtm == merged.FirstCrumbDtm).FirstOrDefault();
                        if (match == null)
                        {
                            partnerList.Add(merged);
                        }
                        else
                        {
                            if (merged.AvgTemp.HasValue)
                                match.AvgTemp = merged.AvgTemp;

                            if (merged.AvgHumidity.HasValue)
                                match.AvgHumidity = merged.AvgHumidity;
                        }
                    }
                }
            }
            return partnerList;
        }

    }
}
