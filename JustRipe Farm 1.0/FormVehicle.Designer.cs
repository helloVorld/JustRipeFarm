namespace JustRipeFarm
{
    partial class FormVehicle
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.serialNumText = new System.Windows.Forms.TextBox();
            this.buyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.serviceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.remarkText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(231, 64);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 22);
            this.nameText.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Last Service Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Buy Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Serial Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(265, 289);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(101, 289);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 28);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // serialNumText
            // 
            this.serialNumText.Location = new System.Drawing.Point(231, 94);
            this.serialNumText.Name = "serialNumText";
            this.serialNumText.Size = new System.Drawing.Size(100, 22);
            this.serialNumText.TabIndex = 22;
            // 
            // buyDateTimePicker
            // 
            this.buyDateTimePicker.Location = new System.Drawing.Point(231, 127);
            this.buyDateTimePicker.Name = "buyDateTimePicker";
            this.buyDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.buyDateTimePicker.TabIndex = 23;
            this.buyDateTimePicker.ValueChanged += new System.EventHandler(this.buyDateTimePicker_ValueChanged);
            // 
            // serviceDateTimePicker
            // 
            this.serviceDateTimePicker.Location = new System.Drawing.Point(230, 162);
            this.serviceDateTimePicker.Name = "serviceDateTimePicker";
            this.serviceDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.serviceDateTimePicker.TabIndex = 24;
            this.serviceDateTimePicker.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Remark:";
            // 
            // remarkText
            // 
            this.remarkText.Location = new System.Drawing.Point(231, 197);
            this.remarkText.Name = "remarkText";
            this.remarkText.Size = new System.Drawing.Size(100, 22);
            this.remarkText.TabIndex = 26;
            // 
            // FormVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 427);
            this.Controls.Add(this.remarkText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.serviceDateTimePicker);
            this.Controls.Add(this.buyDateTimePicker);
            this.Controls.Add(this.serialNumText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Name = "FormVehicle";
            this.Text = "FormVehicle";
            this.Load += new System.EventHandler(this.FormVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox serialNumText;
        private System.Windows.Forms.DateTimePicker buyDateTimePicker;
        private System.Windows.Forms.DateTimePicker serviceDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox remarkText;
    }
}