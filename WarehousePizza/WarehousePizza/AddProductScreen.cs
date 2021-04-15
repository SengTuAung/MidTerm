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
    public partial class AddProductScreen : Form
    {
        //4-13-2021 Saung New 8L: Inserting text files for the Product
        private const string fileName = "products.txt";
        public AddProductScreen()
        {
            InitializeComponent();
            int productID = 1;
            if (File.Exists(fileName))
            {
                productID = File.ReadAllLines(fileName).ToList().Count + 1;
            }

            txtID.Text = productID.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        //4-13-2021 Saung New 8L: Check if data is correct
        private bool isCorrectData() {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Plase, enter the product name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProductName.Text = "";
                txtProductName.Focus();
                return false;
            }
            double price = 0;
            //4-13-2021 Saung New 8L: Check if data is correct
            if (!double.TryParse(txtPrice.Text,out price) &&  price <= 0)
            {
                MessageBox.Show("Plase, enter the product price as numeric value more than zero.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrice.Text = "";
                txtPrice.Focus();
                return false;
            }
            //4-13-2021 Saung New 8L: Check if data is correct
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Plase, enter the product description.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Text = "";
                txtDescription.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Submit  button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //4-13-2021 Saung New 8L: Submit  button for the user input
            if (isCorrectData()) {
                using (StreamWriter streamWriter = File.AppendText(fileName))
                {
                   streamWriter.WriteLine(string.Format("{0}|{1}|{2}|{3}", txtID.Text, txtProductName.Text, txtPrice.Text, txtDescription.Text));
                }
                txtID.Text = "";
                txtProductName.Text = "";
                txtPrice.Text = "";
                txtDescription.Text = "";
                MessageBox.Show("The information about the product has been saved into the system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        /// <summary>
        /// Menu button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
