namespace MD_MUNTAKIM_BIN_HOSSAIN_P00194964
{
    partial class frmCustomer
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
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCustomeremail = new System.Windows.Forms.TextBox();
            this.lblcustomeremail = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.lblcustomerphonenumber = new System.Windows.Forms.Label();
            this.txtCustomername = new System.Windows.Forms.TextBox();
            this.lblcustomername = new System.Windows.Forms.Label();
            this.txtCustomerid = new System.Windows.Forms.TextBox();
            this.lblcustomerid = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gV = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlData.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlData.Controls.Add(this.btnClose);
            this.pnlData.Controls.Add(this.btnInsert);
            this.pnlData.Controls.Add(this.txtCustomeremail);
            this.pnlData.Controls.Add(this.lblcustomeremail);
            this.pnlData.Controls.Add(this.txtPhonenumber);
            this.pnlData.Controls.Add(this.lblcustomerphonenumber);
            this.pnlData.Controls.Add(this.txtCustomername);
            this.pnlData.Controls.Add(this.lblcustomername);
            this.pnlData.Controls.Add(this.txtCustomerid);
            this.pnlData.Controls.Add(this.lblcustomerid);
            this.pnlData.Location = new System.Drawing.Point(201, 216);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(511, 255);
            this.pnlData.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(378, 221);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(277, 221);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCustomeremail
            // 
            this.txtCustomeremail.Location = new System.Drawing.Point(277, 81);
            this.txtCustomeremail.Name = "txtCustomeremail";
            this.txtCustomeremail.Size = new System.Drawing.Size(143, 20);
            this.txtCustomeremail.TabIndex = 15;
            // 
            // lblcustomeremail
            // 
            this.lblcustomeremail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcustomeremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomeremail.Location = new System.Drawing.Point(57, 78);
            this.lblcustomeremail.Name = "lblcustomeremail";
            this.lblcustomeremail.Size = new System.Drawing.Size(137, 23);
            this.lblcustomeremail.TabIndex = 14;
            this.lblcustomeremail.Text = "Email:";
            this.lblcustomeremail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(277, 114);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(143, 20);
            this.txtPhonenumber.TabIndex = 13;
            // 
            // lblcustomerphonenumber
            // 
            this.lblcustomerphonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcustomerphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerphonenumber.Location = new System.Drawing.Point(57, 111);
            this.lblcustomerphonenumber.Name = "lblcustomerphonenumber";
            this.lblcustomerphonenumber.Size = new System.Drawing.Size(137, 23);
            this.lblcustomerphonenumber.TabIndex = 12;
            this.lblcustomerphonenumber.Text = "Phone Number:";
            this.lblcustomerphonenumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomername
            // 
            this.txtCustomername.Location = new System.Drawing.Point(277, 48);
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.Size = new System.Drawing.Size(176, 20);
            this.txtCustomername.TabIndex = 11;
            // 
            // lblcustomername
            // 
            this.lblcustomername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomername.Location = new System.Drawing.Point(57, 45);
            this.lblcustomername.Name = "lblcustomername";
            this.lblcustomername.Size = new System.Drawing.Size(137, 23);
            this.lblcustomername.TabIndex = 10;
            this.lblcustomername.Text = "Customer Name:";
            this.lblcustomername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.Location = new System.Drawing.Point(277, 15);
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.ReadOnly = true;
            this.txtCustomerid.Size = new System.Drawing.Size(143, 20);
            this.txtCustomerid.TabIndex = 9;
            // 
            // lblcustomerid
            // 
            this.lblcustomerid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerid.Location = new System.Drawing.Point(57, 12);
            this.lblcustomerid.Name = "lblcustomerid";
            this.lblcustomerid.Size = new System.Drawing.Size(137, 23);
            this.lblcustomerid.TabIndex = 8;
            this.lblcustomerid.Text = "ID:";
            this.lblcustomerid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTitle.Controls.Add(this.btnAddnew);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(959, 100);
            this.pnlTitle.TabIndex = 8;
            // 
            // btnAddnew
            // 
            this.btnAddnew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddnew.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnew.Location = new System.Drawing.Point(800, 12);
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
            this.lblTitle.Size = new System.Drawing.Size(670, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Information";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gV
            // 
            this.gV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cUsername,
            this.cPhone,
            this.cEmail,
            this.cUser,
            this.btnEdit,
            this.btnDelete});
            this.gV.Location = new System.Drawing.Point(0, 106);
            this.gV.Name = "gV";
            this.gV.Size = new System.Drawing.Size(959, 209);
            this.gV.TabIndex = 9;
            this.gV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cId
            // 
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            // 
            // cUsername
            // 
            this.cUsername.HeaderText = "User name";
            this.cUsername.Name = "cUsername";
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "Email Address";
            this.cPhone.Name = "cPhone";
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Phone no";
            this.cEmail.Name = "cEmail";
            // 
            // cUser
            // 
            this.cUser.HeaderText = "User";
            this.cUser.Name = "cUser";
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
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(959, 515);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.gV);
            this.Controls.Add(this.pnlTitle);
            this.Name = "frmCustomer";
            this.Text = "FRM_Customer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.TextBox txtCustomeremail;
        private System.Windows.Forms.Label lblcustomeremail;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.Label lblcustomerphonenumber;
        private System.Windows.Forms.TextBox txtCustomername;
        private System.Windows.Forms.Label lblcustomername;
        private System.Windows.Forms.TextBox txtCustomerid;
        private System.Windows.Forms.Label lblcustomerid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView gV;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUser;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}