using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLApp
{
    /*
     * Lot's of little classes.
     * Probably too many. But they do make life easier when 
     * deserializing the Json-object. 
     * 
     */

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
        public List<siteObject> ResponseData { get; set; }
    }

    public class siteObject
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("SiteId")]
        public int SiteId { get; set; }
        [JsonProperty("Type")]
        public string Type { get; set; }
        [JsonProperty("X")]
        public string X { get; set; }
        [JsonProperty("Y")]
        public string Y { get; set; }

        public override string ToString()
        {
            return Name + ", Siteid: " + SiteId ;
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
        public string Consequence { get; set; }

        [JsonProperty("ImportanceLevel")]
        public int ImportanceLevel { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class StopPointDeviations
    {
        [JsonProperty("StopInfo")]
        public StopInfo StopInfo { get; set; }

        [JsonProperty("Deviation")]
        public Deviation Deviation { get; set; }
    }

    public class StopInfo
    {
        [JsonProperty("GroupOfLine")]
        public string GroupOfLine { get; set; }

        [JsonProperty("StopAreaName")]
        public string StopAreaName { get; set; }

        [JsonProperty("StopAreaNumber")]
        public int StopAreaNumber { get; set; }
        [JsonProperty("TransportMode")]
        public string TransportMode { get; set; }
    }

    // Common stuff
    public class Vehicle
    {
        [JsonProperty("SiteID")]
        public int SiteID { get; set; }

        [JsonProperty("TransportMode")]
        public string TransportMode { get; set; }

        [JsonProperty("StopAreaName")]
        public string StopAreaName { get; set; }

        [JsonProperty("StopAreaNumber")]
        public int StopAreaNumber { get; set; }

        [JsonProperty("StopPointNumber")]
        public int StopPointNumber { get; set; }

        [JsonProperty("LineNumber")]
        public string LineNumber { get; set; }

        [JsonProperty("Destination")]
        public string Destination { get; set; }

        [JsonProperty("TimeTabledDateTime")]
        public string TimeTabledDateTime { get; set; } // TODO "DateTime egentligen

        [JsonProperty("ExpectedDateTime")]
        public string ExpectedDateTime { get; set; } // TODO "DateTime egentligen

        [JsonProperty("DisplayTime")]
        public string DisplayTime { get; set; }

        [JsonProperty("Deviations")]
        public List<Deviation> Deviations { get; set; }

        [JsonProperty("JourneyDirection")]
        public int JourneyDirection { get; set; }
    }

    public class Buses : Vehicle
    {
        [JsonProperty("GroupOfLine")]
        public string GroupOfLine { get; set; }

        [JsonProperty("StopPointDesignation")]
        public string StopPointDesignation { get; set; }
    }

    public class Trains : Vehicle
    {
        [JsonProperty("SecondaryDestinationName")]
        public string SecondaryDestinationName { get; set; }

        [JsonProperty("StopPointDesignation")]
        public string StopPointDesignation { get; set; }
    }

    public class Trams : Vehicle
    {
        [JsonProperty("GroupOfLine")]
        public string GroupOfLine { get; set; }

        [JsonProperty("StopPointDesignation")]
        public string StopPointDesignation { get; set; }
    }

    public class Ships : Vehicle
    {
        [JsonProperty("GroupOfLine")]
        public string GroupOfLine { get; set; }
    }

    public class Metros : Vehicle
    {
        [JsonProperty("DepartureGroupId")]
        public int DepartureGroupId { get; set; }

        [JsonProperty("GroupOfLine")]
        public string GroupOfLine { get; set; }

        [JsonProperty("GroupOfLineId")]
        public int GroupOfLineId { get; set; }

        [JsonProperty("PlatformMessage")]
        public string PlatformMessage { get; set; }

        [JsonProperty("SiteId")]
        public int SiteId { get; set; }


    }
    #endregion

}
