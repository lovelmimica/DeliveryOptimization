using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traveling_salesman_problem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            clearRouteImages();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //truncate foldera sa imagima
            string directoryName;
        }

        static void clearRouteImages()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("route-images");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }
        
           
            
        
    }
}
