using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLApp
{
    public partial class APIKeyForm : Form
    {
        public APIKeyForm()
        {
            InitializeComponent();
        }

        private void APIKeyForm_Shown(object sender, EventArgs e)
        {

            ApiKeyHolder apiKey = ApiKeyHolder.Instance;

            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.apiKeyFileName))
            {
                try
                {
                    apiKey.readKeysFromFile(Properties.Settings.Default.apiKeyFileName);
                }
                catch (Exception err)
                { 
                }
                
            
            }
            realTimeKeyTextBox.Text = apiKey.ApiKeyDepartures;
            stationKeyTextBox.Text = apiKey.ApiKeyStation;

        }

        // Close form
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // Shop openfileDialoge
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Api Key text files|*.txt";
            ApiKeyHolder apiKey = ApiKeyHolder.Instance;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default["apiKeyFileName"] = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
                try
                {
                    apiKey.readKeysFromFile(Properties.Settings.Default.apiKeyFileName);
                    realTimeKeyTextBox.Text = apiKey.ApiKeyDepartures;
                    stationKeyTextBox.Text = apiKey.ApiKeyStation;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error occured when trying to load settings from file:\n" +
                                openFileDialog1.FileName + "\n" + 
                                "Please make sure file is correctly formatted"
                                , "Error occured", MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                }
            }
        }



    }
}
