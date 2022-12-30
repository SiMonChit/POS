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
    public partial class PurchaseList : Form
    {
        PurchaseDataController dataController;
        public PurchaseList()
        {
            InitializeComponent();
            dataController = new PurchaseDataController();
        }
        int purchaseid;
        private void PurchaseDataBind()
        {
            dgvPurchaseList.AutoGenerateColumns = false;
            dgvPurchaseList.DataSource = dataController.Select();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntryForm.Purchase purchase = new EntryForm.Purchase();
            purchase.ShowDialog();
        }

        private void PurchaseList_Activated(object sender, EventArgs e)
        {
            PurchaseDataBind();
        }

        private void dgvPurchaseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
