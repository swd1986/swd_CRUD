namespace CRUD
{
    partial class fmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnectToDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectToDB
            // 
            this.btnConnectToDB.Location = new System.Drawing.Point(12, 12);
            this.btnConnectToDB.Name = "btnConnectToDB";
            this.btnConnectToDB.Size = new System.Drawing.Size(164, 23);
            this.btnConnectToDB.TabIndex = 0;
            this.btnConnectToDB.Text = "Connect to DB";
            this.btnConnectToDB.UseVisualStyleBackColor = true;
            this.btnConnectToDB.Click += new System.EventHandler(this.btnConnectToDB_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 262);
            this.Controls.Add(this.btnConnectToDB);
            this.Name = "fmMain";
            this.Text = "C# CRUD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnectToDB;
    }
}

