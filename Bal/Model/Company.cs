using System;
using System.Collections.Generic;

namespace Bal.Model
{
    public class CompanyData
    {
        public int CompanyId { get; set; }
        public string Company { get; set; }
        public List<Device> Devices { get; set; }
    }

    public class Device
    {
        public int DeviceID { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public List<Sensor> SensorData { get; set; }
    }
    public class Sensor
    {
        public string SensorType { get; set; }
        public DateTime DateTime { get; set; }
        public double? Value { get; set; }
    }
}
