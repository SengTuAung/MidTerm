using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarehousePizza
{
    //4-13-2021 Saung New 8L: intiailizing  variables strings and list
    public partial class AddOrderScreen : Form
    {
        private string fileName = "orders.txt";
        private const string fileNameProducts = "products.txt";
        private List<string> prices = new List<string>();
        private List<string> descriptions = new List<string>();
        /// <summary>
        /// Constructor
        /// </summary>
        public AddOrderScreen()
        {
            InitializeComponent();
            //4-13-2021 Saung New 8L: Prompting  diffent values to add in orders
            try
            {
                if (File.Exists(fileNameProducts)) {
                    List<string> products = File.ReadAllLines(fileNameProducts).ToList();

                    for (int i = 0; i < products.Count; i++)
                    {
                        string[] values = products[i].Split('|');
                        cbProducts.Items.Add(values[1]);
                        prices.Add(values[2]);
                        descriptions.Add(values[3]);
                    }
                }

                openFile();
            }
            catch (Exception ex) {

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// 
        //4-13-2021 Saung New 8L: Opening the files
        private void openFile() {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                txtID.Text = "";
                cbProducts.SelectedIndex = -1;
                txtPrice.Text = "";
                txtCustomerName.Text = "";
            }

            int orderID = 1;
            if (File.Exists(fileName))
            {
                orderID = (File.ReadAllLines(fileName).ToList().Count/6) + 1;
            }

            txtID.Text = orderID.ToString();
        }

        /// <summary>
        /// 4-13-2021 Saung 12 NEWL : Check if data is correct
        /// </summary>
        /// <returns></returns>
        private bool isCorrectData()
        {
            if (cbProducts.SelectedIndex==-1)
            {
                MessageBox.Show("Plase, select the product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbProducts.Text = "";
                cbProducts.Focus();
                return false;
            }
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Plase, enter the customer name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerName.Text = "";
                txtCustomerName.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Save New Order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveNewOrder_Click(object sender, EventArgs e)
        {
            openFile();
        }
        /// <summary>
        /// Submit button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //4-13-2021 Saung New 8L: Checking the data whether if it is correct or not else it is registered            
            if (isCorrectData())
            {
                using (StreamWriter streamWriter = File.AppendText(fileName)){
                    streamWriter.WriteLine("The order ID: "+txtID.Text);
                    streamWriter.WriteLine("The product name: " + cbProducts.SelectedItem.ToString());
                    streamWriter.WriteLine("The product price: $" + txtPrice.Text);
                    streamWriter.WriteLine("The product description: " + descriptions[cbProducts.SelectedIndex]);
                    streamWriter.WriteLine("The customer name: "+ txtCustomerName.Text);
                    streamWriter.WriteLine();
                }
                txtID.Text = "";
                cbProducts.SelectedIndex = -1;
                txtPrice.Text = "";
                txtCustomerName.Text = "";
                MessageBox.Show("The information about the order has been saved into the system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        /// <summary>
        /// Menu button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// //4-13-2021 Saung New 8L: Products Selected Index Changed  
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducts.SelectedIndex != -1) {
                txtPrice.Text = prices[cbProducts.SelectedIndex];
            }
        }

        private void AddOrderScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
