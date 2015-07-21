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
     * Probably too many. But they'r needed to account 
     * for all possible variations of responses
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

    #region Signclasses

    // masterstopsign-class. other signs will ärva
    public class stopSign
    {
        private int siteID;
        private string transportMode;
        private string stopAreaName;
        private string lineNumber;
        private string destination;
        private string displayDime;
        private int journeyDirection;


        public string DisplayDime
        {
            get { return displayDime; }
            set { displayDime = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string LineNumber
        {
            get { return lineNumber; }
            set { lineNumber = value; }
        }

        public string StopAreaName
        {
            get { return stopAreaName; }
            set { stopAreaName = value; }
        }

        public int JourneyDirection
        {
            get { return journeyDirection; }
            set { journeyDirection = value; }
        }
        public int SiteID
        {
            get { return siteID; }
            set { siteID = value; }
        }
        public string TransportMode
        {
            get { return transportMode; }
            set { transportMode = value; }
        }
    }

    public class metroStopSign : stopSign
    {

        private List<Metros> metroList;
        
        // According to trafiklab's specc
        private string groupOfLine;
        private int groupOfLineId;
        private string platformMessage;
        private int departureGroupID;


        public int DepartureGroupID
        {
            get { return departureGroupID; }
            set { departureGroupID = value; }
        }

        public string PlatformMessage
        {
            get { return platformMessage; }
            set { platformMessage = value; }
        }

        public int GroupOfLineId
        {
            get { return groupOfLineId; }
            set { groupOfLineId = value; }
        }

        public string GroupOfLine
        {
            get { return groupOfLine; }
            set { groupOfLine = value; }
        }

        public List<Metros> MetroList
        {
            get { return metroList; }
            set { metroList = value; }
        }

    }

    public class busStopSign : stopSign
    {
        private List<Buses> busList;

        public List<Buses> BusList
        {
            get { return busList; }
            set { busList = value; }
        }


        private string groupOfLine;
        private string stopPointDesignation;

        public string StopPointDesignation
        {
            get { return stopPointDesignation; }
            set { stopPointDesignation = value; }
        }

        public string GroupOfLine
        {
            get { return groupOfLine; }
            set { groupOfLine = value; }
        }

    
    }

    public class trainStopSign : stopSign
    {
        private string stopPointDesignation;
        private string SecondaryDestinationName;
        private List<Trains> trainList;

        public List<Trains> TrainList
        {
            get { return trainList; }
            set { trainList = value; }
        }


        public string StopPointDesignation
        {
            get { return stopPointDesignation; }
            set { stopPointDesignation = value; }
        }

        public string SecondaryDestinationName1
        {
            get { return SecondaryDestinationName; }
            set { SecondaryDestinationName = value; }
        }


    
    }

    public class tramStopSign : stopSign
    {
        private string groupOfLine;
        private string stopPointDesignation;
        private List<Trams> tramList;

        public List<Trams> TramList
        {
            get { return tramList; }
            set { tramList = value; }
        }

        public string StopPointDesignation
        {
            get { return stopPointDesignation; }
            set { stopPointDesignation = value; }
        }
        public string GroupOfLine
        {
            get { return groupOfLine; }
            set { groupOfLine = value; }
        }
    }

    public class shipStopSign : stopSign
    {
        private List<Ships> shipList;
        private string GroupOfLine;

        public string GroupOfLine1
        {
            get { return GroupOfLine; }
            set { GroupOfLine = value; }
        }

        public List<Ships> ShipList
        {
            get { return shipList; }
            set { shipList = value; }
        }

    }
    
    #endregion



    public class departure
    { 
    
    }

    // Dumpa denna? 

    public class mainStationStopSign 
    {

        private int siteID;
        public int SiteID
        {
            get { return siteID; }
            set { siteID = value; }
        }

        private List<metroStopSign> metroSigns;
        private List<busStopSign> busSigns;
        private List<trainStopSign> trainSigns;
        private List<tramStopSign> tramSigns;
        private List<shipStopSign> shipSigns;

        public List<shipStopSign> ShipSigns
        {
            get { return shipSigns; }
            set { shipSigns = value; }
        }

        public List<tramStopSign> TramSigns
        {
            get { return tramSigns; }
            set { tramSigns = value; }
        }

        public List<trainStopSign> TrainSigns
        {
            get { return trainSigns; }
            set { trainSigns = value; }
        }

        public List<busStopSign> BusSigns
        {
            get { return busSigns; }
            set { busSigns = value; }
        }

        public List<metroStopSign> MetroSigns
        {
            get { return metroSigns; }
            set { metroSigns = value; }
        }


    }
    
}
