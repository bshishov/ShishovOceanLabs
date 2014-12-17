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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AuthorCaptionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.SourceCaptionLabel = new System.Windows.Forms.Label();
            this.ParamValueLayoutGrid = new System.Windows.Forms.TableLayoutPanel();
            this.ParamNameCaption = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueDropTarget = new Slb.Ocean.Petrel.UI.DropTarget();
            this.GridGrid = new System.Windows.Forms.TableLayoutPanel();
            this.GridCaptionLabel = new System.Windows.Forms.Label();
            this.GridValue = new System.Windows.Forms.TextBox();
            this.GridDropTarget = new Slb.Ocean.Petrel.UI.DropTarget();
            this.ResultsCaptionLabel = new System.Windows.Forms.Label();
            this.NumCellsGrid = new System.Windows.Forms.TableLayoutPanel();
            this.NumCellsValue = new System.Windows.Forms.Label();
            this.NumCellsCaption = new System.Windows.Forms.Label();
            this.CreatedPropertyGrid = new System.Windows.Forms.TableLayoutPanel();
            this.CreatedPropertyCaptionLabel = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.CreatedPropertyValue = new System.Windows.Forms.TextBox();
            this.mainLayoutGrid.SuspendLayout();
            this.ParamValueLayoutGrid.SuspendLayout();
            this.GridGrid.SuspendLayout();
            this.NumCellsGrid.SuspendLayout();
            this.CreatedPropertyGrid.SuspendLayout();
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
            this.mainLayoutGrid.Controls.Add(this.ParamValueLayoutGrid, 0, 7);
            this.mainLayoutGrid.Controls.Add(this.GridGrid, 0, 8);
            this.mainLayoutGrid.Controls.Add(this.ResultsCaptionLabel, 0, 9);
            this.mainLayoutGrid.Controls.Add(this.NumCellsGrid, 0, 10);
            this.mainLayoutGrid.Controls.Add(this.CreatedPropertyGrid, 0, 11);
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
            // ParamValueLayoutGrid
            // 
            this.ParamValueLayoutGrid.AutoSize = true;
            this.ParamValueLayoutGrid.ColumnCount = 3;
            this.ParamValueLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.ParamValueLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ParamValueLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ParamValueLayoutGrid.Controls.Add(this.ParamNameCaption, 0, 0);
            this.ParamValueLayoutGrid.Controls.Add(this.ValueTextBox, 2, 0);
            this.ParamValueLayoutGrid.Controls.Add(this.ValueDropTarget, 1, 0);
            this.ParamValueLayoutGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamValueLayoutGrid.Location = new System.Drawing.Point(0, 104);
            this.ParamValueLayoutGrid.Margin = new System.Windows.Forms.Padding(0);
            this.ParamValueLayoutGrid.Name = "ParamValueLayoutGrid";
            this.ParamValueLayoutGrid.RowCount = 1;
            this.ParamValueLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ParamValueLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.ParamValueLayoutGrid.Size = new System.Drawing.Size(491, 23);
            this.ParamValueLayoutGrid.TabIndex = 8;
            // 
            // ParamNameCaption
            // 
            this.ParamNameCaption.AutoSize = true;
            this.ParamNameCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamNameCaption.Location = new System.Drawing.Point(3, 0);
            this.ParamNameCaption.Name = "ParamNameCaption";
            this.ParamNameCaption.Size = new System.Drawing.Size(114, 23);
            this.ParamNameCaption.TabIndex = 3;
            this.ParamNameCaption.Text = "Каротажная кривая:";
            this.ParamNameCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueTextBox.Location = new System.Drawing.Point(150, 2);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(341, 20);
            this.ValueTextBox.TabIndex = 4;
            // 
            // ValueDropTarget
            // 
            this.ValueDropTarget.AllowDrop = true;
            this.ValueDropTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueDropTarget.Location = new System.Drawing.Point(120, 0);
            this.ValueDropTarget.Margin = new System.Windows.Forms.Padding(0);
            this.ValueDropTarget.Name = "ValueDropTarget";
            this.ValueDropTarget.Size = new System.Drawing.Size(30, 23);
            this.ValueDropTarget.TabIndex = 5;
            // 
            // GridGrid
            // 
            this.GridGrid.AutoSize = true;
            this.GridGrid.ColumnCount = 3;
            this.GridGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.GridGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GridGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GridGrid.Controls.Add(this.GridCaptionLabel, 0, 0);
            this.GridGrid.Controls.Add(this.GridValue, 2, 0);
            this.GridGrid.Controls.Add(this.GridDropTarget, 1, 0);
            this.GridGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridGrid.Location = new System.Drawing.Point(0, 127);
            this.GridGrid.Margin = new System.Windows.Forms.Padding(0);
            this.GridGrid.Name = "GridGrid";
            this.GridGrid.RowCount = 1;
            this.GridGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GridGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.GridGrid.Size = new System.Drawing.Size(491, 23);
            this.GridGrid.TabIndex = 10;
            // 
            // GridCaptionLabel
            // 
            this.GridCaptionLabel.AutoSize = true;
            this.GridCaptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCaptionLabel.Location = new System.Drawing.Point(3, 0);
            this.GridCaptionLabel.Name = "GridCaptionLabel";
            this.GridCaptionLabel.Size = new System.Drawing.Size(114, 23);
            this.GridCaptionLabel.TabIndex = 3;
            this.GridCaptionLabel.Text = "Каротажная кривая:";
            this.GridCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GridValue
            // 
            this.GridValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridValue.Location = new System.Drawing.Point(150, 2);
            this.GridValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.GridValue.Name = "GridValue";
            this.GridValue.Size = new System.Drawing.Size(341, 20);
            this.GridValue.TabIndex = 4;
            // 
            // GridDropTarget
            // 
            this.GridDropTarget.AllowDrop = true;
            this.GridDropTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDropTarget.Location = new System.Drawing.Point(120, 0);
            this.GridDropTarget.Margin = new System.Windows.Forms.Padding(0);
            this.GridDropTarget.Name = "GridDropTarget";
            this.GridDropTarget.Size = new System.Drawing.Size(30, 23);
            this.GridDropTarget.TabIndex = 5;
            // 
            // ResultsCaptionLabel
            // 
            this.ResultsCaptionLabel.AutoSize = true;
            this.ResultsCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultsCaptionLabel.Location = new System.Drawing.Point(3, 150);
            this.ResultsCaptionLabel.Name = "ResultsCaptionLabel";
            this.ResultsCaptionLabel.Size = new System.Drawing.Size(128, 13);
            this.ResultsCaptionLabel.TabIndex = 6;
            this.ResultsCaptionLabel.Text = "Результаты расчета";
            // 
            // NumCellsGrid
            // 
            this.NumCellsGrid.AutoSize = true;
            this.NumCellsGrid.ColumnCount = 2;
            this.NumCellsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.NumCellsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NumCellsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NumCellsGrid.Controls.Add(this.NumCellsValue, 0, 0);
            this.NumCellsGrid.Controls.Add(this.NumCellsCaption, 0, 0);
            this.NumCellsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumCellsGrid.Location = new System.Drawing.Point(0, 163);
            this.NumCellsGrid.Margin = new System.Windows.Forms.Padding(0);
            this.NumCellsGrid.Name = "NumCellsGrid";
            this.NumCellsGrid.RowCount = 1;
            this.NumCellsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NumCellsGrid.Size = new System.Drawing.Size(491, 13);
            this.NumCellsGrid.TabIndex = 11;
            // 
            // NumCellsValue
            // 
            this.NumCellsValue.AutoSize = true;
            this.NumCellsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumCellsValue.Location = new System.Drawing.Point(123, 0);
            this.NumCellsValue.Name = "NumCellsValue";
            this.NumCellsValue.Size = new System.Drawing.Size(365, 13);
            this.NumCellsValue.TabIndex = 4;
            this.NumCellsValue.Text = "<количество ячеек>";
            this.NumCellsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumCellsCaption
            // 
            this.NumCellsCaption.AutoSize = true;
            this.NumCellsCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumCellsCaption.Location = new System.Drawing.Point(3, 0);
            this.NumCellsCaption.Name = "NumCellsCaption";
            this.NumCellsCaption.Size = new System.Drawing.Size(114, 13);
            this.NumCellsCaption.TabIndex = 3;
            this.NumCellsCaption.Text = "Количество ячеек:";
            this.NumCellsCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreatedPropertyGrid
            // 
            this.CreatedPropertyGrid.AutoSize = true;
            this.CreatedPropertyGrid.ColumnCount = 3;
            this.CreatedPropertyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.CreatedPropertyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CreatedPropertyGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CreatedPropertyGrid.Controls.Add(this.CreatedPropertyCaptionLabel, 0, 0);
            this.CreatedPropertyGrid.Controls.Add(this.ShowButton, 2, 0);
            this.CreatedPropertyGrid.Controls.Add(this.CreatedPropertyValue, 1, 0);
            this.CreatedPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatedPropertyGrid.Location = new System.Drawing.Point(0, 176);
            this.CreatedPropertyGrid.Margin = new System.Windows.Forms.Padding(0);
            this.CreatedPropertyGrid.Name = "CreatedPropertyGrid";
            this.CreatedPropertyGrid.RowCount = 1;
            this.CreatedPropertyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CreatedPropertyGrid.Size = new System.Drawing.Size(491, 26);
            this.CreatedPropertyGrid.TabIndex = 12;
            // 
            // CreatedPropertyCaptionLabel
            // 
            this.CreatedPropertyCaptionLabel.AutoSize = true;
            this.CreatedPropertyCaptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatedPropertyCaptionLabel.Location = new System.Drawing.Point(3, 0);
            this.CreatedPropertyCaptionLabel.Name = "CreatedPropertyCaptionLabel";
            this.CreatedPropertyCaptionLabel.Size = new System.Drawing.Size(114, 26);
            this.CreatedPropertyCaptionLabel.TabIndex = 3;
            this.CreatedPropertyCaptionLabel.Text = "Созданное свойство:";
            this.CreatedPropertyCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowButton
            // 
            this.ShowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowButton.Location = new System.Drawing.Point(391, 0);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(0);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(100, 26);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Показать";
            this.ShowButton.UseVisualStyleBackColor = true;
            // 
            // CreatedPropertyValue
            // 
            this.CreatedPropertyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatedPropertyValue.Location = new System.Drawing.Point(120, 2);
            this.CreatedPropertyValue.Margin = new System.Windows.Forms.Padding(0, 2, 3, 0);
            this.CreatedPropertyValue.Name = "CreatedPropertyValue";
            this.CreatedPropertyValue.Size = new System.Drawing.Size(268, 20);
            this.CreatedPropertyValue.TabIndex = 5;
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
            this.GridGrid.ResumeLayout(false);
            this.GridGrid.PerformLayout();
            this.NumCellsGrid.ResumeLayout(false);
            this.NumCellsGrid.PerformLayout();
            this.CreatedPropertyGrid.ResumeLayout(false);
            this.CreatedPropertyGrid.PerformLayout();
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
        private System.Windows.Forms.Label ParamNameCaption;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label AuthorLabel;
        private Slb.Ocean.Petrel.UI.DropTarget ValueDropTarget;
        private System.Windows.Forms.TableLayoutPanel GridGrid;
        private System.Windows.Forms.Label GridCaptionLabel;
        private System.Windows.Forms.TextBox GridValue;
        private Slb.Ocean.Petrel.UI.DropTarget GridDropTarget;
        private System.Windows.Forms.TableLayoutPanel NumCellsGrid;
        private System.Windows.Forms.Label NumCellsCaption;
        private System.Windows.Forms.TableLayoutPanel CreatedPropertyGrid;
        private System.Windows.Forms.Label CreatedPropertyCaptionLabel;
        private System.Windows.Forms.Label NumCellsValue;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.TextBox CreatedPropertyValue;






    }
}
