using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            EntryForm.Category category = new EntryForm.Category();
            category.ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            ListingForm.ItemsList itemsList = new ListingForm.ItemsList();
            itemsList.ShowDialog();
        }

        private void btnAutoGenerate_Click(object sender, EventArgs e)
        {
            EntryForm.AutoGenerate autoGenerate = new EntryForm.AutoGenerate();
            autoGenerate.ShowDialog();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            ListingForm.ExpenseList expenseList = new ListingForm.ExpenseList();
            expenseList.ShowDialog();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ListingForm.PurchaseList purchaseList = new ListingForm.PurchaseList();
            purchaseList.ShowDialog();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            ListingForm.VoucherList voucherList = new ListingForm.VoucherList();
            voucherList.ShowDialog();
        }
    }
}
