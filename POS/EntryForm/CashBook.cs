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
    public partial class CashBook : Form
    {
        CashBookDataController dataController;
        dsPOS.CashBookDataTable cashBooks;
        int cashbookid;

        public CashBook()
        {
            InitializeComponent();
            dataController = new CashBookDataController();
            cashBooks = new dsPOS.CashBookDataTable();
            CashBookDataBind();
        }
        private void ClearControl()
        {
            txtCode.Clear();
            txtName.Clear();
            cashbookid = 0;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }
        private void CashBookDataBind()
        {
            dgvCashBook.AutoGenerateColumns = false;
            dgvCashBook.DataSource = dataController.Select();
        }
        private void SaveUpdate()
        {
            dsPOS.CashBookRow cashBookRow = cashBooks.NewCashBookRow();

            cashBookRow.CashBookID = cashbookid;
            cashBookRow.Code = txtCode.Text;
            cashBookRow.Name = txtName.Text;

            if (cashbookid == 0)
                dataController.Insert(cashBookRow);
            else
                dataController.Update(cashBookRow);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveUpdate();
                CashBookDataBind();
                ClearControl();
                MessageBox.Show("Insert Successful", "Cashbook insert");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SaveUpdate();
                CashBookDataBind();
                ClearControl();
                MessageBox.Show("Update Successful", "Cashbook update");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCashBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCashBook.Columns[dgvCashBook.CurrentCell.ColumnIndex].Name;

        }
    }
}
