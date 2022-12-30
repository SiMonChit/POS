﻿using POS.DataAccess;
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
    public partial class AutoGenerate : Form
    {
        AutoGenerateDataController dataController;
        dsPOS.AutoGenerateDataTable autoGenerates;
        int generateid;

        public AutoGenerate()
        {
            InitializeComponent();
            dataController = new AutoGenerateDataController();
            autoGenerates = new dsPOS.AutoGenerateDataTable();

            AutoGenerateDataBind();
        }

        private void ClearControl()
        {
            txtSynbol.Clear();
            nudLastValue.Value = 0;
            txtVoucherType.Clear();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            generateid = 0;
        }

        private void AutoGenerateDataBind()
        {
            dgvAutoGenerate.AutoGenerateColumns = false;
            dgvAutoGenerate.DataSource = dataController.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dsPOS.AutoGenerateRow generateRow = autoGenerates.NewAutoGenerateRow();
            generateRow.GenerateType = txtVoucherType.Text;
            generateRow.LastValue = Convert.ToInt32(nudLastValue.Value);
            generateRow.Synbol = txtSynbol.Text;

            dataController.Insert(generateRow);
            AutoGenerateDataBind();
            ClearControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dsPOS.AutoGenerateRow generateRow = autoGenerates.NewAutoGenerateRow();

            generateRow.GenerateID = generateid;
            generateRow.GenerateType = txtVoucherType.Text;
            generateRow.LastValue = Convert.ToInt32(nudLastValue.Value);
            generateRow.Synbol = txtSynbol.Text;

            dataController.Update(generateRow);
            AutoGenerateDataBind();
            ClearControl();
        }

        private void dgvAutoGenerate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvAutoGenerate.Columns[dgvAutoGenerate.CurrentCell.ColumnIndex].Name;

            if (colName == "colEdit")
            {
                generateid = Convert.ToInt32(dgvAutoGenerate.CurrentRow.Cells["colGenerateID"].Value);
                txtSynbol.Text = dgvAutoGenerate.CurrentRow.Cells["colSynbol"].Value.ToString();
                txtVoucherType.Text = dgvAutoGenerate.CurrentRow.Cells["colGenerateType"].Value.ToString();
                nudLastValue.Value = Convert.ToDecimal(dgvAutoGenerate.CurrentRow.Cells["colLastValue"].Value);
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
