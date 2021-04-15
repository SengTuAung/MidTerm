using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarehousePizza
{
    public partial class WelcomeScreen : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public WelcomeScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //4-13-2021 Saung New 8L: Add Product button click
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductScreen addProductScreen = new AddProductScreen();
            addProductScreen.ShowDialog();
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //4-13-2021 Saung New 8L: Add Order button click
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrderScreen addOrderScreen = new AddOrderScreen();
            addOrderScreen.ShowDialog();
        }
        /// <summary>
        ///=
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //4-13-2021 Saung New 8L:Transactions button click
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TransactionsScreen transactionsScreen = new TransactionsScreen();
            transactionsScreen.ShowDialog();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
