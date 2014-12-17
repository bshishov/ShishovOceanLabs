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
            this.DescriptionCaptionLabel = new System.Windows.Forms.Label();
            this.AuthorCaptionLabel = new System.Windows.Forms.Label();
            this.SourceCaptionLabel = new System.Windows.Forms.Label();
            this.ResultsCaptionLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ParamValueLayoutGrid = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.mainLayoutGrid.SuspendLayout();
            this.ParamValueLayoutGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutGrid
            // 
            this.mainLayoutGrid.ColumnCount = 1;
            this.mainLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutGrid.Controls.Add(this.NameCaptionLabel, 0, 0);
            this.mainLayoutGrid.Controls.Add(this.NameLabel, 0, 1);
            this.mainLayoutGrid.Controls.Add(this.DescriptionCaptionLabel, 0, 2);
            this.mainLayoutGrid.Controls.Add(this.DescriptionLabel, 0, 3);
            this.mainLayoutGrid.Controls.Add(this.AuthorCaptionLabel, 0, 4);
            this.mainLayoutGrid.Controls.Add(this.AuthorLabel, 0, 5);
            this.mainLayoutGrid.Controls.Add(this.SourceCaptionLabel, 0, 6);
            this.mainLayoutGrid.Controls.Add(this.ResultsCaptionLabel, 0, 9);
            this.mainLayoutGrid.Controls.Add(this.ParamValueLayoutGrid, 0, 7);
            this.mainLayoutGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutGrid.Location = new System.Drawing.Point(5, 5);
            this.mainLayoutGrid.Name = "mainLayoutGrid";
            this.mainLayoutGrid.RowCount = 13;
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
            this.NameLabel.AutoSize = true;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Location = new System.Drawing.Point(3, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(485, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "<Краткое описание рабочего шага>";
            // 
            // DescriptionCaptionLabel
            // 
            this.DescriptionCaptionLabel.AutoSize = true;
            this.DescriptionCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionCaptionLabel.Location = new System.Drawing.Point(3, 26);
            this.DescriptionCaptionLabel.Name = "DescriptionCaptionLabel";
            this.DescriptionCaptionLabel.Size = new System.Drawing.Size(65, 13);
            this.DescriptionCaptionLabel.TabIndex = 3;
            this.DescriptionCaptionLabel.Text = "Описание";
            // 
            // AuthorCaptionLabel
            // 
            this.AuthorCaptionLabel.AutoSize = true;
            this.AuthorCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorCaptionLabel.Location = new System.Drawing.Point(3, 65);
            this.AuthorCaptionLabel.Name = "AuthorCaptionLabel";
            this.AuthorCaptionLabel.Size = new System.Drawing.Size(42, 13);
            this.AuthorCaptionLabel.TabIndex = 4;
            this.AuthorCaptionLabel.Text = "Автор";
            // 
            // SourceCaptionLabel
            // 
            this.SourceCaptionLabel.AutoSize = true;
            this.SourceCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceCaptionLabel.Location = new System.Drawing.Point(3, 91);
            this.SourceCaptionLabel.Name = "SourceCaptionLabel";
            this.SourceCaptionLabel.Size = new System.Drawing.Size(114, 13);
            this.SourceCaptionLabel.TabIndex = 5;
            this.SourceCaptionLabel.Text = "Исходные данные";
            // 
            // ResultsCaptionLabel
            // 
            this.ResultsCaptionLabel.AutoSize = true;
            this.ResultsCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultsCaptionLabel.Location = new System.Drawing.Point(3, 130);
            this.ResultsCaptionLabel.Name = "ResultsCaptionLabel";
            this.ResultsCaptionLabel.Size = new System.Drawing.Size(77, 13);
            this.ResultsCaptionLabel.TabIndex = 6;
            this.ResultsCaptionLabel.Text = "Результаты";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 39);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(485, 26);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "< Полное описание рабочего шага < Полное описание рабочего шага >< Полное описани" +
    "е рабочего шага >< Полное описание рабочего шага > ";
            // 
            // ParamValueLayoutGrid
            // 
            this.ParamValueLayoutGrid.AutoSize = true;
            this.ParamValueLayoutGrid.ColumnCount = 3;
            this.ParamValueLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.ParamValueLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ParamValueLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ParamValueLayoutGrid.Controls.Add(this.label1, 0, 0);
            this.ParamValueLayoutGrid.Controls.Add(this.textBox1, 2, 0);
            this.ParamValueLayoutGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamValueLayoutGrid.Location = new System.Drawing.Point(0, 104);
            this.ParamValueLayoutGrid.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.ParamValueLayoutGrid.Name = "ParamValueLayoutGrid";
            this.ParamValueLayoutGrid.RowCount = 1;
            this.ParamValueLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ParamValueLayoutGrid.Size = new System.Drawing.Size(491, 26);
            this.ParamValueLayoutGrid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Каротажная кривая:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(153, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 20);
            this.textBox1.TabIndex = 4;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorLabel.Location = new System.Drawing.Point(3, 78);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(485, 13);
            this.AuthorLabel.TabIndex = 9;
            this.AuthorLabel.Text = "Шишов Борис АС-10-4";
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
            this.ParamValueLayoutGrid.ResumeLayout(false);
            this.ParamValueLayoutGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutGrid;
        private System.Windows.Forms.Label NameCaptionLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionCaptionLabel;
        private System.Windows.Forms.Label AuthorCaptionLabel;
        private System.Windows.Forms.Label SourceCaptionLabel;
        private System.Windows.Forms.Label ResultsCaptionLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TableLayoutPanel ParamValueLayoutGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AuthorLabel;






    }
}
