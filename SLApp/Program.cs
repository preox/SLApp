using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLApp
{
    static class Program
    {
        /*
         * https://www.trafiklab.se/api/sl-platsuppslag
         * 
         * https://www.trafiklab.se/api/sl-realtidsinformation-3
         * 
         * Json-stuff  http://stackoverflow.com/questions/11126242/using-jsonconvert-deserializeobject-to-deserialize-json-to-a-c-sharp-poco-class
         * 
         * objectlistview stuff:
         * http://www.codeproject.com/KB/list/objectlistview.aspx
         * http://objectlistview.sourceforge.net/cs/gettingStarted.html#gettingstarted
         * 
         * program dependencies: Newtonsoft Json-stuff
         * 
         * 
         * 
         * 
         * TODO: 
         * 
         * felhantering (parsning går åt skogen)
         * 
         *  */
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("filename: " + Properties.Settings.Default.apiKeyFileName);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
