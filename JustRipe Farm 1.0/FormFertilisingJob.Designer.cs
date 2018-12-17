namespace JustRipeFarm
{
    partial class FormFertilisingJob
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFertiliser = new System.Windows.Forms.ComboBox();
            this.cbSoj = new System.Windows.Forms.ComboBox();
            this.cbFarm = new System.Windows.Forms.ComboBox();
            this.cbCrop = new System.Windows.Forms.ComboBox();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(167, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 145;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 143;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(167, 299);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(230, 22);
            this.dtpStart.TabIndex = 142;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 139;
            this.label7.Text = "Date Start:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 138;
            this.label8.Text = "Employee id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 137;
            this.label9.Text = "Vehicle id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 136;
            this.label2.Text = "Crop id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 135;
            this.label5.Text = "Farm id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 134;
            this.label6.Text = "SowingJob id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 133;
            this.label4.Text = "Quantity kg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 132;
            this.label3.Text = "fertiliser id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 131;
            this.label1.Text = "Description:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 396);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 130;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(48, 396);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 28);
            this.btnDone.TabIndex = 129;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(167, 340);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(230, 22);
            this.dtpEnd.TabIndex = 152;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 151;
            this.label10.Text = "Date end:";
            // 
            // cbFertiliser
            // 
            this.cbFertiliser.FormattingEnabled = true;
            this.cbFertiliser.Location = new System.Drawing.Point(167, 46);
            this.cbFertiliser.Name = "cbFertiliser";
            this.cbFertiliser.Size = new System.Drawing.Size(121, 24);
            this.cbFertiliser.TabIndex = 153;
            // 
            // cbSoj
            // 
            this.cbSoj.FormattingEnabled = true;
            this.cbSoj.Location = new System.Drawing.Point(167, 116);
            this.cbSoj.Name = "cbSoj";
            this.cbSoj.Size = new System.Drawing.Size(121, 24);
            this.cbSoj.TabIndex = 154;
            // 
            // cbFarm
            // 
            this.cbFarm.FormattingEnabled = true;
            this.cbFarm.Location = new System.Drawing.Point(167, 155);
            this.cbFarm.Name = "cbFarm";
            this.cbFarm.Size = new System.Drawing.Size(121, 24);
            this.cbFarm.TabIndex = 155;
            // 
            // cbCrop
            // 
            this.cbCrop.FormattingEnabled = true;
            this.cbCrop.Location = new System.Drawing.Point(167, 189);
            this.cbCrop.Name = "cbCrop";
            this.cbCrop.Size = new System.Drawing.Size(121, 24);
            this.cbCrop.TabIndex = 156;
            // 
            // cbVehicle
            // 
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(167, 230);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(121, 24);
            this.cbVehicle.TabIndex = 157;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(167, 265);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(121, 24);
            this.cbEmployee.TabIndex = 158;
            // 
            // FormFertilisingJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.cbCrop);
            this.Controls.Add(this.cbFarm);
            this.Controls.Add(this.cbSoj);
            this.Controls.Add(this.cbFertiliser);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Name = "FormFertilisingJob";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormFertilisingJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbFertiliser;
        private System.Windows.Forms.ComboBox cbSoj;
        private System.Windows.Forms.ComboBox cbFarm;
        private System.Windows.Forms.ComboBox cbCrop;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.ComboBox cbEmployee;
    }
}