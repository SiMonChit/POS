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
    public partial class ItemsList : Form
    {
        ItemsDataController dataController;
        int itemsid;
        public ItemsList()
        {
            InitializeComponent();

            dataController = new ItemsDataController();
            ItemsDataBind();
        }

        private void ItemsDataBind()
        {
            dgvItemsList.AutoGenerateColumns = false;
            dgvItemsList.DataSource = dataController.Select();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntryForm.Items items = new EntryForm.Items();
            items.ShowDialog();
        }

        private void dgvItemsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvItemsList.Columns[dgvItemsList.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                itemsid = Convert.ToInt32(dgvItemsList.CurrentRow.Cells["colItemsID"].Value);

                EntryForm.Items items = new EntryForm.Items(itemsid);
                items.ShowDialog();
            }
           
        }

        private void ItemsList_Activated(object sender, EventArgs e)
        {
            ItemsDataBind();
        }
    }
}
