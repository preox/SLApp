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

          //  lists should't group stuff. 
            metroObjectListView.ShowGroups = false;
            busObjectListView.ShowGroups = false;
            trainObjectListView.ShowGroups = false;
            tramObjectListView.ShowGroups = false;
            shipObjectListView.ShowGroups = false;
            deviationObjectListView.ShowGroups = false;
        }

        // Clear all listboxes in all tabs. 
        // A tad ugly but...whatthefuck
        private void clearAllTextBoxes()
        {
            busObjectListView.ClearObjects();
            metroObjectListView.ClearObjects();
            trainObjectListView.ClearObjects();
            tramObjectListView.ClearObjects();
            shipObjectListView.ClearObjects();
            deviationObjectListView.ClearObjects();
        }

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
        private void stationSearch()
        {
            ApiKeyHolder apiKey = ApiKeyHolder.Instance;

            if (string.IsNullOrWhiteSpace(stationSeachTextBox.Text))
            {
                MessageBox.Show("Enter seach term!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int maxResults = 15; // I'm usually against this kind of hardcoding....but....fuckit. 
            string downloadString = "http://api.sl.se/api2/typeahead.json?key=" + apiKey.ApiKeyStation +
                                    "&searchstring=" + stationSeachTextBox.Text
                                    + "&stationsonly=true&maxresults=" + maxResults;

            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                var stationMessage = JsonConvert.DeserializeObject<stationMessage>(wc.DownloadString(downloadString));
                stationSeachResultListBox.Items.Clear();
                foreach (siteObject site in stationMessage.ResponseData)
                {
                    stationSeachResultListBox.Items.Add(site);
                }
            }
        }

        // does the actual dataretrieval
        private void fetchRealTimeData()
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
                    siteID = ((siteObject)stationSeachResultListBox.SelectedItem).SiteId;
                    this.Text = "SLApp    -    " + ((siteObject)stationSeachResultListBox.SelectedItem).Name;
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
            //    Console.WriteLine("Error trying to parse timewindow: " + err);
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

           // Console.WriteLine("Constructed downloadstring: " + downloadString);
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8; // Swedish char's turned out funny, otherwise
                var realtime = JsonConvert.DeserializeObject<realTimeMessage>(wc.DownloadString(downloadString));
                metroTab.Text = "metro (" + realtime.DepartureObject.Metros.Count + ")";
                busTab.Text = "Buses (" + realtime.DepartureObject.Buses.Count + ")";
                trainTab.Text = "Trains (" + realtime.DepartureObject.Trains.Count + ")";
                tramTab.Text = "Trams (" + realtime.DepartureObject.Trams.Count + ")";
                shipTab.Text = "Ships (" + realtime.DepartureObject.Ships.Count + ")";
                deviationTab.Text = "Deviations (" + realtime.DepartureObject.StopPointDeviations.Count + ")";


                /*
                    * TODO this section really should be rewritten with some generic method....
                    * But ....tricky shit.....
                    * 
                    */

                // METROS
                if (realtime.DepartureObject.Metros.Count > 0)
                {
                    foreach (Metros met in realtime.DepartureObject.Metros)
                    {
                        metroObjectListView.AddObject(met);
                    }
                }

                // BUSSES
                if (realtime.DepartureObject.Buses.Count > 0)
                {
                    foreach (Buses bus in realtime.DepartureObject.Buses)
                    {
                        busObjectListView.AddObject(bus);
                    }
                }

                // TRAINS
                if (realtime.DepartureObject.Trains.Count > 0)
                {
                    foreach (Trains train in realtime.DepartureObject.Trains)
                    {
                        trainObjectListView.AddObject(train);
                    }
                }

                // TRAMS
                if (realtime.DepartureObject.Trams.Count > 0)
                {
                    foreach (Trams tram in realtime.DepartureObject.Trams)
                    {
                        tramObjectListView.AddObject(tram);

                    }
                }

                // SHIPS
                if (realtime.DepartureObject.Ships.Count > 0)
                {
                    foreach (Ships ship in realtime.DepartureObject.Ships)
                    {
                        shipObjectListView.AddObject(ship);
                    }
                }

                // DEVIATIONS
                if (realtime.DepartureObject.StopPointDeviations.Count > 0)
                {
                    foreach (StopPointDeviations stop in realtime.DepartureObject.StopPointDeviations)
                    {
                        deviationObjectListView.AddObject(stop);
                    }
                }
            }
        }

        // Key-down event in searchtextbox. If enter is pressed, call same searchbutton-function
        private void stationSeachTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                stationSearch();
            }
        }

        // handler for doubleclick in stationlist
        private void stationSeachResultListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(fetchDataButton.Enabled )
                fetchRealTimeData();
        }

        // button handler
        private void stationSearchButton_Click(object sender, EventArgs e)
        {
            stationSearch();
        }

        // button handler
        private void fetchDataButton_Click(object sender, EventArgs e)
        {
            fetchRealTimeData();
        }
        #region menustrip items

        // strip-menu item exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // strip-menu item apikey
        private void aPIKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APIKeyForm apiForm = new APIKeyForm();
            apiForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            apiForm.Show();
        }
        #endregion



    }




}
