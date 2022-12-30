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

namespace POS.EntryForm
{
    public partial class Category : Form
    {
        CategoryDataController dataCotroller;
        int categoryid;

        public Category()
        {
            InitializeComponent();
            dataCotroller = new CategoryDataController();
            btnUpdate.Enabled = false;
            CategoryDataBind();
            ClearControl();
        }

        private void CategoryDataBind()
        {
            dgvCategory.DataSource = dataCotroller.Select();
            dgvCategory.AutoGenerateColumns = false;
        }
        private void ClearControl()
        {
            txtCategoryName.Clear();
            txtCode.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            categoryid = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text)) MessageBox.Show("Add category code !", "CategoryCode");
            if(string.IsNullOrEmpty(txtCategoryName.Text)) MessageBox.Show("Add category name !", "CategoryName");

            dataCotroller.Insert(txtCode.Text, txtCategoryName.Text);

            CategoryDataBind();
            ClearControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataCotroller.Update(categoryid ,txtCode.Text, txtCategoryName.Text);

            CategoryDataBind();
            ClearControl();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[dgvCategory.CurrentCell.ColumnIndex].Name;

            if (colName == "colEdit")
            {
                categoryid = Convert.ToInt32(dgvCategory.CurrentRow.Cells["colCategoryID"].Value);
                txtCode.Text = dgvCategory.CurrentRow.Cells["colCode"].Value.ToString();
                txtCategoryName.Text = dgvCategory.CurrentRow.Cells["colCategoryName"].Value.ToString();

                CategoryDataBind();
                ClearControl();
            }
            if (colName == "colDel")
            {
                categoryid = Convert.ToInt32(dgvCategory.CurrentRow.Cells["colCategoryID"].Value);
                dataCotroller.Delete(categoryid);
                CategoryDataBind();
                ClearControl();
            }
        }
    }
}
