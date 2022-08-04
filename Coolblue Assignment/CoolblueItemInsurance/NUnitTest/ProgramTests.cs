using CoolblueItemInsurance;
using System;
using System.Windows.Forms;
using NUnit.Framework;

namespace CoolblueItemInsurance
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        [STAThread]
        public static void MainTask()
        {
            ApiHelper.InitializeClient();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InsuranceCost());

        }

    }
}
