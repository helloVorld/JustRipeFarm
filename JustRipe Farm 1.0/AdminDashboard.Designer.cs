namespace JustRipeFarm
{
    partial class AdminDashboard
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.jrfLabel = new System.Windows.Forms.Label();
            this.menuFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.userLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formWidthLbl = new System.Windows.Forms.Label();
            this.formHeightLbl = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelOperation = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInventory = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panelCommon = new System.Windows.Forms.Panel();
            this.lblUpdateField = new System.Windows.Forms.Label();
            this.cbUpdateField = new System.Windows.Forms.ComboBox();
            this.btnUpdateField = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cbFilter4 = new System.Windows.Forms.ComboBox();
            this.cbFilter3 = new System.Windows.Forms.ComboBox();
            this.cbFilter2 = new System.Windows.Forms.ComboBox();
            this.cbFilter1 = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.dgvDbTable = new System.Windows.Forms.DataGridView();
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            this.panelOperation.SuspendLayout();
            this.panelInventory.SuspendLayout();
            this.panelCommon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDbTable)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(935, 14);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 28);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // jrfLabel
            // 
            this.jrfLabel.AutoSize = true;
            this.jrfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jrfLabel.Location = new System.Drawing.Point(9, 11);
            this.jrfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jrfLabel.Name = "jrfLabel";
            this.jrfLabel.Size = new System.Drawing.Size(212, 31);
            this.jrfLabel.TabIndex = 2;
            this.jrfLabel.Text = "Just Ripe Farm";
            // 
            // menuFLP
            // 
            this.menuFLP.AutoScroll = true;
            this.menuFLP.Location = new System.Drawing.Point(13, 74);
            this.menuFLP.Margin = new System.Windows.Forms.Padding(4);
            this.menuFLP.Name = "menuFLP";
            this.menuFLP.Size = new System.Drawing.Size(160, 468);
            this.menuFLP.TabIndex = 11;
            
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(836, 22);
            this.userLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(93, 17);
            this.userLbl.TabIndex = 12;
            this.userLbl.Text = "name of User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "width :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "height :";
            // 
            // formWidthLbl
            // 
            this.formWidthLbl.AutoSize = true;
            this.formWidthLbl.Location = new System.Drawing.Point(309, 11);
            this.formWidthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formWidthLbl.Name = "formWidthLbl";
            this.formWidthLbl.Size = new System.Drawing.Size(46, 17);
            this.formWidthLbl.TabIndex = 15;
            this.formWidthLbl.Text = "label3";
            // 
            // formHeightLbl
            // 
            this.formHeightLbl.AutoSize = true;
            this.formHeightLbl.Location = new System.Drawing.Point(309, 27);
            this.formHeightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formHeightLbl.Name = "formHeightLbl";
            this.formHeightLbl.Size = new System.Drawing.Size(46, 17);
            this.formHeightLbl.TabIndex = 16;
            this.formHeightLbl.Text = "label4";
            // 
            // panelHome
            // 
            this.panelHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHome.Controls.Add(this.label4);
            this.panelHome.Location = new System.Drawing.Point(181, 84);
            this.panelHome.Margin = new System.Windows.Forms.Padding(4);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(866, 492);
            this.panelHome.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "panelHome";
            // 
            // panelOperation
            // 
            this.panelOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOperation.Controls.Add(this.label3);
            this.panelOperation.Location = new System.Drawing.Point(1369, 84);
            this.panelOperation.Margin = new System.Windows.Forms.Padding(4);
            this.panelOperation.Name = "panelOperation";
            this.panelOperation.Size = new System.Drawing.Size(866, 492);
            this.panelOperation.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "panelOperation";
            // 
            // panelInventory
            // 
            this.panelInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInventory.Controls.Add(this.label11);
            this.panelInventory.Location = new System.Drawing.Point(996, 613);
            this.panelInventory.Margin = new System.Windows.Forms.Padding(4);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Size = new System.Drawing.Size(866, 492);
            this.panelInventory.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "panelInventory";
            // 
            // panelCommon
            // 
            this.panelCommon.Controls.Add(this.lblUpdateField);
            this.panelCommon.Controls.Add(this.cbUpdateField);
            this.panelCommon.Controls.Add(this.btnUpdateField);
            this.panelCommon.Controls.Add(this.btnEditItem);
            this.panelCommon.Controls.Add(this.tbId);
            this.panelCommon.Controls.Add(this.lblId);
            this.panelCommon.Controls.Add(this.cbFilter4);
            this.panelCommon.Controls.Add(this.cbFilter3);
            this.panelCommon.Controls.Add(this.cbFilter2);
            this.panelCommon.Controls.Add(this.cbFilter1);
            this.panelCommon.Controls.Add(this.lblSearch);
            this.panelCommon.Controls.Add(this.btnReset);
            this.panelCommon.Controls.Add(this.btnNewItem);
            this.panelCommon.Controls.Add(this.dgvDbTable);
            this.panelCommon.Controls.Add(this.lblPanelTitle);
            this.panelCommon.Location = new System.Drawing.Point(173, 74);
            this.panelCommon.Margin = new System.Windows.Forms.Padding(4);
            this.panelCommon.Name = "panelCommon";
            this.panelCommon.Size = new System.Drawing.Size(867, 492);
            this.panelCommon.TabIndex = 21;
            // 
            // lblUpdateField
            // 
            this.lblUpdateField.AutoSize = true;
            this.lblUpdateField.Location = new System.Drawing.Point(232, 443);
            this.lblUpdateField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateField.Name = "lblUpdateField";
            this.lblUpdateField.Size = new System.Drawing.Size(98, 17);
            this.lblUpdateField.TabIndex = 14;
            this.lblUpdateField.Text = "lblUpdateField";
            // 
            // cbUpdateField
            // 
            this.cbUpdateField.FormattingEnabled = true;
            this.cbUpdateField.Location = new System.Drawing.Point(332, 438);
            this.cbUpdateField.Margin = new System.Windows.Forms.Padding(4);
            this.cbUpdateField.Name = "cbUpdateField";
            this.cbUpdateField.Size = new System.Drawing.Size(160, 24);
            this.cbUpdateField.TabIndex = 13;
            // 
            // btnUpdateField
            // 
            this.btnUpdateField.Location = new System.Drawing.Point(501, 436);
            this.btnUpdateField.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateField.Name = "btnUpdateField";
            this.btnUpdateField.Size = new System.Drawing.Size(139, 28);
            this.btnUpdateField.TabIndex = 12;
            this.btnUpdateField.Text = "btnUpdateField";
            this.btnUpdateField.UseVisualStyleBackColor = true;
            this.btnUpdateField.Click += new System.EventHandler(this.btnUpdateField_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(700, 437);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(137, 28);
            this.btnEditItem.TabIndex = 11;
            this.btnEditItem.Text = "btnEditItem";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(69, 357);
            this.tbId.Location = new System.Drawing.Point(92, 439);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(35, 22);
            this.tbId.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(31, 443);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 17);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "lblId";
            // 
            // cbFilter4
            // 
            this.cbFilter4.FormattingEnabled = true;
            this.cbFilter4.Location = new System.Drawing.Point(700, 49);
            this.cbFilter4.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilter4.Name = "cbFilter4";
            this.cbFilter4.Size = new System.Drawing.Size(160, 24);
            this.cbFilter4.TabIndex = 8;
            // 
            // cbFilter3
            // 
            this.cbFilter3.FormattingEnabled = true;
            this.cbFilter3.Location = new System.Drawing.Point(517, 49);
            this.cbFilter3.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilter3.Name = "cbFilter3";
            this.cbFilter3.Size = new System.Drawing.Size(160, 24);
            this.cbFilter3.TabIndex = 7;
            // 
            // cbFilter2
            // 
            this.cbFilter2.FormattingEnabled = true;
            this.cbFilter2.Location = new System.Drawing.Point(321, 49);
            this.cbFilter2.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilter2.Name = "cbFilter2";
            this.cbFilter2.Size = new System.Drawing.Size(160, 24);
            this.cbFilter2.TabIndex = 6;
            // 
            // cbFilter1
            // 
            this.cbFilter1.FormattingEnabled = true;
            this.cbFilter1.Location = new System.Drawing.Point(127, 49);
            this.cbFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilter1.Name = "cbFilter1";
            this.cbFilter1.Size = new System.Drawing.Size(160, 24);
            this.cbFilter1.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(27, 49);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 17);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search :";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(660, 10);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNewItem
            // 
            this.btnNewItem.Location = new System.Drawing.Point(140, 10);
            this.btnNewItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(148, 28);
            this.btnNewItem.TabIndex = 2;
            this.btnNewItem.Text = "btnNewItem";
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // dgvDbTable
            // 
            this.dgvDbTable.AllowUserToAddRows = false;
            this.dgvDbTable.AllowUserToDeleteRows = false;
            this.dgvDbTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDbTable.Location = new System.Drawing.Point(27, 98);
            this.dgvDbTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDbTable.Name = "dgvDbTable";
            this.dgvDbTable.ReadOnly = true;
            this.dgvDbTable.Size = new System.Drawing.Size(813, 308);
            this.dgvDbTable.TabIndex = 1;
            this.dgvDbTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDbTable_CellClick);
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.AutoSize = true;
            this.lblPanelTitle.Location = new System.Drawing.Point(27, 12);
            this.lblPanelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPanelTitle.Name = "lblPanelTitle";
            this.lblPanelTitle.Size = new System.Drawing.Size(85, 17);
            this.lblPanelTitle.TabIndex = 0;
            this.lblPanelTitle.Text = "lblPanelTitle";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.panelCommon);
            this.Controls.Add(this.panelInventory);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelOperation);
            this.Controls.Add(this.formHeightLbl);
            this.Controls.Add(this.formWidthLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.menuFLP);
            this.Controls.Add(this.jrfLabel);
            this.Controls.Add(this.logoutBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelOperation.ResumeLayout(false);
            this.panelOperation.PerformLayout();
            this.panelInventory.ResumeLayout(false);
            this.panelInventory.PerformLayout();
            this.panelCommon.ResumeLayout(false);
            this.panelCommon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDbTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label jrfLabel;
        private System.Windows.Forms.FlowLayoutPanel menuFLP;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label formWidthLbl;
        private System.Windows.Forms.Label formHeightLbl;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelOperation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelInventory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelCommon;
        private System.Windows.Forms.Label lblUpdateField;
        private System.Windows.Forms.ComboBox cbUpdateField;
        private System.Windows.Forms.Button btnUpdateField;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbFilter4;
        private System.Windows.Forms.ComboBox cbFilter3;
        private System.Windows.Forms.ComboBox cbFilter2;
        private System.Windows.Forms.ComboBox cbFilter1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.DataGridView dgvDbTable;
        private System.Windows.Forms.Label lblPanelTitle;
    }
}