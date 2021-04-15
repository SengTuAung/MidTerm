namespace WarehousePizza
{
    partial class TransactionsScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAllTransactions = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(189, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Transactions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "All Transactions:";
            // 
            // txtAllTransactions
            // 
            this.txtAllTransactions.BackColor = System.Drawing.Color.White;
            this.txtAllTransactions.Location = new System.Drawing.Point(23, 91);
            this.txtAllTransactions.Multiline = true;
            this.txtAllTransactions.Name = "txtAllTransactions";
            this.txtAllTransactions.ReadOnly = true;
            this.txtAllTransactions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAllTransactions.Size = new System.Drawing.Size(547, 241);
            this.txtAllTransactions.TabIndex = 7;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenu.Location = new System.Drawing.Point(206, 338);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(166, 50);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // TransactionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 400);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtAllTransactions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TransactionsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.TransactionsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAllTransactions;
        private System.Windows.Forms.Button btnMenu;
    }
}