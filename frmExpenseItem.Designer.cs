namespace MD_MUNTAKIM_BIN_HOSSAIN_P00194964
{
    partial class frmExpenseItem
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
            this.txtItemname = new System.Windows.Forms.TextBox();
            this.lblcategoryrname = new System.Windows.Forms.Label();
            this.txtItemid = new System.Windows.Forms.TextBox();
            this.lblCategoryid = new System.Windows.Forms.Label();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.cboExpensecategory = new System.Windows.Forms.ComboBox();
            this.lblExpensecategory = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblItemcost = new System.Windows.Forms.Label();
            this.txtItemdescription = new System.Windows.Forms.TextBox();
            this.lblItemdescription = new System.Windows.Forms.Label();
            this.gV = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expensecategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlTitle.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(378, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(277, 244);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtItemname
            // 
            this.txtItemname.Location = new System.Drawing.Point(277, 48);
            this.txtItemname.Name = "txtItemname";
            this.txtItemname.Size = new System.Drawing.Size(176, 20);
            this.txtItemname.TabIndex = 11;
            // 
            // lblcategoryrname
            // 
            this.lblcategoryrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoryrname.Location = new System.Drawing.Point(57, 45);
            this.lblcategoryrname.Name = "lblcategoryrname";
            this.lblcategoryrname.Size = new System.Drawing.Size(137, 23);
            this.lblcategoryrname.TabIndex = 10;
            this.lblcategoryrname.Text = "Item Name:";
            this.lblcategoryrname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemid
            // 
            this.txtItemid.Location = new System.Drawing.Point(277, 15);
            this.txtItemid.Name = "txtItemid";
            this.txtItemid.ReadOnly = true;
            this.txtItemid.Size = new System.Drawing.Size(143, 20);
            this.txtItemid.TabIndex = 9;
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
            this.btnAddnew.Location = new System.Drawing.Point(787, 12);
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
            this.lblTitle.Size = new System.Drawing.Size(657, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Expense Item";
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
            this.pnlTitle.Size = new System.Drawing.Size(946, 100);
            this.pnlTitle.TabIndex = 14;
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlData.Controls.Add(this.cboExpensecategory);
            this.pnlData.Controls.Add(this.lblExpensecategory);
            this.pnlData.Controls.Add(this.txtCost);
            this.pnlData.Controls.Add(this.lblItemcost);
            this.pnlData.Controls.Add(this.txtItemdescription);
            this.pnlData.Controls.Add(this.lblItemdescription);
            this.pnlData.Controls.Add(this.btnClose);
            this.pnlData.Controls.Add(this.btnInsert);
            this.pnlData.Controls.Add(this.txtItemname);
            this.pnlData.Controls.Add(this.lblcategoryrname);
            this.pnlData.Controls.Add(this.txtItemid);
            this.pnlData.Controls.Add(this.lblCategoryid);
            this.pnlData.Location = new System.Drawing.Point(73, 234);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(502, 280);
            this.pnlData.TabIndex = 13;
            // 
            // cboExpensecategory
            // 
            this.cboExpensecategory.FormattingEnabled = true;
            this.cboExpensecategory.Location = new System.Drawing.Point(277, 185);
            this.cboExpensecategory.Name = "cboExpensecategory";
            this.cboExpensecategory.Size = new System.Drawing.Size(121, 21);
            this.cboExpensecategory.TabIndex = 25;
            // 
            // lblExpensecategory
            // 
            this.lblExpensecategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpensecategory.Location = new System.Drawing.Point(57, 184);
            this.lblExpensecategory.Name = "lblExpensecategory";
            this.lblExpensecategory.Size = new System.Drawing.Size(137, 23);
            this.lblExpensecategory.TabIndex = 24;
            this.lblExpensecategory.Text = "Expense Category";
            this.lblExpensecategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(277, 80);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(176, 20);
            this.txtCost.TabIndex = 23;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            // 
            // lblItemcost
            // 
            this.lblItemcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemcost.Location = new System.Drawing.Point(57, 78);
            this.lblItemcost.Name = "lblItemcost";
            this.lblItemcost.Size = new System.Drawing.Size(137, 23);
            this.lblItemcost.TabIndex = 22;
            this.lblItemcost.Text = "Item Cost";
            this.lblItemcost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemdescription
            // 
            this.txtItemdescription.Location = new System.Drawing.Point(277, 115);
            this.txtItemdescription.Multiline = true;
            this.txtItemdescription.Name = "txtItemdescription";
            this.txtItemdescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtItemdescription.Size = new System.Drawing.Size(176, 62);
            this.txtItemdescription.TabIndex = 21;
            // 
            // lblItemdescription
            // 
            this.lblItemdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemdescription.Location = new System.Drawing.Point(57, 112);
            this.lblItemdescription.Name = "lblItemdescription";
            this.lblItemdescription.Size = new System.Drawing.Size(137, 23);
            this.lblItemdescription.TabIndex = 20;
            this.lblItemdescription.Text = "Item Description";
            this.lblItemdescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gV
            // 
            this.gV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cItemname,
            this.colCost,
            this.Description,
            this.Expensecategory,
            this.btnEdit,
            this.btnDelete});
            this.gV.Location = new System.Drawing.Point(0, 118);
            this.gV.Name = "gV";
            this.gV.Size = new System.Drawing.Size(847, 209);
            this.gV.TabIndex = 15;
            this.gV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gV_CellContentClick);
            // 
            // cId
            // 
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            // 
            // cItemname
            // 
            this.cItemname.HeaderText = "Item Name";
            this.cItemname.Name = "cItemname";
            // 
            // colCost
            // 
            this.colCost.HeaderText = "Item Cost";
            this.colCost.MinimumWidth = 8;
            this.colCost.Name = "colCost";
            this.colCost.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Expensecategory
            // 
            this.Expensecategory.HeaderText = "Expense Category";
            this.Expensecategory.Name = "Expensecategory";
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
            // frmExpenseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(946, 514);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.gV);
            this.Name = "frmExpenseItem";
            this.Text = "frmExpenseItem";
            this.Load += new System.EventHandler(this.frmExpenseItem_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtItemname;
        private System.Windows.Forms.Label lblcategoryrname;
        private System.Windows.Forms.TextBox txtItemid;
        private System.Windows.Forms.Label lblCategoryid;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView gV;
        private System.Windows.Forms.TextBox txtItemdescription;
        private System.Windows.Forms.Label lblItemdescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblItemcost;
        private System.Windows.Forms.ComboBox cboExpensecategory;
        private System.Windows.Forms.Label lblExpensecategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expensecategory;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}