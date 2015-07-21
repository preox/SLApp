using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace SLApp
{
    public partial class MainForm : Form
    {
        Timer blockTimer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            Bitmap bmp = SLApp.Properties.Resources.sl_logo;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            blockTimer.Enabled = false;
            blockTimer.Interval = 100;
            blockTimer.Tick += new EventHandler(blockTimer_Tick);


        }


        // MYCKET hjälp hittad på http://stackoverflow.com/questions/11126242/using-jsonconvert-deserializeobject-to-deserialize-json-to-a-c-sharp-poco-class
        private void button1_Click(object sender, EventArgs e)
        {
            #region json-lek med stations-förfrågan
            // api.sl.se/api2/typeahead.<FORMAT>?key=<DIN NYCKEL>&searchstring=<SÖKORD>&stationsonly=<ENDAST STATIONER>&maxresults=<MAX ANTAL SVAR>

            //Exempel-svar på stations-request: 
            /* 
            {"StatusCode":0,"Message":null,"ExecutionTime":0,"ResponseData":[{"Name":"Akalla (Stockholm)","SiteId":"9300","Type":"Station","X":"17913281","Y":"59415461"},{"Name":"Akalla centrum (Stockholm)","SiteId":"9300","Type":"Station","X":"17913281","Y":"59415461"},{"Name":"Kallhäll (Järfälla)","SiteId":"9701","Type":"Station","X":"17805949","Y":"59453638"},{"Name":"Kallhälls centrum (Järfälla)","SiteId":"9701","Type":"Station","X":"17805949","Y":"59453638"},{"Name":"Kallhälls station (Järfälla)","SiteId":"9701","Type":"Station","X":"17805949","Y":"59453638"},{"Name":"AKA","SiteId":"9300","Type":"Station","X":"17913281","Y":"59415461"},{"Name":"Odengatan/Valhallavägen (Stockholm)","SiteId":"1082","Type":"Station","X":"18065890","Y":"59346622"},{"Name":"Valhallavägen/Odengatan (Stockholm)","SiteId":"1082","Type":"Station","X":"18065890","Y":"59346622"},{"Name":"Kärnmakargränd (Järfälla)","SiteId":"5772","Type":"Station","X":"17805904","Y":"59457539"},{"Name":"Valla torg (Stockholm)","SiteId":"1525","Type":"Station","X":"18049045","Y":"59293981"}]}
            */
            /*
            string jsonTest2 =  "{\"StatusCode\":0,\"Message\":null,\"ExecutionTime\":0,\"ResponseData\":[" + 
                                "{\"Name\":\"Akalla (Stockholm)\",\"SiteId\":\"9300\",\"Type\":\"Station\",\"X\":\"17913281\",\"Y\":\"59415461\"}," + 
                                "{\"Name\":\"Akalla centrum (Stockholm)\",\"SiteId\":\"9300\",\"Type\":\"Station\",\"X\":\"17913281\",\"Y\":\"59415461\"}," +  
                                "{\"Name\":\"Kallhäll (Järfälla)\",\"SiteId\":\"9701\",\"Type\":\"Station\",\"X\":\"17805949\",\"Y\":\"59453638\"}," + 
                                "{\"Name\":\"Kallhälls centrum (Järfälla)\",\"SiteId\":\"9701\",\"Type\":\"Station\",\"X\":\"17805949\",\"Y\":\"59453638\"}," + 
                                "{\"Name\":\"Kallhälls station (Järfälla)\",\"SiteId\":\"9701\",\"Type\":\"Station\",\"X\":\"17805949\",\"Y\":\"59453638\"}," + 
                                "{\"Name\":\"AKA\",\"SiteId\":\"9300\",\"Type\":\"Station\",\"X\":\"17913281\",\"Y\":\"59415461\"}," + 
                                "{\"Name\":\"Odengatan/Valhallavägen (Stockholm)\",\"SiteId\":\"1082\",\"Type\":\"Station\",\"X\":\"18065890\",\"Y\":\"59346622\"}," + 
                                "{\"Name\":\"Valhallavägen/Odengatan (Stockholm)\",\"SiteId\":\"1082\",\"Type\":\"Station\",\"X\":\"18065890\",\"Y\":\"59346622\"}," + 
                                "{\"Name\":\"Kärnmakargränd (Järfälla)\",\"SiteId\":\"5772\",\"Type\":\"Station\",\"X\":\"17805904\",\"Y\":\"59457539\"}," + 
                                "{\"Name\":\"Valla torg (Stockholm)\",\"SiteId\":\"1525\",\"Type\":\"Station\",\"X\":\"18049045\",\"Y\":\"59293981\"}]}";


            var test = JsonConvert.DeserializeObject<stationMessage>(jsonTest2);
            Console.WriteLine("Stationsförfrågan: ");
            foreach (siteObject st in test.stationObject)
            {
                Console.WriteLine(st);
            }
            */

            #endregion

            #region json-lek med realtidsinfo
            // api.sl.se/api2/realtimedepartures.<FORMAT>?key=<DIN API NYCKEL>&siteid=<SITEID>&timewindow=<TIMEWINDOW>
            Console.WriteLine("\n\n###Realtidsförfrågan ");

             string json2 = "{\"StatusCode\":0,\"Message\":null,\"ExecutionTime\":1912,\"ResponseData\":" +
                                        "{\"LatestUpdate\":\"2015-07-14T08:35:22\",\"DataAge\":23," +
                                        "\"Metros\":[ {\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans gröna linje\",\"DisplayTime\":\"Nu\",\"SafeDestinationName\":\"Alvik\",\"GroupOfLineId\":1,\"DepartureGroupId\":1,\"PlatformMessage\":null,\"TransportMode\":\"METRO\",\"LineNumber\":\"19\",\"Destination\":\"Alvik\",\"JourneyDirection\":1,\"SiteId\":9001}," +
                                        "{\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans gröna linje\",\"DisplayTime\":\"3 min\",\"SafeDestinationName\":\"Åkeshov\",\"GroupOfLineId\":1,\"DepartureGroupId\":1,\"PlatformMessage\":null,\"TransportMode\":\"METRO\",\"LineNumber\":\"17\",\"Destination\":\"Åkeshov\",\"JourneyDirection\":1,\"SiteId\":9001}," +
                                        "{\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans gröna linje\",\"DisplayTime\":\"7 min\",\"SafeDestinationName\":\"Alvik\",\"GroupOfLineId\":1,\"DepartureGroupId\":1,\"PlatformMessage\":null,\"TransportMode\":\"METRO\",\"LineNumber\":\"19\",\"Destination\":\"Alvik\",\"JourneyDirection\":1,\"SiteId\":9001}," +
                                        "{\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans gröna linje\",\"DisplayTime\":\"Nu\",\"SafeDestinationName\":\"Skarpnäck\",\"GroupOfLineId\":1,\"DepartureGroupId\":2,\"PlatformMessage\":\"Felaktig information kan förekomma på skyltarna. Tågen avgår enligt tidtabell.\",\"TransportMode\":\"METRO\",\"LineNumber\":\"17\",\"Destination\":\"Skarpnäck\",\"JourneyDirection\":2,\"SiteId\":9001}," +
                                        "{\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans röda linje\",\"DisplayTime\":\"Nu\",\"SafeDestinationName\":\"Tekn högskolan\",\"GroupOfLineId\":2,\"DepartureGroupId\":1,\"PlatformMessage\":\"Roslagsbanan: Tågen på Kårsta- och Österskärlinjen vänder vid Universitet p.g.a. underhållsarbete vid Östra station. Läs mer på sl.se.\",\"TransportMode\":\"METRO\",\"LineNumber\":\"14\",\"Destination\":\"Tekn högskolan\",\"JourneyDirection\":0,\"SiteId\":9001}," +
                                        "{\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans röda linje\",\"DisplayTime\":\"Nu\",\"SafeDestinationName\":\"Axelsberg\",\"GroupOfLineId\":2,\"DepartureGroupId\":2,\"PlatformMessage\":\"Tågen mellan Sätra och Skärholmen ersätts med bussar till den 5 augusti p.g.a. underhållsarbete. Läs mer på sl.se.\",\"TransportMode\":\"METRO\",\"LineNumber\":\"14\",\"Destination\":\"Axelsberg\",\"JourneyDirection\":2,\"SiteId\":9001}," +
                                        "{\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans blå linje\",\"DisplayTime\":\"Nu\",\"SafeDestinationName\":\"Hjulsta\",\"GroupOfLineId\":3,\"DepartureGroupId\":1,\"PlatformMessage\":null,\"TransportMode\":\"METRO\",\"LineNumber\":\"10\",\"Destination\":\"Hjulsta\",\"JourneyDirection\":1,\"SiteId\":9001}," +
                                        "{\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans blå linje\",\"DisplayTime\":\"4 min\",\"SafeDestinationName\":\"Akalla\",\"GroupOfLineId\":3,\"DepartureGroupId\":1,\"PlatformMessage\":null,\"TransportMode\":\"METRO\",\"LineNumber\":\"11\",\"Destination\":\"Akalla\",\"JourneyDirection\":1,\"SiteId\":9001}," +
                                        "{\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans blå linje\",\"DisplayTime\":\"9 min\",\"SafeDestinationName\":\"Hjulsta\",\"GroupOfLineId\":3,\"DepartureGroupId\":1,\"PlatformMessage\":null,\"TransportMode\":\"METRO\",\"LineNumber\":\"10\",\"Destination\":\"Hjulsta\",\"JourneyDirection\":1,\"SiteId\":9001}," +
                                        "{\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans blå linje\",\"DisplayTime\":\"2 min\",\"SafeDestinationName\":\"Kungsträdgården\",\"GroupOfLineId\":3,\"DepartureGroupId\":2,\"PlatformMessage\":null,\"TransportMode\":\"METRO\",\"LineNumber\":\"11\",\"Destination\":\"Kungsträdgården\",\"JourneyDirection\":2,\"SiteId\":9001}," +
                                        "{\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans blå linje\",\"DisplayTime\":\"7 min\",\"SafeDestinationName\":\"Kungsträdgården\",\"GroupOfLineId\":3,\"DepartureGroupId\":2,\"PlatformMessage\":null,\"TransportMode\":\"METRO\",\"LineNumber\":\"10\",\"Destination\":\"Kungsträdgården\",\"JourneyDirection\":2,\"SiteId\":9001}," +
                                        "{\"StopAreaName\":\"T-Centralen\",\"GroupOfLine\":\"Tunnelbanans blå linje\",\"DisplayTime\":\"13 min\",\"SafeDestinationName\":\"Kungsträdgården\",\"GroupOfLineId\":3,\"DepartureGroupId\":2,\"PlatformMessage\":null,\"TransportMode\":\"METRO\",\"LineNumber\":\"11\",\"Destination\":\"Kungsträdgården\",\"JourneyDirection\":2,\"SiteId\":9001}]," +
                                        "\"Buses\":[{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":11524,\"StopPointDesignation\":\"Z\",\"TimeTabledDateTime\":\"2015-07-14T08:33:00\",\"ExpectedDateTime\":\"2015-07-14T08:34:59\",\"DisplayTime\":\"Nu\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"57\",\"Destination\":\"Karolinska sjukhuset\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10537,\"StopPointDesignation\":\"R\",\"TimeTabledDateTime\":\"2015-07-14T08:35:00\",\"ExpectedDateTime\":\"2015-07-14T08:35:59\",\"DisplayTime\":\"Nu\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Blockhusudden\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T08:36:00\",\"ExpectedDateTime\":\"2015-07-14T08:36:55\",\"DisplayTime\":\"1 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"59\",\"Destination\":\"Norra Hammarbyhamnen\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10526,\"StopPointDesignation\":\"K\",\"TimeTabledDateTime\":\"2015-07-14T08:37:00\",\"ExpectedDateTime\":\"2015-07-14T08:37:00\",\"DisplayTime\":\"1 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Karolinska institutet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10291,\"StopPointDesignation\":\"O\",\"TimeTabledDateTime\":\"2015-07-14T08:37:00\",\"ExpectedDateTime\":\"2015-07-14T08:37:59\",\"DisplayTime\":\"2 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Blockhusudden\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10538,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T08:38:00\",\"ExpectedDateTime\":\"2015-07-14T08:38:00\",\"DisplayTime\":\"2 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Karolinska institutet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T08:38:00\",\"ExpectedDateTime\":\"2015-07-14T08:38:50\",\"DisplayTime\":\"3 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"53\",\"Destination\":\"Fridhemsplan\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T08:39:00\",\"ExpectedDateTime\":\"2015-07-14T08:39:00\",\"DisplayTime\":\"3 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"53\",\"Destination\":\"Henriksdalsberget\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T08:41:00\",\"ExpectedDateTime\":\"2015-07-14T08:41:00\",\"DisplayTime\":\"5 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"50\",\"Destination\":\"Hornsberg\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T08:41:00\",\"ExpectedDateTime\":\"2015-07-14T08:41:09\",\"DisplayTime\":\"5 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"65\",\"Destination\":\"Centralen\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10537,\"StopPointDesignation\":\"R\",\"TimeTabledDateTime\":\"2015-07-14T08:40:00\",\"ExpectedDateTime\":\"2015-07-14T08:41:31\",\"DisplayTime\":\"5 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Storängsbotten\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T08:42:00\",\"ExpectedDateTime\":\"2015-07-14T08:42:00\",\"DisplayTime\":\"6 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"50\",\"Destination\":\"Stora Lappkärrsberget\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10291,\"StopPointDesignation\":\"O\",\"TimeTabledDateTime\":\"2015-07-14T08:41:57\",\"ExpectedDateTime\":\"2015-07-14T08:43:28\",\"DisplayTime\":\"7 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Storängsbotten\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10526,\"StopPointDesignation\":\"K\",\"TimeTabledDateTime\":\"2015-07-14T08:44:12\",\"ExpectedDateTime\":\"2015-07-14T08:44:12\",\"DisplayTime\":\"8 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Reimersholme\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Cityterminalen\",\"StopAreaNumber\":10910,\"StopPointNumber\":10911,\"StopPointDesignation\":null,\"TimeTabledDateTime\":\"2015-07-14T08:45:00\",\"ExpectedDateTime\":\"2015-07-14T08:45:00\",\"DisplayTime\":\"08:45\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"565X\",\"Destination\":\"Frösunda\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10538,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T08:46:00\",\"ExpectedDateTime\":\"2015-07-14T08:46:00\",\"DisplayTime\":\"10 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Reimersholme\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10537,\"StopPointDesignation\":\"R\",\"TimeTabledDateTime\":\"2015-07-14T08:46:00\",\"ExpectedDateTime\":\"2015-07-14T08:46:21\",\"DisplayTime\":\"10 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Blockhusudden\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10291,\"StopPointDesignation\":\"O\",\"TimeTabledDateTime\":\"2015-07-14T08:48:00\",\"ExpectedDateTime\":\"2015-07-14T08:48:21\",\"DisplayTime\":\"12 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Blockhusudden\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T08:50:00\",\"ExpectedDateTime\":\"2015-07-14T08:49:54\",\"DisplayTime\":\"14 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"53\",\"Destination\":\"Fridhemsplan\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T08:51:00\",\"ExpectedDateTime\":\"2015-07-14T08:51:00\",\"DisplayTime\":\"15 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"59\",\"Destination\":\"Fredhäll\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T08:51:00\",\"ExpectedDateTime\":\"2015-07-14T08:51:00\",\"DisplayTime\":\"15 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"53\",\"Destination\":\"Finnberget\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T08:51:00\",\"ExpectedDateTime\":\"2015-07-14T08:51:00\",\"DisplayTime\":\"15 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"50\",\"Destination\":\"Hornsberg\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T08:51:00\",\"ExpectedDateTime\":\"2015-07-14T08:51:34\",\"DisplayTime\":\"15 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"59\",\"Destination\":\"Norra Hammarbyhamnen\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T08:52:00\",\"ExpectedDateTime\":\"2015-07-14T08:52:00\",\"DisplayTime\":\"08:52\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"65\",\"Destination\":\"Skeppsholmen\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T08:53:00\",\"ExpectedDateTime\":\"2015-07-14T08:53:00\",\"DisplayTime\":\"17 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"50\",\"Destination\":\"Stora Lappkärrsberget\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10526,\"StopPointDesignation\":\"K\",\"TimeTabledDateTime\":\"2015-07-14T08:53:00\",\"ExpectedDateTime\":\"2015-07-14T08:53:16\",\"DisplayTime\":\"17 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Karolinska institutet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":11524,\"StopPointDesignation\":\"Z\",\"TimeTabledDateTime\":\"2015-07-14T08:53:00\",\"ExpectedDateTime\":\"2015-07-14T08:53:55\",\"DisplayTime\":\"18 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"57\",\"Destination\":\"Karolinska sjukhuset\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":11522,\"StopPointDesignation\":\"L\",\"TimeTabledDateTime\":\"2015-07-14T08:54:00\",\"ExpectedDateTime\":\"2015-07-14T08:54:00\",\"DisplayTime\":\"18 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"57\",\"Destination\":\"Sofia\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10538,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T08:54:00\",\"ExpectedDateTime\":\"2015-07-14T08:54:16\",\"DisplayTime\":\"18 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Karolinska institutet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10537,\"StopPointDesignation\":\"R\",\"TimeTabledDateTime\":\"2015-07-14T08:55:00\",\"ExpectedDateTime\":\"2015-07-14T08:55:00\",\"DisplayTime\":\"19 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Storängsbotten\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10537,\"StopPointDesignation\":\"R\",\"TimeTabledDateTime\":\"2015-07-14T08:56:00\",\"ExpectedDateTime\":\"2015-07-14T08:56:00\",\"DisplayTime\":\"08:56\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Blockhusudden\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10291,\"StopPointDesignation\":\"O\",\"TimeTabledDateTime\":\"2015-07-14T08:56:57\",\"ExpectedDateTime\":\"2015-07-14T08:56:57\",\"DisplayTime\":\"21 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Storängsbotten\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10291,\"StopPointDesignation\":\"O\",\"TimeTabledDateTime\":\"2015-07-14T08:58:00\",\"ExpectedDateTime\":\"2015-07-14T08:58:00\",\"DisplayTime\":\"08:58\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Blockhusudden\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T09:01:00\",\"ExpectedDateTime\":\"2015-07-14T09:01:13\",\"DisplayTime\":\"09:01\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"65\",\"Destination\":\"Centralen\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T09:01:00\",\"ExpectedDateTime\":\"2015-07-14T09:01:42\",\"DisplayTime\":\"25 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"50\",\"Destination\":\"Hornsberg\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T09:02:00\",\"ExpectedDateTime\":\"2015-07-14T09:02:00\",\"DisplayTime\":\"26 min\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"53\",\"Destination\":\"Fridhemsplan\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T09:03:00\",\"ExpectedDateTime\":\"2015-07-14T09:03:00\",\"DisplayTime\":\"09:03\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"53\",\"Destination\":\"Henriksdalsberget\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10526,\"StopPointDesignation\":\"K\",\"TimeTabledDateTime\":\"2015-07-14T09:03:12\",\"ExpectedDateTime\":\"2015-07-14T09:03:12\",\"DisplayTime\":\"09:03\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Reimersholme\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10538,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T09:05:00\",\"ExpectedDateTime\":\"2015-07-14T09:05:00\",\"DisplayTime\":\"09:05\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Reimersholme\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Cityterminalen\",\"StopAreaNumber\":10910,\"StopPointNumber\":10911,\"StopPointDesignation\":null,\"TimeTabledDateTime\":\"2015-07-14T09:05:00\",\"ExpectedDateTime\":\"2015-07-14T09:05:00\",\"DisplayTime\":\"09:05\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"565X\",\"Destination\":\"Frösunda\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T09:06:00\",\"ExpectedDateTime\":\"2015-07-14T09:06:00\",\"DisplayTime\":\"09:06\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"59\",\"Destination\":\"Fredhäll\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10537,\"StopPointDesignation\":\"R\",\"TimeTabledDateTime\":\"2015-07-14T09:06:00\",\"ExpectedDateTime\":\"2015-07-14T09:06:00\",\"DisplayTime\":\"09:06\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Kaknästornet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10291,\"StopPointDesignation\":\"O\",\"TimeTabledDateTime\":\"2015-07-14T09:08:00\",\"ExpectedDateTime\":\"2015-07-14T09:08:00\",\"DisplayTime\":\"09:08\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Kaknästornet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T09:08:00\",\"ExpectedDateTime\":\"2015-07-14T09:08:00\",\"DisplayTime\":\"09:08\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"59\",\"Destination\":\"Norra Hammarbyhamnen\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10537,\"StopPointDesignation\":\"R\",\"TimeTabledDateTime\":\"2015-07-14T09:09:00\",\"ExpectedDateTime\":\"2015-07-14T09:09:00\",\"DisplayTime\":\"09:09\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Storängsbotten\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10526,\"StopPointDesignation\":\"K\",\"TimeTabledDateTime\":\"2015-07-14T09:09:00\",\"ExpectedDateTime\":\"2015-07-14T09:09:00\",\"DisplayTime\":\"09:09\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Karolinska institutet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10538,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T09:10:00\",\"ExpectedDateTime\":\"2015-07-14T09:10:00\",\"DisplayTime\":\"09:10\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Karolinska institutet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10291,\"StopPointDesignation\":\"O\",\"TimeTabledDateTime\":\"2015-07-14T09:10:57\",\"ExpectedDateTime\":\"2015-07-14T09:10:57\",\"DisplayTime\":\"09:10\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Storängsbotten\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T09:11:00\",\"ExpectedDateTime\":\"2015-07-14T09:11:00\",\"DisplayTime\":\"09:11\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"50\",\"Destination\":\"Hornsberg\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T09:12:00\",\"ExpectedDateTime\":\"2015-07-14T09:12:00\",\"DisplayTime\":\"09:12\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"65\",\"Destination\":\"Skeppsholmen\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T09:13:00\",\"ExpectedDateTime\":\"2015-07-14T09:13:00\",\"DisplayTime\":\"09:13\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"50\",\"Destination\":\"Stora Lappkärrsberget\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":11524,\"StopPointDesignation\":\"Z\",\"TimeTabledDateTime\":\"2015-07-14T09:13:00\",\"ExpectedDateTime\":\"2015-07-14T09:13:00\",\"DisplayTime\":\"09:13\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"57\",\"Destination\":\"Karolinska sjukhuset\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T09:14:00\",\"ExpectedDateTime\":\"2015-07-14T09:14:00\",\"DisplayTime\":\"09:14\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"53\",\"Destination\":\"Fridhemsplan\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T09:15:00\",\"ExpectedDateTime\":\"2015-07-14T09:15:00\",\"DisplayTime\":\"09:15\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"53\",\"Destination\":\"Henriksdalsberget\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":11522,\"StopPointDesignation\":\"L\",\"TimeTabledDateTime\":\"2015-07-14T09:15:00\",\"ExpectedDateTime\":\"2015-07-14T09:15:15\",\"DisplayTime\":\"09:15\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"57\",\"Destination\":\"Sofia\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10537,\"StopPointDesignation\":\"R\",\"TimeTabledDateTime\":\"2015-07-14T09:17:00\",\"ExpectedDateTime\":\"2015-07-14T09:17:00\",\"DisplayTime\":\"09:17\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Blockhusudden\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10291,\"StopPointDesignation\":\"O\",\"TimeTabledDateTime\":\"2015-07-14T09:19:00\",\"ExpectedDateTime\":\"2015-07-14T09:19:00\",\"DisplayTime\":\"09:19\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Blockhusudden\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T09:21:00\",\"ExpectedDateTime\":\"2015-07-14T09:21:00\",\"DisplayTime\":\"09:21\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"59\",\"Destination\":\"Fredhäll\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T09:21:00\",\"ExpectedDateTime\":\"2015-07-14T09:21:00\",\"DisplayTime\":\"09:21\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"50\",\"Destination\":\"Hornsberg\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T09:22:00\",\"ExpectedDateTime\":\"2015-07-14T09:22:00\",\"DisplayTime\":\"09:22\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"65\",\"Destination\":\"Centralen\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10526,\"StopPointDesignation\":\"K\",\"TimeTabledDateTime\":\"2015-07-14T09:23:12\",\"ExpectedDateTime\":\"2015-07-14T09:23:12\",\"DisplayTime\":\"09:23\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Reimersholme\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10526,\"StopPointDesignation\":\"K\",\"TimeTabledDateTime\":\"2015-07-14T09:23:00\",\"ExpectedDateTime\":\"2015-07-14T09:23:23\",\"DisplayTime\":\"09:23\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Karolinska institutet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10537,\"StopPointDesignation\":\"R\",\"TimeTabledDateTime\":\"2015-07-14T09:24:00\",\"ExpectedDateTime\":\"2015-07-14T09:24:00\",\"DisplayTime\":\"09:24\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Storängsbotten\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10538,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T09:24:00\",\"ExpectedDateTime\":\"2015-07-14T09:24:23\",\"DisplayTime\":\"09:24\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Karolinska institutet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10538,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T09:25:00\",\"ExpectedDateTime\":\"2015-07-14T09:25:00\",\"DisplayTime\":\"09:25\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Reimersholme\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10291,\"StopPointDesignation\":\"O\",\"TimeTabledDateTime\":\"2015-07-14T09:25:57\",\"ExpectedDateTime\":\"2015-07-14T09:25:57\",\"DisplayTime\":\"09:25\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"54\",\"Destination\":\"Storängsbotten\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10537,\"StopPointDesignation\":\"R\",\"TimeTabledDateTime\":\"2015-07-14T09:27:00\",\"ExpectedDateTime\":\"2015-07-14T09:27:00\",\"DisplayTime\":\"09:27\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Kaknästornet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T09:27:00\",\"ExpectedDateTime\":\"2015-07-14T09:27:00\",\"DisplayTime\":\"09:27\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"53\",\"Destination\":\"Henriksdalsberget\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T09:27:00\",\"ExpectedDateTime\":\"2015-07-14T09:27:00\",\"DisplayTime\":\"09:27\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"59\",\"Destination\":\"Norra Hammarbyhamnen\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T09:29:00\",\"ExpectedDateTime\":\"2015-07-14T09:29:00\",\"DisplayTime\":\"09:29\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"53\",\"Destination\":\"Fridhemsplan\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10291,\"StopPointDesignation\":\"O\",\"TimeTabledDateTime\":\"2015-07-14T09:29:00\",\"ExpectedDateTime\":\"2015-07-14T09:29:00\",\"DisplayTime\":\"09:29\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Kaknästornet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10289,\"StopPointNumber\":10843,\"StopPointDesignation\":\"A\",\"TimeTabledDateTime\":\"2015-07-14T09:32:00\",\"ExpectedDateTime\":\"2015-07-14T09:32:00\",\"DisplayTime\":\"09:32\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"65\",\"Destination\":\"Skeppsholmen\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":11524,\"StopPointDesignation\":\"Z\",\"TimeTabledDateTime\":\"2015-07-14T09:32:00\",\"ExpectedDateTime\":\"2015-07-14T09:32:17\",\"DisplayTime\":\"09:32\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"57\",\"Destination\":\"Karolinska sjukhuset\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Centralen\",\"StopAreaNumber\":10537,\"StopPointNumber\":10842,\"StopPointDesignation\":\"G\",\"TimeTabledDateTime\":\"2015-07-14T09:33:00\",\"ExpectedDateTime\":\"2015-07-14T09:33:00\",\"DisplayTime\":\"09:33\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"50\",\"Destination\":\"Stora Lappkärrsberget\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":10526,\"StopPointDesignation\":\"K\",\"TimeTabledDateTime\":\"2015-07-14T09:35:00\",\"ExpectedDateTime\":\"2015-07-14T09:35:00\",\"DisplayTime\":\"09:35\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"69\",\"Destination\":\"Karolinska institutet\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"GroupOfLine\":null,\"StopAreaName\":\"Sergels torg\",\"StopAreaNumber\":10291,\"StopPointNumber\":11522,\"StopPointDesignation\":\"L\",\"TimeTabledDateTime\":\"2015-07-14T09:35:00\",\"ExpectedDateTime\":\"2015-07-14T09:35:00\",\"DisplayTime\":\"09:35\",\"Deviations\":null,\"TransportMode\":\"BUS\",\"LineNumber\":\"57\",\"Destination\":\"Sofia\",\"SiteId\":9001}]," +
                                        "\"Trains\":[{\"JourneyDirection\":2,\"SecondaryDestinationName\":\"Arlanda C\",\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5014,\"StopPointDesignation\":\"N\",\"TimeTabledDateTime\":\"2015-07-14T08:39:00\",\"ExpectedDateTime\":\"2015-07-14T08:39:00\",\"DisplayTime\":\"3 min\",\"Deviations\":[{\"Text\":\"Resa förbi Arlanda C kräver både UL- och SL- biljett.\",\"Consequence\":\"INFORMATION\",\"ImportanceLevel\":5}],\"TransportMode\":\"TRAIN\",\"LineNumber\":\"38\",\"Destination\":\"Uppsala C\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"SecondaryDestinationName\":null,\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5014,\"StopPointDesignation\":\"N\",\"TimeTabledDateTime\":\"2015-07-14T08:43:00\",\"ExpectedDateTime\":\"2015-07-14T08:43:00\",\"DisplayTime\":\"7 min\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"35\",\"Destination\":\"Spånga\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"SecondaryDestinationName\":null,\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5014,\"StopPointDesignation\":\"N\",\"TimeTabledDateTime\":\"2015-07-14T08:46:00\",\"ExpectedDateTime\":\"2015-07-14T08:46:00\",\"DisplayTime\":\"10 min\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"36\",\"Destination\":\"Märsta\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"SecondaryDestinationName\":\"Älvsjö\",\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5013,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T08:46:00\",\"ExpectedDateTime\":\"2015-07-14T08:46:00\",\"DisplayTime\":\"10 min\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"36\",\"Destination\":\"Södertälje C\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"SecondaryDestinationName\":\"Älvsjö\",\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5013,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T08:49:00\",\"ExpectedDateTime\":\"2015-07-14T08:49:00\",\"DisplayTime\":\"08:49\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"35\",\"Destination\":\"Västerhaninge\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"SecondaryDestinationName\":null,\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5013,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T08:55:00\",\"ExpectedDateTime\":\"2015-07-14T08:55:00\",\"DisplayTime\":\"19 min\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"38\",\"Destination\":\"Älvsjö\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"SecondaryDestinationName\":null,\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5014,\"StopPointDesignation\":\"N\",\"TimeTabledDateTime\":\"2015-07-14T08:58:00\",\"ExpectedDateTime\":\"2015-07-14T08:58:00\",\"DisplayTime\":\"22 min\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"35\",\"Destination\":\"Spånga\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"SecondaryDestinationName\":null,\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5014,\"StopPointDesignation\":\"N\",\"TimeTabledDateTime\":\"2015-07-14T09:01:00\",\"ExpectedDateTime\":\"2015-07-14T09:01:00\",\"DisplayTime\":\"25 min\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"36\",\"Destination\":\"Märsta\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"SecondaryDestinationName\":\"Älvsjö\",\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5013,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T09:01:00\",\"ExpectedDateTime\":\"2015-07-14T09:01:00\",\"DisplayTime\":\"25 min\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"36\",\"Destination\":\"Södertälje C\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"SecondaryDestinationName\":\"Älvsjö\",\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5013,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T09:04:00\",\"ExpectedDateTime\":\"2015-07-14T09:04:00\",\"DisplayTime\":\"09:04\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"35\",\"Destination\":\"Västerhaninge\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"SecondaryDestinationName\":\"Arlanda C\",\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5014,\"StopPointDesignation\":\"N\",\"TimeTabledDateTime\":\"2015-07-14T09:09:00\",\"ExpectedDateTime\":\"2015-07-14T09:09:00\",\"DisplayTime\":\"09:09\",\"Deviations\":[{\"Text\":\"Resa förbi Arlanda C kräver både UL- och SL- biljett.\",\"Consequence\":\"INFORMATION\",\"ImportanceLevel\":5}],\"TransportMode\":\"TRAIN\",\"LineNumber\":\"38\",\"Destination\":\"Uppsala C\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"SecondaryDestinationName\":null,\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5014,\"StopPointDesignation\":\"N\",\"TimeTabledDateTime\":\"2015-07-14T09:13:00\",\"ExpectedDateTime\":\"2015-07-14T09:13:00\",\"DisplayTime\":\"09:13\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"35\",\"Destination\":\"Spånga\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"SecondaryDestinationName\":null,\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5014,\"StopPointDesignation\":\"N\",\"TimeTabledDateTime\":\"2015-07-14T09:16:00\",\"ExpectedDateTime\":\"2015-07-14T09:16:00\",\"DisplayTime\":\"09:16\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"36\",\"Destination\":\"Märsta\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"SecondaryDestinationName\":\"Älvsjö\",\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5013,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T09:16:00\",\"ExpectedDateTime\":\"2015-07-14T09:16:00\",\"DisplayTime\":\"09:16\",\"Deviations\":[{\"Text\":\"Anslutning till linje 37 mot Gnesta i Södertälje hamn.\",\"Consequence\":\"INFORMATION\",\"ImportanceLevel\":5}],\"TransportMode\":\"TRAIN\",\"LineNumber\":\"36\",\"Destination\":\"Södertälje C\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"SecondaryDestinationName\":\"Älvsjö\",\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5013,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T09:19:00\",\"ExpectedDateTime\":\"2015-07-14T09:19:00\",\"DisplayTime\":\"09:19\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"35\",\"Destination\":\"Västerhaninge\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"SecondaryDestinationName\":null,\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5014,\"StopPointDesignation\":\"N\",\"TimeTabledDateTime\":\"2015-07-14T09:28:00\",\"ExpectedDateTime\":\"2015-07-14T09:28:00\",\"DisplayTime\":\"09:28\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"35\",\"Destination\":\"Spånga\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":2,\"SecondaryDestinationName\":null,\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5014,\"StopPointDesignation\":\"N\",\"TimeTabledDateTime\":\"2015-07-14T09:31:00\",\"ExpectedDateTime\":\"2015-07-14T09:31:00\",\"DisplayTime\":\"09:31\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"36\",\"Destination\":\"Märsta\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"SecondaryDestinationName\":\"Älvsjö\",\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5013,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T09:31:00\",\"ExpectedDateTime\":\"2015-07-14T09:31:00\",\"DisplayTime\":\"09:31\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"36\",\"Destination\":\"Södertälje C\",\"SiteId\":9001}," +
                                        "{\"JourneyDirection\":1,\"SecondaryDestinationName\":\"Älvsjö\",\"StopAreaName\":\"Stockholms central\",\"StopAreaNumber\":5011,\"StopPointNumber\":5013,\"StopPointDesignation\":\"S\",\"TimeTabledDateTime\":\"2015-07-14T09:34:00\",\"ExpectedDateTime\":\"2015-07-14T09:34:00\",\"DisplayTime\":\"09:34\",\"Deviations\":null,\"TransportMode\":\"TRAIN\",\"LineNumber\":\"35\",\"Destination\":\"Västerhaninge\",\"SiteId\":9001}]," +
                                        "\"Trams\":[],\"Ships\":[],\"StopPointDeviations\":[{\"StopInfo\":{\"StopAreaNumber\":0,\"StopAreaName\":\"Stockholms central\",\"TransportMode\":\"TRAIN\",\"GroupOfLine\":null}," +
                                        "\"Deviation\":{\"Text\":\"Bussar ersätter sträckan Spånga till Bålsta och Västerhaninge-Nynäshamn till 2/8. Se sl.se\",\"Consequence\":null,\"ImportanceLevel\":5}}]}}";

            //downnloadString: 
            int timeWindow;
            int siteID;
            try
            {
                timeWindow = int.Parse(timeWindowLabel.Text);
                siteID = int.Parse(stationIdTextBox.Text);// Akalla 9300, TCE: 9001, slussen 9192, solna c 9305, solna station, 9509
            }
            catch (Exception err)
            {
                Console.WriteLine("Error trying to parse timewindow: " + err);
                return;
            }
            ApiKeyHolder apiKey = ApiKeyHolder.Instance;
            // http:// api.sl.se/api2/realtimedepartures.<FORMAT>?key=<DIN API NYCKEL>&siteid=<SITEID>&timewindow=<TIMEWINDOW>
            string downloadString = "http://api.sl.se/api2/realtimedepartures.JSON?key=" + apiKey.ApiKeyDepartures +
                                            "&siteid=" + siteID +
                                            "&timewindow=" + timeWindow;
            clearAllTextBoxes();

            Console.WriteLine(downloadString);
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                
                var downloadedJsonObj = wc.DownloadString(downloadString);
                var realtime = JsonConvert.DeserializeObject<realTimeMessage>(downloadedJsonObj);
               // var realtime = JsonConvert.DeserializeObject<realTimeMessage>(json2);
            

                Console.WriteLine("No. of metro responses: " + realtime.DepartureObject.Metros.Count);
                Console.WriteLine("No. of Buses responses: " + realtime.DepartureObject.Buses.Count);
                Console.WriteLine("No. of train responses: " + realtime.DepartureObject.Trains.Count);
                Console.WriteLine("No. of trams responses: " + realtime.DepartureObject.Trams.Count);
                Console.WriteLine("No. of shipresponses: " + realtime.DepartureObject.Trams.Count);
                Console.WriteLine("No. of StopPointDeviations esponses: " + realtime.DepartureObject.StopPointDeviations.Count  );
                Console.WriteLine("Complete json-string: ");
                Console.WriteLine(downloadedJsonObj);



                /*
                  * tunnelbanor bör pars'ar med avseende på groupofline id, sen departuregroupid
                  * 
                  */
                if (realtime.DepartureObject.Metros.Count > 0)
                {
                    foreach (Metros met in realtime.DepartureObject.Metros)
                    {
                        metroListBox.Items.Add(met.LineNumber + " " + met.Destination + " - " + met.DisplayTime + " - " + met.PlatformMessage);
                    }
                }
                else
                {
                    metroListBox.Items.Add("No data to show!");
                }

                if (realtime.DepartureObject.Buses.Count > 0)
                {
                    foreach (Buses bus in realtime.DepartureObject.Buses  )
                    {
                        busListBox.Items.Add(bus.LineNumber + " - " + bus.Destination +", HPL: " + bus.StopPointDesignation + ": " + bus.DisplayTime  );
                    }
                }
                else
                {
                    busListBox.Items.Add("No data to show!");
                }

                if (realtime.DepartureObject.Trains.Count > 0)
                {
                    foreach (Trains train in realtime.DepartureObject.Trains)
                    {
                        trainListBox.Items.Add( train.LineNumber + " - " +
                                                train.Destination + " - Track: " + train.StopPointDesignation + 
                                                ": " + train.DisplayTime  );
                    }
                }
                else
                {
                    trainListBox.Items.Add("No data to show!");
                }

                if (realtime.DepartureObject.Trams.Count > 0)
                {
                    foreach (Trams tram in realtime.DepartureObject.Trams)
                    {
                        //Console.WriteLine(bus.LineNumber + " - " + bus.Destination + ": " + bus.DisplayTime);
                       // tramListBox.Items.Add(tram.LineNumber + " - " + tram.Destination + ": " + tram.DisplayTime);
                        tramListBox.Items.Add(tram.LineNumber + " - " +
                            tram.Destination + " - Track: " + tram.StopPointDesignation +
                            ": " + tram.DisplayTime);
                    }
                }
                else
                {
                    tramListBox.Items.Add("No data to show!");
                }

                if (realtime.DepartureObject.Ships.Count > 0)
                {
                    foreach (Ships ship in realtime.DepartureObject.Ships)
                    {
                        //Console.WriteLine(bus.LineNumber + " - " + bus.Destination + ": " + bus.DisplayTime);
                        // tramListBox.Items.Add(tram.LineNumber + " - " + tram.Destination + ": " + tram.DisplayTime);
                        shipListBox.Items.Add(ship.LineNumber + " - " +
                                                ship.Destination +   ": " + ship.DisplayTime);
                    }
                }
                else
                {
                    shipListBox.Items.Add("No data to show!");
                }
            }
            #endregion

            progressBar1.Value = 0;
            blockTimer.Start();
            button1.Enabled = false;
        }

        private void clearAllTextBoxes()
        {

            metroListBox.Items.Clear();
            trainListBox.Items.Clear();
            busListBox.Items.Clear();
            tramListBox.Items.Clear();
            shipListBox.Items.Clear();
        
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void aPIKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APIKeyForm apiForm = new APIKeyForm();
            apiForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            apiForm.Show();
        }
        private void TrackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            timeWindowLabel.Text = trackBar1.Value.ToString();

        }


        private void blockTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value++;
            }
            else
            {
                blockTimer.Stop();
                button1.Enabled = true;
            }
        }

    }





}
