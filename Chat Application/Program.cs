using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application
{
    public static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        public const string filename = "../../../Bumble server/bin/Debug/chans.xml";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Connection c;
            Application.Run(c = new Connection());

            if(c.DialogResult==DialogResult.OK)
            Application.Run(new Bumble());

            
        }
    }
}
