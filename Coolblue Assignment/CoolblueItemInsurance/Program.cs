using System;
using System.Windows.Forms;


namespace CoolblueItemInsurance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApiHelper.InitializeClient();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InsuranceCost());
          
        }

    }
}
