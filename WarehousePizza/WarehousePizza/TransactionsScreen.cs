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
    public partial class TransactionsScreen : Form
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public TransactionsScreen()
        {
            InitializeComponent();
            try
            //4-13-2021 Saung New 8L: Opening text file for output
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    if (File.Exists(openFileDialog.FileName))
                    {
                        txtAllTransactions.Text = File.ReadAllText(openFileDialog.FileName);
                    }

                }
            }
            catch (Exception exp) {

            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //4-13-2021 Saung New 8L: Close the Transactions Screen and display main menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransactionsScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
