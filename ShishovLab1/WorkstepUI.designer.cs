namespace ShishovLab1
{
    partial class WorkstepUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayoutGrid = new System.Windows.Forms.TableLayoutPanel();
            this.NameCaptionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.mainLayoutGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutGrid
            // 
            this.mainLayoutGrid.ColumnCount = 1;
            this.mainLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutGrid.Controls.Add(this.NameCaptionLabel, 0, 0);
            this.mainLayoutGrid.Controls.Add(this.NameLabel, 0, 1);
            this.mainLayoutGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutGrid.Location = new System.Drawing.Point(5, 5);
            this.mainLayoutGrid.Name = "mainLayoutGrid";
            this.mainLayoutGrid.RowCount = 4;
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutGrid.Size = new System.Drawing.Size(491, 396);
            this.mainLayoutGrid.TabIndex = 5;
            // 
            // NameCaptionLabel
            // 
            this.NameCaptionLabel.AutoSize = true;
            this.NameCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCaptionLabel.Location = new System.Drawing.Point(3, 0);
            this.NameCaptionLabel.Name = "NameCaptionLabel";
            this.NameCaptionLabel.Size = new System.Drawing.Size(65, 13);
            this.NameCaptionLabel.TabIndex = 0;
            this.NameCaptionLabel.Text = "Название";
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Location = new System.Drawing.Point(3, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(485, 19);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "<Краткое описание рабочего шага>";
            // 
            // WorkstepUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutGrid);
            this.Name = "WorkstepUI";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(501, 406);
            this.Load += new System.EventHandler(this.WorkstepUI_Load);
            this.mainLayoutGrid.ResumeLayout(false);
            this.mainLayoutGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutGrid;
        private System.Windows.Forms.Label NameCaptionLabel;
        private System.Windows.Forms.Label NameLabel;






    }
}
