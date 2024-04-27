namespace MD_MUNTAKIM_BIN_HOSSAIN_P00194964
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBarchart = new System.Windows.Forms.Button();
            this.btnExpenserecord = new System.Windows.Forms.Button();
            this.btnExpenseitem = new System.Windows.Forms.Button();
            this.btnExpensecategory = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnManagerUse = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusWelcome,
            this.toolStripStatusLabel2,
            this.toolStripStatusClock});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripStatusWelcome
            // 
            this.toolStripStatusWelcome.Name = "toolStripStatusWelcome";
            this.toolStripStatusWelcome.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusWelcome.Text = "Welcome";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(653, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusClock
            // 
            this.toolStripStatusClock.Name = "toolStripStatusClock";
            this.toolStripStatusClock.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusClock.Text = "Clock";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Tan;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.pnlMenu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(801, 57);
            this.pnlTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(42, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 31);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Expense Tracker System";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlMenu.Location = new System.Drawing.Point(0, 73);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 100);
            this.pnlMenu.TabIndex = 2;
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlMainMenu.Controls.Add(this.btnManagerUse);
            this.pnlMainMenu.Controls.Add(this.btnLogout);
            this.pnlMainMenu.Controls.Add(this.btnBarchart);
            this.pnlMainMenu.Controls.Add(this.btnExpenserecord);
            this.pnlMainMenu.Controls.Add(this.btnExpenseitem);
            this.pnlMainMenu.Controls.Add(this.btnExpensecategory);
            this.pnlMainMenu.Controls.Add(this.btnCustomer);
            this.pnlMainMenu.Controls.Add(this.btnHome);
            this.pnlMainMenu.Controls.Add(this.pnlTitle);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 57);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(200, 418);
            this.pnlMainMenu.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.Location = new System.Drawing.Point(0, 265);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 33);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBarchart
            // 
            this.btnBarchart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarchart.Location = new System.Drawing.Point(0, 232);
            this.btnBarchart.Name = "btnBarchart";
            this.btnBarchart.Size = new System.Drawing.Size(200, 33);
            this.btnBarchart.TabIndex = 11;
            this.btnBarchart.Text = "Bar Chart";
            this.btnBarchart.UseVisualStyleBackColor = true;
            this.btnBarchart.Click += new System.EventHandler(this.btnBarchart_Click);
            // 
            // btnExpenserecord
            // 
            this.btnExpenserecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenserecord.Location = new System.Drawing.Point(0, 199);
            this.btnExpenserecord.Name = "btnExpenserecord";
            this.btnExpenserecord.Size = new System.Drawing.Size(200, 33);
            this.btnExpenserecord.TabIndex = 9;
            this.btnExpenserecord.Text = "Expense Record";
            this.btnExpenserecord.UseVisualStyleBackColor = true;
            this.btnExpenserecord.Click += new System.EventHandler(this.btnExpenserecord_Click);
            // 
            // btnExpenseitem
            // 
            this.btnExpenseitem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenseitem.Location = new System.Drawing.Point(0, 166);
            this.btnExpenseitem.Name = "btnExpenseitem";
            this.btnExpenseitem.Size = new System.Drawing.Size(200, 33);
            this.btnExpenseitem.TabIndex = 8;
            this.btnExpenseitem.Text = "Expense Item";
            this.btnExpenseitem.UseVisualStyleBackColor = true;
            this.btnExpenseitem.Click += new System.EventHandler(this.btnExpenseitem_Click);
            // 
            // btnExpensecategory
            // 
            this.btnExpensecategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpensecategory.Location = new System.Drawing.Point(0, 133);
            this.btnExpensecategory.Name = "btnExpensecategory";
            this.btnExpensecategory.Size = new System.Drawing.Size(200, 33);
            this.btnExpensecategory.TabIndex = 7;
            this.btnExpensecategory.Text = "Expense Category";
            this.btnExpensecategory.UseVisualStyleBackColor = true;
            this.btnExpensecategory.Click += new System.EventHandler(this.btnExpensecategory_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.Location = new System.Drawing.Point(0, 100);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(200, 33);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Location = new System.Drawing.Point(0, 67);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 33);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(200, 67);
            this.pnlTitle.TabIndex = 3;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(200, 57);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(601, 418);
            this.pnlContainer.TabIndex = 3;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // btnManagerUse
            // 
            this.btnManagerUse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagerUse.Location = new System.Drawing.Point(0, 298);
            this.btnManagerUse.Name = "btnManagerUse";
            this.btnManagerUse.Size = new System.Drawing.Size(200, 30);
            this.btnManagerUse.TabIndex = 13;
            this.btnManagerUse.Text = "Manager User";
            this.btnManagerUse.UseVisualStyleBackColor = true;
            this.btnManagerUse.Click += new System.EventHandler(this.btnManagerUse_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 497);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FRM_MainMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusWelcome;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBarchart;
        private System.Windows.Forms.Button btnExpenserecord;
        private System.Windows.Forms.Button btnExpenseitem;
        private System.Windows.Forms.Button btnExpensecategory;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManagerUse;
    }
}