using System;
using System.Windows.Forms;
using NUnit.Framework;
namespace CoolblueItemInsurance
{
    public partial class InsuranceCost : Form
    {
        public InsuranceCost()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hide all panels inside the Form window on start of application
        /// </summary>
        public void Form1_Load(object sender, EventArgs e)
        {
            productID.Hide();
            productInformation.Hide();
            productType.Hide();
        }

        /// <summary>
        /// Show the selected Panel based on the button corresponding to it.
        /// </summary>

        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            productInformation.Hide();
            productType.Hide();

            productID.Show();
            productID.BringToFront();

        }

        private void SearchProductTypeButton_Click(object sender, EventArgs e)
        {
            productID.Hide();
            productInformation.Hide();

            productType.Show();
            productType.BringToFront();
        }
      
        private void SearchProductInfoButton_Click(object sender, EventArgs e)
        {
            productID.Hide();
            productType.Hide();

            productInformation.Show();
            productInformation.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void productType_Load(object sender, EventArgs e)
        {

        }
    }
}
