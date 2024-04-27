namespace MD_MUNTAKIM_BIN_HOSSAIN_P00194964
{
    partial class frmExpenseCategory
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCategoryname = new System.Windows.Forms.TextBox();
            this.lblcategoryrname = new System.Windows.Forms.Label();
            this.txtCategoryid = new System.Windows.Forms.TextBox();
            this.lblCategoryid = new System.Windows.Forms.Label();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.gV = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlTitle.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(378, 135);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(277, 135);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // txtCategoryname
            // 
            this.txtCategoryname.Location = new System.Drawing.Point(277, 48);
            this.txtCategoryname.Name = "txtCategoryname";
            this.txtCategoryname.Size = new System.Drawing.Size(176, 20);
            this.txtCategoryname.TabIndex = 11;
            // 
            // lblcategoryrname
            // 
            this.lblcategoryrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoryrname.Location = new System.Drawing.Point(57, 45);
            this.lblcategoryrname.Name = "lblcategoryrname";
            this.lblcategoryrname.Size = new System.Drawing.Size(137, 23);
            this.lblcategoryrname.TabIndex = 10;
            this.lblcategoryrname.Text = "Category Name:";
            this.lblcategoryrname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCategoryid
            // 
            this.txtCategoryid.Location = new System.Drawing.Point(277, 15);
            this.txtCategoryid.Name = "txtCategoryid";
            this.txtCategoryid.ReadOnly = true;
            this.txtCategoryid.Size = new System.Drawing.Size(143, 20);
            this.txtCategoryid.TabIndex = 9;
            // 
            // lblCategoryid
            // 
            this.lblCategoryid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryid.Location = new System.Drawing.Point(57, 12);
            this.lblCategoryid.Name = "lblCategoryid";
            this.lblCategoryid.Size = new System.Drawing.Size(137, 23);
            this.lblCategoryid.TabIndex = 8;
            this.lblCategoryid.Text = "ID:";
            this.lblCategoryid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddnew
            // 
            this.btnAddnew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddnew.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnew.Location = new System.Drawing.Point(815, 12);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(147, 78);
            this.btnAddnew.TabIndex = 1;
            this.btnAddnew.Text = "+ Add New";
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(124, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(685, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Expense Category";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTitle.Controls.Add(this.btnAddnew);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(974, 100);
            this.pnlTitle.TabIndex = 11;
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlData.Controls.Add(this.btnClose);
            this.pnlData.Controls.Add(this.btnInsert);
            this.pnlData.Controls.Add(this.txtCategoryname);
            this.pnlData.Controls.Add(this.lblcategoryrname);
            this.pnlData.Controls.Add(this.txtCategoryid);
            this.pnlData.Controls.Add(this.lblCategoryid);
            this.pnlData.Location = new System.Drawing.Point(152, 222);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(480, 204);
            this.pnlData.TabIndex = 10;
            this.pnlData.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlData_Paint);
            // 
            // gV
            // 
            this.gV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cCategoryname,
            this.btnEdit,
            this.btnDelete});
            this.gV.Location = new System.Drawing.Point(0, 106);
            this.gV.Name = "gV";
            this.gV.Size = new System.Drawing.Size(959, 209);
            this.gV.TabIndex = 12;
            this.gV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gV_CellContentClick_1);
            // 
            // cId
            // 
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            // 
            // cCategoryname
            // 
            this.cCategoryname.HeaderText = "Category name";
            this.cCategoryname.Name = "cCategoryname";
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Edit";
            this.btnEdit.ToolTipText = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // frmExpenseCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(974, 518);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.gV);
            this.Name = "frmExpenseCategory";
            this.Text = "frmExpenseCategory";
            this.Load += new System.EventHandler(this.frmExpenseCategory_Load_1);
            this.pnlTitle.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtCategoryname;
        private System.Windows.Forms.Label lblcategoryrname;
        private System.Windows.Forms.TextBox txtCategoryid;
        private System.Windows.Forms.Label lblCategoryid;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView gV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategoryname;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}