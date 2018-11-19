namespace JustRipeFarm
{
    partial class LabourerDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sowingSectionBtn = new System.Windows.Forms.Button();
            this.harvestSectionBtn = new System.Windows.Forms.Button();
            this.storingSectionBtn = new System.Windows.Forms.Button();
            this.treatmentSectionBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(13, 13);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Basic Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Job Summary";
            // 
            // sowingSectionBtn
            // 
            this.sowingSectionBtn.Location = new System.Drawing.Point(61, 192);
            this.sowingSectionBtn.Name = "sowingSectionBtn";
            this.sowingSectionBtn.Size = new System.Drawing.Size(321, 73);
            this.sowingSectionBtn.TabIndex = 4;
            this.sowingSectionBtn.Text = "Sowing";
            this.sowingSectionBtn.UseVisualStyleBackColor = true;
            // 
            // harvestSectionBtn
            // 
            this.harvestSectionBtn.Location = new System.Drawing.Point(61, 271);
            this.harvestSectionBtn.Name = "harvestSectionBtn";
            this.harvestSectionBtn.Size = new System.Drawing.Size(190, 73);
            this.harvestSectionBtn.TabIndex = 5;
            this.harvestSectionBtn.Text = "Harvest";
            this.harvestSectionBtn.UseVisualStyleBackColor = true;
            // 
            // storingSectionBtn
            // 
            this.storingSectionBtn.Location = new System.Drawing.Point(478, 192);
            this.storingSectionBtn.Name = "storingSectionBtn";
            this.storingSectionBtn.Size = new System.Drawing.Size(190, 73);
            this.storingSectionBtn.TabIndex = 6;
            this.storingSectionBtn.Text = "Storing";
            this.storingSectionBtn.UseVisualStyleBackColor = true;
            // 
            // treatmentSectionBtn
            // 
            this.treatmentSectionBtn.Location = new System.Drawing.Point(478, 271);
            this.treatmentSectionBtn.Name = "treatmentSectionBtn";
            this.treatmentSectionBtn.Size = new System.Drawing.Size(190, 73);
            this.treatmentSectionBtn.TabIndex = 7;
            this.treatmentSectionBtn.Text = "Treatment";
            this.treatmentSectionBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "No. of Job today";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "no. of job pending";
            // 
            // LabourerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.treatmentSectionBtn);
            this.Controls.Add(this.storingSectionBtn);
            this.Controls.Add(this.harvestSectionBtn);
            this.Controls.Add(this.sowingSectionBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.Name = "LabourerDashboard";
            this.Text = "Labourer Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sowingSectionBtn;
        private System.Windows.Forms.Button harvestSectionBtn;
        private System.Windows.Forms.Button storingSectionBtn;
        private System.Windows.Forms.Button treatmentSectionBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}