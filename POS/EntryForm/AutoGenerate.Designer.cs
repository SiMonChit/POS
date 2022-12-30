
namespace POS.EntryForm
{
    partial class AutoGenerate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudLastValue = new System.Windows.Forms.NumericUpDown();
            this.txtVoucherType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSynbol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAutoGenerate = new System.Windows.Forms.DataGridView();
            this.colGenerateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSynbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenerateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenerateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudLastValue);
            this.panel1.Controls.Add(this.txtVoucherType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSynbol);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 113);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "(5)";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(446, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(446, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(446, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Last Value";
            // 
            // nudLastValue
            // 
            this.nudLastValue.Location = new System.Drawing.Point(264, 74);
            this.nudLastValue.Name = "nudLastValue";
            this.nudLastValue.Size = new System.Drawing.Size(153, 20);
            this.nudLastValue.TabIndex = 23;
            // 
            // txtVoucherType
            // 
            this.txtVoucherType.Location = new System.Drawing.Point(264, 22);
            this.txtVoucherType.Name = "txtVoucherType";
            this.txtVoucherType.Size = new System.Drawing.Size(153, 20);
            this.txtVoucherType.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Voucher Type";
            // 
            // txtSynbol
            // 
            this.txtSynbol.Location = new System.Drawing.Point(264, 48);
            this.txtSynbol.Name = "txtSynbol";
            this.txtSynbol.Size = new System.Drawing.Size(128, 20);
            this.txtSynbol.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Synbol";
            // 
            // dgvAutoGenerate
            // 
            this.dgvAutoGenerate.AllowUserToAddRows = false;
            this.dgvAutoGenerate.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAutoGenerate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoGenerate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGenerateID,
            this.colSynbol,
            this.colLastValue,
            this.colGenerateDate,
            this.colGenerateType,
            this.colEdit});
            this.dgvAutoGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAutoGenerate.Location = new System.Drawing.Point(0, 113);
            this.dgvAutoGenerate.Name = "dgvAutoGenerate";
            this.dgvAutoGenerate.Size = new System.Drawing.Size(680, 340);
            this.dgvAutoGenerate.TabIndex = 1;
            this.dgvAutoGenerate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutoGenerate_CellContentClick);
            // 
            // colGenerateID
            // 
            this.colGenerateID.DataPropertyName = "GenerateID";
            this.colGenerateID.HeaderText = "GenerateID";
            this.colGenerateID.Name = "colGenerateID";
            this.colGenerateID.Visible = false;
            // 
            // colSynbol
            // 
            this.colSynbol.DataPropertyName = "Synbol";
            this.colSynbol.HeaderText = "Synbol";
            this.colSynbol.Name = "colSynbol";
            // 
            // colLastValue
            // 
            this.colLastValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLastValue.DataPropertyName = "LastValue";
            this.colLastValue.HeaderText = "Last Value";
            this.colLastValue.Name = "colLastValue";
            this.colLastValue.ReadOnly = true;
            // 
            // colGenerateDate
            // 
            this.colGenerateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGenerateDate.DataPropertyName = "GenerateDate";
            this.colGenerateDate.HeaderText = "Generate Date";
            this.colGenerateDate.Name = "colGenerateDate";
            this.colGenerateDate.ReadOnly = true;
            // 
            // colGenerateType
            // 
            this.colGenerateType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGenerateType.DataPropertyName = "GenerateType";
            this.colGenerateType.HeaderText = "Generate Type";
            this.colGenerateType.Name = "colGenerateType";
            this.colGenerateType.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEdit.FillWeight = 50F;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // AutoGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 453);
            this.Controls.Add(this.dgvAutoGenerate);
            this.Controls.Add(this.panel1);
            this.Name = "AutoGenerate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoGenerate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLastValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoGenerate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAutoGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudLastValue;
        private System.Windows.Forms.TextBox txtVoucherType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSynbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenerateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSynbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenerateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenerateType;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    }
}