
namespace POS.ListingForm
{
    partial class VoucherList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVoucherList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.colHeaderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucherList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVoucherList
            // 
            this.dgvVoucherList.AllowUserToAddRows = false;
            this.dgvVoucherList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVoucherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoucherList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHeaderId,
            this.colVoucherNo,
            this.colVoucherDate,
            this.colSubTotal,
            this.colTax,
            this.colGrandTotal,
            this.colIsActive,
            this.colEdit});
            this.dgvVoucherList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVoucherList.Location = new System.Drawing.Point(0, 47);
            this.dgvVoucherList.Name = "dgvVoucherList";
            this.dgvVoucherList.Size = new System.Drawing.Size(890, 466);
            this.dgvVoucherList.TabIndex = 9;
            this.dgvVoucherList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucherList_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 47);
            this.panel1.TabIndex = 8;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(98, 11);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 25;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // colHeaderId
            // 
            this.colHeaderId.DataPropertyName = "HeaderId";
            this.colHeaderId.HeaderText = "HeaderId";
            this.colHeaderId.Name = "colHeaderId";
            this.colHeaderId.Visible = false;
            // 
            // colVoucherNo
            // 
            this.colVoucherNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVoucherNo.DataPropertyName = "VoucherNo";
            this.colVoucherNo.FillWeight = 70F;
            this.colVoucherNo.HeaderText = "Voucher No";
            this.colVoucherNo.Name = "colVoucherNo";
            // 
            // colVoucherDate
            // 
            this.colVoucherDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVoucherDate.DataPropertyName = "VoucherDate";
            this.colVoucherDate.HeaderText = "Voucher Date";
            this.colVoucherDate.Name = "colVoucherDate";
            this.colVoucherDate.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubTotal.DataPropertyName = "SubTotal";
            this.colSubTotal.FillWeight = 80F;
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // colTax
            // 
            this.colTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTax.DataPropertyName = "Tax";
            this.colTax.FillWeight = 50F;
            this.colTax.HeaderText = "Tax";
            this.colTax.Name = "colTax";
            this.colTax.ReadOnly = true;
            // 
            // colGrandTotal
            // 
            this.colGrandTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGrandTotal.DataPropertyName = "GrandTotal";
            this.colGrandTotal.HeaderText = "GrandTotal";
            this.colGrandTotal.Name = "colGrandTotal";
            // 
            // colIsActive
            // 
            this.colIsActive.DataPropertyName = "IsActive";
            this.colIsActive.HeaderText = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = false;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // VoucherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 513);
            this.Controls.Add(this.dgvVoucherList);
            this.Controls.Add(this.panel1);
            this.Name = "VoucherList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoucherList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucherList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVoucherList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeaderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrandTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    }
}