using POS.DataAccess;
using POS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.EntryForm
{
    public partial class Expense : Form
    {
        ExpenseDataController dataController;
        CashBookDataController CashBookData;
        dsPOS.ExpenseDataTable expenses;
        string expenseid;

        public Expense()
        {
            InitializeComponent();
            dataController = new ExpenseDataController();
            CashBookData = new CashBookDataController();
            expenses = new dsPOS.ExpenseDataTable();

            CashBookDataBind();
            ClearControl();
        }
        private void CashBookDataBind()
        {
            cboCashBook.DataSource = CashBookData.SelectForDropDown();
            cboCashBook.DisplayMember = "Code";
            cboCashBook.ValueMember = "CashBookID";
        }
        private void ClearControl()
        {
            expenseid = "";
            txtApproveBy.Text = txtDescription.Text = string.Empty;
            nudAmount.Value = 0;
        }

        private void SaveUpdate()
        {
            dsPOS.ExpenseRow expenseRow = expenses.NewExpenseRow();

            expenseRow.ExpenseID = expenseid;
            expenseRow.CashBookID = Convert.ToInt32(cboCashBook.SelectedValue);
            expenseRow.Description = txtDescription.Text;
            expenseRow.AproveBy = txtApproveBy.Text;
            expenseRow.Amount = nudAmount.Value;
            expenseRow.ExpDate = dtpExpenseDate.Value;

            if (expenseid == "")
                dataController.Insert(expenseRow);
            else
                dataController.Update(expenseRow);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveUpdate();
                ClearControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SaveUpdate();
                ClearControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CashBook cashBook = new CashBook();
            cashBook.ShowDialog();
        }

        private void Expense_Activated(object sender, EventArgs e)
        {
            CashBookDataBind();
        }
    }
}
