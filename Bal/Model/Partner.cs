using System;
using System.Collections.Generic;

namespace Bal.Model
{
    public class Partner
    {
        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public List<Trackers> Trackers { get; set; }
    }
        public class Trackers
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime ShipmentStartDtm { get; set; }
        public List<Sensors> Sensors { get; set; }
    }
    public class Sensors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Crumbs> Crumbs { get; set; }
    }
    public class Crumbs
    {
        public DateTime CreatedDtm { get; set; }
        public double? Value { get; set; }
    }
}
