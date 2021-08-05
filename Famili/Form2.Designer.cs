namespace Famili
{
    partial class Form2
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Country = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.maskedTextBox_Price = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Name.Location = new System.Drawing.Point(12, 59);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(412, 26);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_Country
            // 
            this.textBox_Country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Country.Location = new System.Drawing.Point(12, 135);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(412, 26);
            this.textBox_Country.TabIndex = 1;
            // 
            // label_Name
            // 
            this.label_Name.Location = new System.Drawing.Point(12, 25);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(117, 31);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Название товара";
            // 
            // label_Country
            // 
            this.label_Country.Location = new System.Drawing.Point(12, 101);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(152, 31);
            this.label_Country.TabIndex = 4;
            this.label_Country.Text = "Страна производитель";
            // 
            // label_Price
            // 
            this.label_Price.Location = new System.Drawing.Point(12, 176);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(44, 31);
            this.label_Price.TabIndex = 5;
            this.label_Price.Text = "Цена";
            // 
            // button_Ok
            // 
            this.button_Ok.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Ok.Location = new System.Drawing.Point(12, 347);
            this.button_Ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(197, 61);
            this.button_Ok.TabIndex = 6;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(227, 347);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(197, 61);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // maskedTextBox_Price
            // 
            this.maskedTextBox_Price.BeepOnError = true;
            this.maskedTextBox_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox_Price.Location = new System.Drawing.Point(12, 210);
            this.maskedTextBox_Price.Mask = "000000000000";
            this.maskedTextBox_Price.Name = "maskedTextBox_Price";
            this.maskedTextBox_Price.Size = new System.Drawing.Size(412, 26);
            this.maskedTextBox_Price.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 422);
            this.Controls.Add(this.maskedTextBox_Price);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Country);
            this.Controls.Add(this.textBox_Name);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Price;
    }
}