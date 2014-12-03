namespace ShishovUITest
{
    partial class MainForm
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
            this.workstepUI1 = new ShishovLab1.WorkstepUI();
            this.SuspendLayout();
            // 
            // workstepUI1
            // 
            this.workstepUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workstepUI1.Location = new System.Drawing.Point(0, 0);
            this.workstepUI1.Name = "workstepUI1";
            this.workstepUI1.Size = new System.Drawing.Size(436, 397);
            this.workstepUI1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 397);
            this.Controls.Add(this.workstepUI1);
            this.Name = "MainForm";
            this.Text = "Примерный вид окна";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ShishovLab1.WorkstepUI workstepUI1;
    }
}

