using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SLApp
{
    public sealed class ApiKeyHolder
    {
        static readonly ApiKeyHolder _instance = new ApiKeyHolder();
        private string apiKeyDepartures;
        private string apiKeyStation;

        // private constructor
        public static ApiKeyHolder Instance
        {
	        get { return _instance; }
        }

        // public constructor
        private ApiKeyHolder()
        {
        }

        // read and parse from file. 
        public void readKeysFromFile (string fileName)
        {
            string lines = System.IO.File.ReadAllText(@fileName);
            if (lines == null)
                throw new System.IO.FileNotFoundException("Failed to open filen: " + fileName);

            Regex regex = new Regex(@"apiKeyStation:(.*):");
            Match match = regex.Match(lines);
            if (!match.Success || match.Groups.Count == 0)
            {
               throw new System.Exception("Failed to parse apiKeyStation in keyfile");
            }
            apiKeyStation = match.Groups[1].ToString();
            regex = new Regex(@"apiKeyDepartures:(.*):");
            match = regex.Match(lines);
            if (!match.Success || match.Groups.Count == 0)
            {
                throw new System.Exception("Failed to parse apiKeyDepartures in keyfile");
            }
            apiKeyDepartures = match.Groups[1].ToString();



        }

        # region Getters&setters
        public string ApiKeyDepartures
        {
            get { return apiKeyDepartures; }
            set { apiKeyDepartures = value; }
        }


        public string ApiKeyStation
        {
            get { return apiKeyStation; }
            set { apiKeyStation = value; }
        }

        #endregion
    }
}
