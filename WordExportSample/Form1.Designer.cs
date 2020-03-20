namespace WordExportSample
{
    partial class FormWordExport
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
            this.LabelFullName = new System.Windows.Forms.Label();
            this.TextBoxFullName = new System.Windows.Forms.TextBox();
            this.LabelEndDate = new System.Windows.Forms.Label();
            this.LabelSignDate = new System.Windows.Forms.Label();
            this.TextBoxEndDate = new System.Windows.Forms.TextBox();
            this.TextBoxSignDate = new System.Windows.Forms.TextBox();
            this.ButtonGenerateContract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFullName
            // 
            this.LabelFullName.AutoSize = true;
            this.LabelFullName.Location = new System.Drawing.Point(105, 29);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(34, 13);
            this.LabelFullName.TabIndex = 0;
            this.LabelFullName.Text = "ФИО";
            // 
            // TextBoxFullName
            // 
            this.TextBoxFullName.Location = new System.Drawing.Point(150, 29);
            this.TextBoxFullName.Name = "TextBoxFullName";
            this.TextBoxFullName.Size = new System.Drawing.Size(209, 20);
            this.TextBoxFullName.TabIndex = 1;
            // 
            // LabelEndDate
            // 
            this.LabelEndDate.AutoSize = true;
            this.LabelEndDate.Location = new System.Drawing.Point(43, 73);
            this.LabelEndDate.Name = "LabelEndDate";
            this.LabelEndDate.Size = new System.Drawing.Size(101, 13);
            this.LabelEndDate.TabIndex = 2;
            this.LabelEndDate.Text = "Действительно до";
            // 
            // LabelSignDate
            // 
            this.LabelSignDate.AutoSize = true;
            this.LabelSignDate.Location = new System.Drawing.Point(43, 113);
            this.LabelSignDate.Name = "LabelSignDate";
            this.LabelSignDate.Size = new System.Drawing.Size(96, 13);
            this.LabelSignDate.TabIndex = 3;
            this.LabelSignDate.Text = "Дата подписания";
            // 
            // TextBoxEndDate
            // 
            this.TextBoxEndDate.Location = new System.Drawing.Point(150, 73);
            this.TextBoxEndDate.Name = "TextBoxEndDate";
            this.TextBoxEndDate.Size = new System.Drawing.Size(209, 20);
            this.TextBoxEndDate.TabIndex = 4;
            // 
            // TextBoxSignDate
            // 
            this.TextBoxSignDate.Location = new System.Drawing.Point(150, 113);
            this.TextBoxSignDate.Name = "TextBoxSignDate";
            this.TextBoxSignDate.Size = new System.Drawing.Size(209, 20);
            this.TextBoxSignDate.TabIndex = 5;
            // 
            // ButtonGenerateContract
            // 
            this.ButtonGenerateContract.Location = new System.Drawing.Point(221, 157);
            this.ButtonGenerateContract.Name = "ButtonGenerateContract";
            this.ButtonGenerateContract.Size = new System.Drawing.Size(138, 23);
            this.ButtonGenerateContract.TabIndex = 6;
            this.ButtonGenerateContract.Text = "Сформировать";
            this.ButtonGenerateContract.UseVisualStyleBackColor = true;
            this.ButtonGenerateContract.Click += new System.EventHandler(this.ButtonGenerateContract_Click);
            // 
            // FormWordExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 209);
            this.Controls.Add(this.ButtonGenerateContract);
            this.Controls.Add(this.TextBoxSignDate);
            this.Controls.Add(this.TextBoxEndDate);
            this.Controls.Add(this.LabelSignDate);
            this.Controls.Add(this.LabelEndDate);
            this.Controls.Add(this.TextBoxFullName);
            this.Controls.Add(this.LabelFullName);
            this.Name = "FormWordExport";
            this.Text = "Word Export Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFullName;
        private System.Windows.Forms.TextBox TextBoxFullName;
        private System.Windows.Forms.Label LabelEndDate;
        private System.Windows.Forms.Label LabelSignDate;
        private System.Windows.Forms.TextBox TextBoxEndDate;
        private System.Windows.Forms.TextBox TextBoxSignDate;
        private System.Windows.Forms.Button ButtonGenerateContract;
    }
}

