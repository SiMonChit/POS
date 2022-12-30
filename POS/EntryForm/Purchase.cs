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
    public partial class Purchase : Form
    {
        PurchaseDataController dataController;
        ItemsDataController itemData;
        AutoCompleteStringCollection itemCollection;
        dsPOS.PurchaseDataTable purchases;
        int purchaseid, itemid;
        public Purchase()
        {
            InitializeComponent();
            dataController = new PurchaseDataController();
            itemData = new ItemsDataController();
            itemCollection = new AutoCompleteStringCollection();
            purchases = new dsPOS.PurchaseDataTable();

            ItemDataBind();
        }
        private void ClearControl()
        {
            purchaseid = itemid = 0;
            txtItemCode.Text = txtItemName.Text = txtAmount.Text = "";
            nudBuyPrice.Value = nudQty.Value = 0;
            btnUpdate.Enabled = btnDelete.Enabled = false;
        }
        private void ItemDataBind()
        {
            dsPOS.ItemsDataTable stockInfo = itemData.Select();

            foreach (DataRow row in stockInfo.Rows)
            {
                itemCollection.Add(row["ItemCode"].ToString() + "      " + row["ItemName"].ToString());
            }
            txtItemCode.AutoCompleteCustomSource = itemCollection;
        }

        private void SaveUpdate()
        {
            dsPOS.PurchaseRow purchaseRow = purchases.NewPurchaseRow();
            purchaseRow.PurchaseID = purchaseid;
            purchaseRow.ItemsID = itemid;
            purchaseRow.Qty = Convert.ToInt32(nudQty.Value);
            purchaseRow.BuyPrice = nudBuyPrice.Value;
            purchaseRow.Amount = (nudQty.Value * nudBuyPrice.Value);
            purchaseRow.PurchaseDate = dtpPurchaseDate.Value;

            if (purchaseid == 0)
                dataController.Insert(purchaseRow);
            else
                dataController.Update(purchaseRow);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SaveUpdate();
                ClearControl();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void txtItemCode_Leave(object sender, EventArgs e)
        {
            int i = txtItemCode.Text.Trim().IndexOf("     ");
            if (i > 0) txtItemCode.Text = (txtItemCode.Text.Remove(i)).Trim();

            if (string.IsNullOrEmpty(this.txtItemCode.Text)) return;

            dsPOS.ItemsRow itemsRow = itemData.SelectByCode(txtItemCode.Text);

            if (itemsRow != null)
            {
                itemid = itemsRow.ItemsID;
                txtItemCode.Text = itemsRow.ItemCode;
                txtItemName.Text = itemsRow.ItemName;
               
            }
            else
            {
                MessageBox.Show("No data to display", "No Data", MessageBoxButtons.OK);
                txtItemCode.Clear();
                txtItemCode.Focus();
            }
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
    }
}
