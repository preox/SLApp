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
         * 
         * program dependencies: Newtonsoft Json-stuff
         * 
         *  */
        [STAThread]
        static void Main(string[] args)
        {
            string fileName = "";

            if (args.Length == 0)
            {
                MessageBox.Show("No Api-file given\n"
                                 + "usage: SLApp.exe --apifile=<filename>"
                                ,"Missing api-file",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }

            foreach (string st in args)
            {
                if (st.Contains("--apifile="))
                {
                    Regex regex = new Regex(@"--apifile=(.*)$");
                    Match match = regex.Match(st);
                    if (!match.Success || match.Groups.Count == 0 )
                    {
                        MessageBox.Show("Error parsing ",
                                     "Parseerror",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                        System.Environment.Exit(1); 
                    }

                    fileName = match.Groups[1].ToString();
                    break;
                }
            }



            ApiKeyHolder apiKey = ApiKeyHolder.Instance;
            try
            {
                apiKey.readKeysFromFile(fileName);
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err );
                System.Environment.Exit(1);
            }
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
