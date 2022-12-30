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
    public partial class VoucherList : Form
    {
        public VoucherList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntryForm.SaleForm saleForm = new EntryForm.SaleForm();
            saleForm.ShowDialog();
        }

        private void dgvVoucherList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
