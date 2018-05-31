namespace Sort
{
    partial class FormSort
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
            this.BubbleSort = new System.Windows.Forms.Button();
            this.Rundom = new System.Windows.Forms.Button();
            this.QuickSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(93, 12);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(75, 23);
            this.BubbleSort.TabIndex = 0;
            this.BubbleSort.Text = "BubbleSort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // Rundom
            // 
            this.Rundom.Location = new System.Drawing.Point(12, 12);
            this.Rundom.Name = "Rundom";
            this.Rundom.Size = new System.Drawing.Size(75, 23);
            this.Rundom.TabIndex = 1;
            this.Rundom.Text = "Rundom";
            this.Rundom.UseVisualStyleBackColor = true;
            this.Rundom.Click += new System.EventHandler(this.Rundom_Click);
            // 
            // QuickSort
            // 
            this.QuickSort.Location = new System.Drawing.Point(174, 12);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(75, 23);
            this.QuickSort.TabIndex = 2;
            this.QuickSort.Text = "QuickSort";
            this.QuickSort.UseVisualStyleBackColor = true;
            this.QuickSort.Click += new System.EventHandler(this.QuickSort_Click);
            // 
            // FormSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 180);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.Rundom);
            this.Controls.Add(this.BubbleSort);
            this.Name = "FormSort";
            this.Text = "FormSort";
            this.Load += new System.EventHandler(this.FormSort_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSort_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Button Rundom;
        private System.Windows.Forms.Button QuickSort;
    }
}

