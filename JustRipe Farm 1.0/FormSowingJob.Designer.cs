namespace JustRipeFarm
{
    partial class FormSowingJob
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbCrop = new System.Windows.Forms.ComboBox();
            this.cbFarm = new System.Windows.Forms.ComboBox();
            this.nUDQty = new System.Windows.Forms.NumericUpDown();
            this.nUDArea = new System.Windows.Forms.NumericUpDown();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nUDQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDArea)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(198, 508);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(46, 508);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 28);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Crop : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Farm : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Used Area : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vehicle : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Employee : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 321);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Date Start: ";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(177, 46);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(132, 22);
            this.tbDescription.TabIndex = 16;
            // 
            // cbCrop
            // 
            this.cbCrop.FormattingEnabled = true;
            this.cbCrop.Location = new System.Drawing.Point(177, 80);
            this.cbCrop.Margin = new System.Windows.Forms.Padding(4);
            this.cbCrop.Name = "cbCrop";
            this.cbCrop.Size = new System.Drawing.Size(160, 24);
            this.cbCrop.TabIndex = 17;
            this.cbCrop.SelectedIndexChanged += new System.EventHandler(this.cbCrop_SelectedIndexChanged);
            // 
            // cbFarm
            // 
            this.cbFarm.FormattingEnabled = true;
            this.cbFarm.Location = new System.Drawing.Point(177, 149);
            this.cbFarm.Margin = new System.Windows.Forms.Padding(4);
            this.cbFarm.Name = "cbFarm";
            this.cbFarm.Size = new System.Drawing.Size(160, 24);
            this.cbFarm.TabIndex = 18;
            // 
            // nUDQty
            // 
            this.nUDQty.Location = new System.Drawing.Point(177, 119);
            this.nUDQty.Margin = new System.Windows.Forms.Padding(4);
            this.nUDQty.Name = "nUDQty";
            this.nUDQty.Size = new System.Drawing.Size(160, 22);
            this.nUDQty.TabIndex = 19;
            this.nUDQty.ValueChanged += new System.EventHandler(this.nUDQty_ValueChanged);
            // 
            // nUDArea
            // 
            this.nUDArea.Location = new System.Drawing.Point(177, 192);
            this.nUDArea.Margin = new System.Windows.Forms.Padding(4);
            this.nUDArea.Name = "nUDArea";
            this.nUDArea.Size = new System.Drawing.Size(160, 22);
            this.nUDArea.TabIndex = 20;
            // 
            // cbVehicle
            // 
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(177, 242);
            this.cbVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(160, 24);
            this.cbVehicle.TabIndex = 21;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(177, 277);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(160, 24);
            this.cbEmployee.TabIndex = 22;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(177, 321);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 408);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Date End: ";
            // 
            // dtpDate2
            // 
            this.dtpDate2.Location = new System.Drawing.Point(177, 408);
            this.dtpDate2.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate2.Name = "dtpDate2";
            this.dtpDate2.Size = new System.Drawing.Size(265, 22);
            this.dtpDate2.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 371);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Date End: ";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(177, 366);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(265, 22);
            this.dtpDateEnd.TabIndex = 27;
            // 
            // FormSowingJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 549);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.nUDArea);
            this.Controls.Add(this.nUDQty);
            this.Controls.Add(this.cbFarm);
            this.Controls.Add(this.cbCrop);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSowingJob";
            this.Text = "Sowing Job";
            this.Load += new System.EventHandler(this.FormSowingJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox cbCrop;
        private System.Windows.Forms.ComboBox cbFarm;
        private System.Windows.Forms.NumericUpDown nUDQty;
        private System.Windows.Forms.NumericUpDown nUDArea;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
    }
}