using System;
using System.Collections.Generic;
using System.Linq;
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
         *  */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
