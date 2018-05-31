namespace Ex_2
{
    partial class FormLinkedList
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
            this.Open = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(18, 16);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(99, 16);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 1;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(18, 59);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(286, 239);
            this.textBoxIn.TabIndex = 2;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(322, 59);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(160, 239);
            this.textBoxOut.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FormLinkedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 325);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Open);
            this.Name = "FormLinkedList";
            this.Text = "FormLinkedList";
            this.Load += new System.EventHandler(this.FormLinkedList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

