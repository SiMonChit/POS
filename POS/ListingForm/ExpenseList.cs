using POS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.ListingForm
{
    public partial class ExpenseList : Form
    {
        ExpenseDataController dataController;
        public ExpenseList()
        {
            InitializeComponent();
            dataController = new ExpenseDataController();
        }
        private void ExpenseDataBind()
        {
            dgvExpenseList.AutoGenerateColumns = false;
            dgvExpenseList.DataSource = dataController.Select();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntryForm.Expense expense = new EntryForm.Expense();
            expense.ShowDialog();
        }

        private void ExpenseList_Activated(object sender, EventArgs e)
        {
            ExpenseDataBind();
        }
    }
}
