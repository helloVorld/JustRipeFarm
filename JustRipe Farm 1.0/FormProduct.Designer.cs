namespace JustRipeFarm
{
    partial class FormProduct
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
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.weightText = new System.Windows.Forms.TextBox();
            this.typeText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.remarkLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.boxIdText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(105, 309);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 28);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 309);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // weightText
            // 
            this.weightText.Location = new System.Drawing.Point(201, 215);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(170, 22);
            this.weightText.TabIndex = 19;
            // 
            // typeText
            // 
            this.typeText.Location = new System.Drawing.Point(201, 123);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(170, 22);
            this.typeText.TabIndex = 17;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(201, 80);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(170, 22);
            this.nameText.TabIndex = 16;
            // 
            // remarkLabel
            // 
            this.remarkLabel.AutoSize = true;
            this.remarkLabel.Location = new System.Drawing.Point(99, 215);
            this.remarkLabel.Name = "remarkLabel";
            this.remarkLabel.Size = new System.Drawing.Size(56, 17);
            this.remarkLabel.TabIndex = 15;
            this.remarkLabel.Text = "Weight:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(99, 169);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(95, 17);
            this.phoneLabel.TabIndex = 14;
            this.phoneLabel.Text = "Quantity_box:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(102, 126);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 17);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Type:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(102, 83);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 17);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name: ";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(201, 169);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(52, 22);
            this.quantityNumericUpDown.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Box_id:";
            // 
            // boxIdText
            // 
            this.boxIdText.Location = new System.Drawing.Point(201, 258);
            this.boxIdText.Name = "boxIdText";
            this.boxIdText.Size = new System.Drawing.Size(170, 22);
            this.boxIdText.TabIndex = 22;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 486);
            this.Controls.Add(this.boxIdText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.remarkLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProduct";
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox weightText;
        private System.Windows.Forms.TextBox typeText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label remarkLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxIdText;
    }
}