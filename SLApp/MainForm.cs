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
        private Timer blockTimer = new Timer();
        public MainForm()
        {
            InitializeComponent();

            // Set a pretty icon from the png-file i found
            Bitmap bmp = SLApp.Properties.Resources.sl_logo;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            //Initialize timer
            blockTimer.Enabled = false;
            blockTimer.Interval = 100;
            blockTimer.Tick += new EventHandler(blockTimer_Tick);
        }

        // Fetch realtime data. 
        // A bit too large. Should rewrite. But will be tricky....
        private void fetchDataButton_Click(object sender, EventArgs e)
        {


            progressBar1.Value = 0;
            blockTimer.Start();
            fetchDataButton.Enabled = false;


            //downnloadString
            int timeWindow;
            int siteID;

            if (stationSeachResultListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a station first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    //siteID = int.Parse(stationIdTextBox.Text);// Akalla 9300, TCE: 9001, slussen 9192, solna c 9305, solna station, 9509
                    siteObject site = (siteObject)stationSeachResultListBox.SelectedItem;
                    siteID = site.SiteId;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error trying to access selected station:\n" + err, 
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
   
                }
            }


            try
            {
                timeWindow = int.Parse(timeWindowLabel.Text);
                
            }
            catch (Exception err)
            {
                Console.WriteLine("Error trying to parse timewindow: " + err);
                MessageBox.Show("Error trying to parse timewindow:\n" + err, 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiKeyHolder apiKey = ApiKeyHolder.Instance;
            string downloadString = "http://api.sl.se/api2/realtimedepartures.JSON?key=" + 
                                            apiKey.ApiKeyDepartures +
                                            "&siteid=" + siteID +
                                            "&timewindow=" + timeWindow;


            clearAllTextBoxes();
            Console.WriteLine("Constructed downloadstring: " + downloadString);
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8; // Swedish char's turned out funny, otherwise
                var downloadedJsonObj = wc.DownloadString(downloadString);
                var realtime = JsonConvert.DeserializeObject<realTimeMessage>(downloadedJsonObj);
            

                metroTab.Text = "metro (" + realtime.DepartureObject.Metros.Count + ")";
                busTab.Text = "Buses (" + realtime.DepartureObject.Buses.Count + ")";
                trainTab.Text = "Trains (" + realtime.DepartureObject.Trains.Count + ")";
                tramTab.Text = "Trams (" + realtime.DepartureObject.Trams.Count + ")";
                shipTab.Text = "Ships (" + realtime.DepartureObject.Ships.Count + ")";
                deviationTab.Text = "Deviations (" + realtime.DepartureObject.StopPointDeviations.Count + ")";

                /*
                  * TODO this section really should be rewritten with some generic method....
                 * But ....tricky since to many details vary for each type
                  * 
                  */

                // METROS
                if (realtime.DepartureObject.Metros.Count > 0)
                {
                    foreach (Metros met in realtime.DepartureObject.Metros)
                    {
                        if (string.IsNullOrEmpty(met.PlatformMessage))
                            metroListBox.Items.Add(met.LineNumber + " " + met.Destination + " - " + met.DisplayTime);
                        else
                            metroListBox.Items.Add(met.LineNumber + " " + met.Destination + " - " + met.DisplayTime + " - " + met.PlatformMessage);
                    }
                }
                else
                {
                    metroListBox.Items.Add("No data!");
                }

                // BUSSES
                if (realtime.DepartureObject.Buses.Count > 0)
                {
                    foreach (Buses bus in realtime.DepartureObject.Buses  )
                    {
                        if (string.IsNullOrEmpty(bus.StopPointDesignation))
                        {
                            busListBox.Items.Add(bus.LineNumber + " - " + bus.Destination
                                + ": " + bus.DisplayTime);
                        }
                        else
                        {
                            busListBox.Items.Add(bus.LineNumber + " - " + bus.Destination
                                    + ", HPL: " + bus.StopPointDesignation
                                    + ": " + bus.DisplayTime);
                        }

                    }
                }
                else
                {
                    busListBox.Items.Add("No data!");
                }

                // TRAINS
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
                    trainListBox.Items.Add("No data!");
                }

                // TRAMS
                if (realtime.DepartureObject.Trams.Count > 0)
                {
                    foreach (Trams tram in realtime.DepartureObject.Trams)
                    {
                        if (string.IsNullOrEmpty(tram.StopPointDesignation))
                        {
                            tramListBox.Items.Add(tram.LineNumber + " - " +
                                                tram.Destination  +
                                                ": " + tram.DisplayTime);
                        }
                        else
                        {
                            tramListBox.Items.Add(tram.LineNumber + " - " +
                                                tram.Destination + " - Track: " + tram.StopPointDesignation +
                                                ": " + tram.DisplayTime);
                        }

                    }
                }
                else
                {
                    tramListBox.Items.Add("No data!");
                }

                // SHIPS
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
                    shipListBox.Items.Add("No data!");
                }

                // DEVIATIONS
                if (realtime.DepartureObject.StopPointDeviations.Count > 0)
                {
                    foreach (StopPointDeviations stop in realtime.DepartureObject.StopPointDeviations)
                    {

                        deviationListBox.Items.Add( "(" + stop.StopInfo.TransportMode + ") " 
                                                    + stop.Deviation.Text);
                    }
                }
                else
                {
                    deviationListBox.Items.Add("No data!");
                }
            }
        }


        // Clear all listboxes in all tabs. 
        private void clearAllTextBoxes()
        {
            metroListBox.Items.Clear();
            trainListBox.Items.Clear();
            busListBox.Items.Clear();
            tramListBox.Items.Clear();
            shipListBox.Items.Clear();
            deviationListBox.Items.Clear();
        }

        #region menustrip items

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
        #endregion


        // To update the selected time
        private void TrackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            timeWindowLabel.Text = trackBar1.Value.ToString();

        }

        // Called with a regular interval from timer. Updates progressbar
        private void blockTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value++;
            }
            else
            {
                blockTimer.Stop();
                fetchDataButton.Enabled = true;
            }
        }

        // Search for stations
        private void stationSearchButton_Click(object sender, EventArgs e)
        {

            ApiKeyHolder apiKey = ApiKeyHolder.Instance;

            if (string.IsNullOrWhiteSpace(stationSeachTextBox.Text))
            {
                MessageBox.Show("Enter seach term!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string downloadString = "http://api.sl.se/api2/typeahead.json?key=" + apiKey.ApiKeyStation + 
                                    "&searchstring="+  stationSeachTextBox.Text
                                    +"&stationsonly=true&maxresults=15";
            
            Console.WriteLine(downloadString);
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                var downloadedJsonObj = wc.DownloadString(downloadString);
                var stationMessage = JsonConvert.DeserializeObject<stationMessage>(downloadedJsonObj);
                Console.WriteLine("Complete json-string: ");
                Console.WriteLine(downloadedJsonObj);
                Console.WriteLine("No. of stations returned: " + stationMessage.ResponseData.Count);
                stationSeachResultListBox.Items.Clear();
                foreach (siteObject site in stationMessage.ResponseData)
                {
                    Console.WriteLine(site.ToString());
                    stationSeachResultListBox.Items.Add(site);
                }
            }
        }


    }
}
