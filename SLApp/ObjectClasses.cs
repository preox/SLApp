using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLApp
{
    #region Classes for handling stationrequests.
    public class stationMessage
    {
        [JsonProperty("StatusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("ExecutionTime")]
        public long ExecutionTime { get; set; }

        [JsonProperty("ResponseData")]
        public List<siteObject> stationObject { get; set; }
    }

    public class siteObject
    {
        [JsonProperty("Name")]
        private string Name { get; set; }
        [JsonProperty("SiteId")]
        private int SiteId { get; set; }
        [JsonProperty("Type")]
        private string Type { get; set; }
        [JsonProperty("X")]
        private string X { get; set; }
        [JsonProperty("Y")]
        private string Y { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + ", Siteid: " + SiteId + ", Type: " + Type;
        }

    }
    #endregion

    #region Classes for handling realtimerequests

    public class realTimeMessage
    {
        [JsonProperty("StatusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("ExecutionTime")]
        public long ExecutionTime { get; set; }

        [JsonProperty("ResponseData")]
        public DepartureObject DepartureObject { get; set; }
    }

    public class DepartureObject
    {
        [JsonProperty("LatestUpdate")]
        public string LatestUpdate { get; set; } // TODO: Ska vara "DAtetime" här egentligen

        [JsonProperty("DataAge")] // Data Age in seconds
        public int DataAge { get; set; }

        [JsonProperty("Buses")]
        public List<Buses> Buses { get; set; }

        [JsonProperty("Metros")]
        public List<Metros> Metros { get; set; }

        [JsonProperty("Trains")]
        public List<Trains> Trains { get; set; }

        [JsonProperty("Trams")]
        public List<Trams> Trams { get; set; }

        [JsonProperty("Ships")]
        public List<Ships> Ships { get; set; }

        [JsonProperty("StopPointDeviations")]
        public List<StopPointDeviations> StopPointDeviations { get; set; }

    }

    public class Deviation
    {
        [JsonProperty("Consequence")]
        private string Consequence { get; set; }

        [JsonProperty("ImportanceLevel")]
        private int ImportanceLevel { get; set; }

        [JsonProperty("Text")]
        private string Text { get; set; }
    }

    public class StopPointDeviations
    {
        [JsonProperty("StopInfo")]
        private StopInfo StopInfo { get; set; }

        [JsonProperty("Deviation")]
        private Deviation Deviation { get; set; }
    }

    public class StopInfo
    {
        [JsonProperty("GroupOfLine")]
        private string GroupOfLine { get; set; }

        [JsonProperty("StopAreaName")]
        private string StopAreaName { get; set; }

        [JsonProperty("StopAreaNumber")]
        private int StopAreaNumber { get; set; }
        [JsonProperty("TransportMode")]
        private string TransportMode { get; set; }
    }

    // Common stuff
    public class Vehicle
    {
        [JsonProperty("SiteID")]
        private int SiteID { get; set; }

        [JsonProperty("TransportMode")]
        private string TransportMode { get; set; }

        [JsonProperty("StopAreaName")]
        private string StopAreaName { get; set; }

        [JsonProperty("StopAreaNumber")]
        private int StopAreaNumber { get; set; }

        [JsonProperty("StopPointNumber")]
        private int StopPointNumber { get; set; }

        [JsonProperty("LineNumber")]
        private string LineNumber { get; set; }

        [JsonProperty("Destination")]
        private string Destination { get; set; }

        [JsonProperty("TimeTabledDateTime")]
        private string TimeTabledDateTime { get; set; } // TODO "DateTime egentligen

        [JsonProperty("ExpectedDateTime")]
        private string ExpectedDateTime { get; set; } // TODO "DateTime egentligen

        [JsonProperty("DisplayTime")]
        private string DisplayTime { get; set; }

        [JsonProperty("Deviations")]
        private List<Deviation> Deviations { get; set; }

        [JsonProperty("JourneyDirection")]
        private int JourneyDirection { get; set; }
    }



    public class Buses : Vehicle
    {
        [JsonProperty("GroupOfLine")]
        private string GroupOfLine { get; set; }

        [JsonProperty("StopPointDesignation")]
        private string StopPointDesignation { get; set; }
    }

    public class Trains : Vehicle
    {
        [JsonProperty("SecondaryDestinationName")]
        private string SecondaryDestinationName { get; set; }

        [JsonProperty("StopPointDesignation")]
        private string StopPointDesignation { get; set; }
    }

    public class Trams : Vehicle
    {
        [JsonProperty("GroupOfLine")]
        private string GroupOfLine { get; set; }

        [JsonProperty("StopPointDesignation")]
        private string StopPointDesignation { get; set; }
    }

    public class Ships : Vehicle
    {
        [JsonProperty("GroupOfLine")]
        private string GroupOfLine { get; set; }
    }

    public class Metros
    {
        [JsonProperty("DepartureGroupId")]
        public int DepartureGroupId { get; set; }

        [JsonProperty("Destination")]
        public string Destination { get; set; }

        [JsonProperty("DisplayTime")]
        public string DisplayTime { get; set; }

        [JsonProperty("GroupOfLine")]
        public string GroupOfLine { get; set; }

        [JsonProperty("GroupOfLineId")]
        public int GroupOfLineId { get; set; }

        [JsonProperty("JourneyDirection")]
        public int JourneyDirection { get; set; }

        [JsonProperty("LineNumber")]
        public string LineNumber { get; set; }

        [JsonProperty("PlatformMessage")]
        public string PlatformMessage { get; set; }

        [JsonProperty("SiteId")]
        public int SiteId { get; set; }

        [JsonProperty("StopAreaName")]
        public string StopAreaName { get; set; }

        [JsonProperty("TransportMode")]
        public string TransportMode { get; set; }
    }
    #endregion
}
