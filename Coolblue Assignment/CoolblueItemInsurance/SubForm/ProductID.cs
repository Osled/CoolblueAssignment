using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace CoolblueItemInsurance
{
    public partial class ProductID : UserControl
    {
        /// <summary>
        /// Initialization of the Compomnent and the textbox to be used for events.
        /// </summary>
        
        public ProductID()
        {
            InitializeComponent();
            this.ActiveControl = IdSearchTextBox;
        }


        /// <summary>
        /// Button designed to run PorductSearch() Funtion
        /// </summary>
       
        private void button1_Click(object sender, EventArgs e)
        {
            ProductOutput();
        }

        /// <summary>
        /// Regex is used to check if the Textbox hosts only Numbers.
        /// Apply search based on the input provided from the IdTextBox then display all the relevent information.
        /// calculate the total insurance cost of the items based on if it can be insured and the type of the product
        /// </summary>

        public async void ProductOutput()
        {
            if (Regex.IsMatch(IdSearchTextBox.Text, @"^\d+$"))
            {
                // collect the values typed inside the IdTextBox
                int id = int.Parse(IdSearchTextBox.Text);

                // Run the LoadData funtion and apply to it id as an int
                var item = await DataProcessor.LoadData(id);

                // Create a variable that hosts the item id and convert it to a string.
                string idCheck = item.Id.ToString();

                // Apply the information collected to the text Labels in the Windows Form.
                IDlabel.Text = $" { item.Id}";
                Namelabel.Text = $" { item.Name}";
                SalesPriceLabel.Text = $" { item.SalesPrice} €";
                ProductTypeIdLabel.Text = $" { item.ProuductTypeId}";

                // // Run the LoadData funtion and apply to it idType as an int
                var itemType = await DataProcessor.LoadDataType(item.ProuductTypeId);

                // Apply the information collected to the text Labels in the Windows Form based on the idType.
                ProductTypeLabel.Text = $"{itemType.Name}";
                CanBeInsured.Text = $"{itemType.CanBeInsured}";

                // Cheack if the id typed in the text box is avialable in the API then display text.
                if (IdSearchTextBox.Text.ToString() != idCheck)
                {
                    Notice.Text = "Product doesnt exist";
                }
                else
                {
                    Notice.Text = "";

                }

                // check if the item can be insured and if its type is a laptop or a smartphone.
                if ( itemType.CanBeInsured == true && (ProductTypeLabel.Text == "Laptops" || ProductTypeLabel.Text == "Smartphones"))
                {
                    // check the current SalePrice of the item then display the calulated total insurance cost.
                    switch (item.SalesPrice)
                    {
                        // in case the item price is less than 500 then display 500 for insurance.
                        case var price when (price < 500 ):
                            TotalCost.Text = $"{0 + 500} €";
                            break;

                        case var price when (price < 2000 && price >= 500 ):
                            TotalCost.Text = $"{1000 + 500} €";
                            break;

                        case var price when (price >= 2000 ):
                            TotalCost.Text = $"{2000 + 500} €";
                            break;
                    }

                } 

                // if the item can be insured but it isnt a laptop or a smart phone then run the following calculation instead.
                else if (itemType.CanBeInsured == true)
                {
                    switch (item.SalesPrice)
                    {
                        case var price when (price < 500):
                            TotalCost.Text = $"0 €";
                            break;

                        case var price when (price < 2000 && price >= 50):
                            TotalCost.Text = $"{1000} €";
                            break;

                        case var price when (price >= 2000):
                            TotalCost.Text = $"{2000} €";
                            break;
                    }

                }

                //if the product can't be insured then display insurace cost as 0;
                else
                {
                    TotalCost.Text = $"0 €";
                }

            }
            else
            {
                // Inform the user that the text box only accepts numbers if there is a misinput.
                Notice.Text = "Input Accepts only Numbers";
            }
        }

        /// <summary>
        /// use the enter key to run the funtion ProductSearch() as a secondery interface.
        /// </summary>
        private void IdSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductOutput();
            }
           
        }

        private void TotalCost_Click(object sender, EventArgs e)
        {

        }

        private void ProductID_Load(object sender, EventArgs e)
        {

        }
    }
}
