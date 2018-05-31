namespace Tree
{
    partial class FormTree
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
            this.button_Run = new System.Windows.Forms.Button();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.labelRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Run
            // 
            this.button_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Run.Location = new System.Drawing.Point(624, 62);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(83, 44);
            this.button_Run.TabIndex = 1;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(632, 151);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(75, 20);
            this.textBoxRes.TabIndex = 2;
            // 
            // buttonGen
            // 
            this.buttonGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGen.Location = new System.Drawing.Point(624, 12);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(83, 44);
            this.buttonGen.TabIndex = 3;
            this.buttonGen.Text = "Generate";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.Location = new System.Drawing.Point(653, 130);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(54, 18);
            this.labelRes.TabIndex = 4;
            this.labelRes.Text = "Result:";
            // 
            // FormTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 448);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.button_Run);
            this.Name = "FormTree";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTree_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormTree_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTree_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTree_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormTree_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Label labelRes;
    }
}

