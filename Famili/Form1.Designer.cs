namespace Famili
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(16, 326);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(571, 52);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Добавить товар";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Edit.Location = new System.Drawing.Point(16, 388);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(571, 52);
            this.button_Edit.TabIndex = 2;
            this.button_Edit.Text = "Редактировать товар";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.Location = new System.Drawing.Point(16, 449);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(571, 52);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Удалить товар";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clear.Location = new System.Drawing.Point(16, 511);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(571, 52);
            this.button_Clear.TabIndex = 4;
            this.button_Clear.Text = "Очистить список";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(16, 572);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(571, 52);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(16, 18);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(570, 242);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 654);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Add);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Католог товаров";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

