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
    public partial class Items : Form
    {
        ItemsDataController dataController;
        CategoryDataController categoryData;

        dsPOS.ItemsDataTable items;

        int itemsid;
        public Items()
        {
            InitializeComponent();
            dataController = new ItemsDataController();
            items = new dsPOS.ItemsDataTable();
            categoryData = new CategoryDataController();
            ClearControl();
            CategoryDataBind();
        }

        public Items(int id)
        {
            InitializeComponent();
            dataController = new ItemsDataController();
            items = new dsPOS.ItemsDataTable();
            categoryData = new CategoryDataController();
            BindDataToControl(id);
            CategoryDataBind();

        }

        private void ClearControl()
        {
            itemsid = 0;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtItemCode.Clear();
            txtItemName.Clear();
            nudBuyPrice.Value = 0;
            nudSellPrice.Value = 0;
            nudQty.Value = 0;
            picItemImage.Image = null;
            //this.Close();
        }

        private void CategoryDataBind()
        {
            cboCategory.DataSource = categoryData.Select();
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";
        }
        private void BindDataToControl(int id)
        {
            dsPOS.ItemsRow itemsRow = dataController.SelectByID(id);
            itemsid = itemsRow.ItemsID;
            cboCategory.SelectedValue = itemsRow.CategoryID;
            txtItemCode.Text = itemsRow.ItemCode;
            txtItemName.Text = itemsRow.ItemName;
            nudSellPrice.Value = itemsRow.SellPrice;
            nudBuyPrice.Value = itemsRow.BuyPrice;
            picItemImage.Image = itemsRow.ItemsImage == null ? null : Utility.ConvertByteArrayToImage(itemsRow.ItemsImage);
            picItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picItemImage.Refresh();

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        private void SaveUpdate(dsPOS.ItemsRow itemsRow)
        {
           
            itemsRow.ItemsID = itemsid;

            if (picItemImage.Image != null)
            {
                itemsRow.ItemsImage = Utility.ConvertImageToBinary(picItemImage.Image);
            }
            else
            {
                itemsRow.ItemsImage = null;
            }
            itemsRow.CategoryID = Convert.ToInt32(cboCategory.SelectedValue);
            itemsRow.ItemCode = txtItemCode.Text;
            itemsRow.ItemName = txtItemName.Text;
            itemsRow.SellPrice = nudSellPrice.Value;
            itemsRow.BuyPrice = nudBuyPrice.Value;
            itemsRow.Qty = 0;

            if (itemsid == 0)
            {
                dataController.Insert(itemsRow);
                MessageBox.Show("Insert successful", "Item Insert");
            }
            else
            {
                dataController.Update(itemsRow);
                MessageBox.Show("Update successful", "Item Insert");
            }
            
        }

        #region Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            dsPOS.ItemsRow itemsRow = items.NewItemsRow();
            SaveUpdate(itemsRow);
            ClearControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dsPOS.ItemsRow itemsRow = items.NewItemsRow();
            SaveUpdate(itemsRow);
            ClearControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Shop Image";
            openFile.Filter = "Images (*.BMP;*.JPG;,*.PNG)|*.BMP;*.JPG;*.PNG|" + "All files (*.*)|*.*";
            DialogResult dr = openFile.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                picItemImage.Image = Bitmap.FromFile(openFile.FileName);
                picItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                picItemImage.Refresh();
            }
        }

        #endregion

    }
}
