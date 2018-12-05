namespace JustRipeFarm
{
    partial class FormOrder
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
            this.palletAllocationText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.orderDatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.collectionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.remarkText = new System.Windows.Forms.TextBox();
            this.productIdText = new System.Windows.Forms.TextBox();
            this.quantityBoxText = new System.Windows.Forms.TextBox();
            this.weightText = new System.Windows.Forms.TextBox();
            this.customerIdText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(234, 468);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(73, 468);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 28);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // palletAllocationText
            // 
            this.palletAllocationText.Location = new System.Drawing.Point(193, 195);
            this.palletAllocationText.Name = "palletAllocationText";
            this.palletAllocationText.Size = new System.Drawing.Size(100, 22);
            this.palletAllocationText.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Pallet Allocation:";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(193, 62);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(100, 22);
            this.descriptionText.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Quantity_box:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Product_id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Customer_id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Order_date:";
            // 
            // orderDatedateTimePicker
            // 
            this.orderDatedateTimePicker.Location = new System.Drawing.Point(193, 271);
            this.orderDatedateTimePicker.Name = "orderDatedateTimePicker";
            this.orderDatedateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.orderDatedateTimePicker.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Collection:";
            // 
            // collectionDateTimePicker
            // 
            this.collectionDateTimePicker.Location = new System.Drawing.Point(193, 307);
            this.collectionDateTimePicker.Name = "collectionDateTimePicker";
            this.collectionDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.collectionDateTimePicker.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Price:";
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(193, 338);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(100, 22);
            this.priceText.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Status:";
            // 
            // statusText
            // 
            this.statusText.Location = new System.Drawing.Point(193, 371);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(100, 22);
            this.statusText.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "Remark:";
            // 
            // remarkText
            // 
            this.remarkText.Location = new System.Drawing.Point(193, 401);
            this.remarkText.Name = "remarkText";
            this.remarkText.Size = new System.Drawing.Size(100, 22);
            this.remarkText.TabIndex = 52;
            // 
            // productIdText
            // 
            this.productIdText.Location = new System.Drawing.Point(193, 92);
            this.productIdText.Name = "productIdText";
            this.productIdText.Size = new System.Drawing.Size(100, 22);
            this.productIdText.TabIndex = 53;
            // 
            // quantityBoxText
            // 
            this.quantityBoxText.Location = new System.Drawing.Point(193, 126);
            this.quantityBoxText.Name = "quantityBoxText";
            this.quantityBoxText.Size = new System.Drawing.Size(100, 22);
            this.quantityBoxText.TabIndex = 54;
            // 
            // weightText
            // 
            this.weightText.Location = new System.Drawing.Point(193, 157);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(100, 22);
            this.weightText.TabIndex = 55;
            // 
            // customerIdText
            // 
            this.customerIdText.Location = new System.Drawing.Point(193, 231);
            this.customerIdText.Name = "customerIdText";
            this.customerIdText.Size = new System.Drawing.Size(100, 22);
            this.customerIdText.TabIndex = 56;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 554);
            this.Controls.Add(this.customerIdText);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.quantityBoxText);
            this.Controls.Add(this.productIdText);
            this.Controls.Add(this.remarkText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.collectionDateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.orderDatedateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.palletAllocationText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox palletAllocationText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker orderDatedateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker collectionDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox remarkText;
        private System.Windows.Forms.TextBox productIdText;
        private System.Windows.Forms.TextBox quantityBoxText;
        private System.Windows.Forms.TextBox weightText;
        private System.Windows.Forms.TextBox customerIdText;
    }
}