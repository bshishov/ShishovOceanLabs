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
            this.WellLogLayoutGrid = new System.Windows.Forms.TableLayoutPanel();
            this.WellLogNameCaption = new System.Windows.Forms.Label();
            this.WellLogValue = new Slb.Ocean.Petrel.UI.Controls.PresentationBox();
            this.WellLogDropTarget = new Slb.Ocean.Petrel.UI.DropTarget();
            this.GridGrid = new System.Windows.Forms.TableLayoutPanel();
            this.GridCaptionLabel = new System.Windows.Forms.Label();
            this.GridValue = new Slb.Ocean.Petrel.UI.Controls.PresentationBox();
            this.GridDropTarget = new Slb.Ocean.Petrel.UI.DropTarget();
            this.ResultsCaptionLabel = new System.Windows.Forms.Label();
            this.NumCellsGrid = new System.Windows.Forms.TableLayoutPanel();
            this.NumCellsValue = new System.Windows.Forms.Label();
            this.NumCellsCaption = new System.Windows.Forms.Label();
            this.CreatedPropertyGrid = new System.Windows.Forms.TableLayoutPanel();
            this.CreatedPropertyCaptionLabel = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.CreatedPropertyValue = new Slb.Ocean.Petrel.UI.Controls.PresentationBox();
            this.DialogButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.mainLayoutGrid.SuspendLayout();
            this.WellLogLayoutGrid.SuspendLayout();
            this.GridGrid.SuspendLayout();
            this.NumCellsGrid.SuspendLayout();
            this.CreatedPropertyGrid.SuspendLayout();
            this.DialogButtonsLayout.SuspendLayout();
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
            this.mainLayoutGrid.Controls.Add(this.WellLogLayoutGrid, 0, 7);
            this.mainLayoutGrid.Controls.Add(this.GridGrid, 0, 8);
            this.mainLayoutGrid.Controls.Add(this.ResultsCaptionLabel, 0, 9);
            this.mainLayoutGrid.Controls.Add(this.NumCellsGrid, 0, 10);
            this.mainLayoutGrid.Controls.Add(this.CreatedPropertyGrid, 0, 11);
            this.mainLayoutGrid.Controls.Add(this.DialogButtonsLayout, 0, 13);
            this.mainLayoutGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutGrid.Location = new System.Drawing.Point(5, 5);
            this.mainLayoutGrid.Name = "mainLayoutGrid";
            this.mainLayoutGrid.RowCount = 14;
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
            this.mainLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutGrid.Size = new System.Drawing.Size(432, 373);
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
            this.NameLabel.Location = new System.Drawing.Point(3, 18);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(426, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "<Краткое описание рабочего шага>";
            // 
            // DescriptionCaptionLabel
            // 
            this.DescriptionCaptionLabel.AutoSize = true;
            this.DescriptionCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionCaptionLabel.Location = new System.Drawing.Point(3, 41);
            this.DescriptionCaptionLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DescriptionCaptionLabel.Name = "DescriptionCaptionLabel";
            this.DescriptionCaptionLabel.Size = new System.Drawing.Size(65, 13);
            this.DescriptionCaptionLabel.TabIndex = 3;
            this.DescriptionCaptionLabel.Text = "Описание";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 59);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(426, 26);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "< Полное описание рабочего шага < Полное описание рабочего шага >< Полное описани" +
    "е рабочего шага >< Полное описание рабочего шага > ";
            // 
            // AuthorCaptionLabel
            // 
            this.AuthorCaptionLabel.AutoSize = true;
            this.AuthorCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorCaptionLabel.Location = new System.Drawing.Point(3, 95);
            this.AuthorCaptionLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.AuthorCaptionLabel.Name = "AuthorCaptionLabel";
            this.AuthorCaptionLabel.Size = new System.Drawing.Size(42, 13);
            this.AuthorCaptionLabel.TabIndex = 4;
            this.AuthorCaptionLabel.Text = "Автор";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorLabel.Location = new System.Drawing.Point(3, 113);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(426, 13);
            this.AuthorLabel.TabIndex = 9;
            this.AuthorLabel.Text = "Шишов Борис АС-10-4";
            // 
            // SourceCaptionLabel
            // 
            this.SourceCaptionLabel.AutoSize = true;
            this.SourceCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceCaptionLabel.Location = new System.Drawing.Point(3, 136);
            this.SourceCaptionLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.SourceCaptionLabel.Name = "SourceCaptionLabel";
            this.SourceCaptionLabel.Size = new System.Drawing.Size(114, 13);
            this.SourceCaptionLabel.TabIndex = 5;
            this.SourceCaptionLabel.Text = "Исходные данные";
            // 
            // WellLogLayoutGrid
            // 
            this.WellLogLayoutGrid.AutoSize = true;
            this.WellLogLayoutGrid.ColumnCount = 3;
            this.WellLogLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.WellLogLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.WellLogLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WellLogLayoutGrid.Controls.Add(this.WellLogNameCaption, 0, 0);
            this.WellLogLayoutGrid.Controls.Add(this.WellLogValue, 2, 0);
            this.WellLogLayoutGrid.Controls.Add(this.WellLogDropTarget, 1, 0);
            this.WellLogLayoutGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WellLogLayoutGrid.Location = new System.Drawing.Point(0, 154);
            this.WellLogLayoutGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.WellLogLayoutGrid.Name = "WellLogLayoutGrid";
            this.WellLogLayoutGrid.RowCount = 1;
            this.WellLogLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WellLogLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.WellLogLayoutGrid.Size = new System.Drawing.Size(432, 23);
            this.WellLogLayoutGrid.TabIndex = 8;
            // 
            // WellLogNameCaption
            // 
            this.WellLogNameCaption.AutoSize = true;
            this.WellLogNameCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WellLogNameCaption.Location = new System.Drawing.Point(3, 0);
            this.WellLogNameCaption.Name = "WellLogNameCaption";
            this.WellLogNameCaption.Size = new System.Drawing.Size(114, 23);
            this.WellLogNameCaption.TabIndex = 3;
            this.WellLogNameCaption.Text = "Каротажная кривая:";
            this.WellLogNameCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WellLogValue
            // 
            this.WellLogValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WellLogValue.Location = new System.Drawing.Point(150, 1);
            this.WellLogValue.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.WellLogValue.Name = "WellLogValue";
            this.WellLogValue.Size = new System.Drawing.Size(282, 22);
            this.WellLogValue.TabIndex = 4;
            // 
            // WellLogDropTarget
            // 
            this.WellLogDropTarget.AllowDrop = true;
            this.WellLogDropTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WellLogDropTarget.Location = new System.Drawing.Point(120, 0);
            this.WellLogDropTarget.Margin = new System.Windows.Forms.Padding(0);
            this.WellLogDropTarget.Name = "WellLogDropTarget";
            this.WellLogDropTarget.Size = new System.Drawing.Size(30, 23);
            this.WellLogDropTarget.TabIndex = 5;
            this.WellLogDropTarget.DragDrop += new System.Windows.Forms.DragEventHandler(this.WellLog_DragDrop);
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
            this.GridGrid.Location = new System.Drawing.Point(0, 182);
            this.GridGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.GridGrid.Name = "GridGrid";
            this.GridGrid.RowCount = 1;
            this.GridGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GridGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.GridGrid.Size = new System.Drawing.Size(432, 23);
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
            this.GridCaptionLabel.Text = "3D-сетка:";
            this.GridCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GridValue
            // 
            this.GridValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridValue.Location = new System.Drawing.Point(150, 1);
            this.GridValue.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.GridValue.Name = "GridValue";
            this.GridValue.Size = new System.Drawing.Size(282, 22);
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
            this.GridDropTarget.DragDrop += new System.Windows.Forms.DragEventHandler(this.ValueDropTarget_DragDrop);
            // 
            // ResultsCaptionLabel
            // 
            this.ResultsCaptionLabel.AutoSize = true;
            this.ResultsCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultsCaptionLabel.Location = new System.Drawing.Point(3, 215);
            this.ResultsCaptionLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
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
            this.NumCellsGrid.Location = new System.Drawing.Point(0, 233);
            this.NumCellsGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.NumCellsGrid.Name = "NumCellsGrid";
            this.NumCellsGrid.RowCount = 1;
            this.NumCellsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NumCellsGrid.Size = new System.Drawing.Size(432, 13);
            this.NumCellsGrid.TabIndex = 11;
            // 
            // NumCellsValue
            // 
            this.NumCellsValue.AutoSize = true;
            this.NumCellsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumCellsValue.Location = new System.Drawing.Point(123, 0);
            this.NumCellsValue.Name = "NumCellsValue";
            this.NumCellsValue.Size = new System.Drawing.Size(306, 13);
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
            this.CreatedPropertyGrid.Location = new System.Drawing.Point(0, 251);
            this.CreatedPropertyGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.CreatedPropertyGrid.Name = "CreatedPropertyGrid";
            this.CreatedPropertyGrid.RowCount = 1;
            this.CreatedPropertyGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CreatedPropertyGrid.Size = new System.Drawing.Size(432, 26);
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
            this.ShowButton.Enabled = false;
            this.ShowButton.Location = new System.Drawing.Point(332, 0);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(0);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(100, 26);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Показать";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // CreatedPropertyValue
            // 
            this.CreatedPropertyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatedPropertyValue.Location = new System.Drawing.Point(120, 2);
            this.CreatedPropertyValue.Margin = new System.Windows.Forms.Padding(0, 2, 3, 0);
            this.CreatedPropertyValue.Name = "CreatedPropertyValue";
            this.CreatedPropertyValue.Size = new System.Drawing.Size(209, 22);
            this.CreatedPropertyValue.TabIndex = 5;
            // 
            // DialogButtonsLayout
            // 
            this.DialogButtonsLayout.AutoSize = true;
            this.DialogButtonsLayout.ColumnCount = 4;
            this.DialogButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DialogButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.DialogButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.DialogButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.DialogButtonsLayout.Controls.Add(this.ApplyButton, 1, 0);
            this.DialogButtonsLayout.Controls.Add(this.OkButton, 2, 0);
            this.DialogButtonsLayout.Controls.Add(this.CancelButton, 3, 0);
            this.DialogButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DialogButtonsLayout.Location = new System.Drawing.Point(0, 343);
            this.DialogButtonsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.DialogButtonsLayout.Name = "DialogButtonsLayout";
            this.DialogButtonsLayout.RowCount = 1;
            this.DialogButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DialogButtonsLayout.Size = new System.Drawing.Size(432, 30);
            this.DialogButtonsLayout.TabIndex = 13;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyButton.Location = new System.Drawing.Point(132, 0);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(97, 30);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Применить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OkButton.Location = new System.Drawing.Point(235, 0);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 30);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButton.Location = new System.Drawing.Point(335, 0);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(97, 30);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // WorkstepUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutGrid);
            this.MinimumSize = new System.Drawing.Size(430, 340);
            this.Name = "WorkstepUI";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(442, 383);
            this.Load += new System.EventHandler(this.WorkstepUI_Load);
            this.mainLayoutGrid.ResumeLayout(false);
            this.mainLayoutGrid.PerformLayout();
            this.WellLogLayoutGrid.ResumeLayout(false);
            this.WellLogLayoutGrid.PerformLayout();
            this.GridGrid.ResumeLayout(false);
            this.GridGrid.PerformLayout();
            this.NumCellsGrid.ResumeLayout(false);
            this.NumCellsGrid.PerformLayout();
            this.CreatedPropertyGrid.ResumeLayout(false);
            this.CreatedPropertyGrid.PerformLayout();
            this.DialogButtonsLayout.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel WellLogLayoutGrid;
        private System.Windows.Forms.Label WellLogNameCaption;
        private Slb.Ocean.Petrel.UI.Controls.PresentationBox WellLogValue;
        private System.Windows.Forms.Label AuthorLabel;
        private Slb.Ocean.Petrel.UI.DropTarget WellLogDropTarget;
        private System.Windows.Forms.TableLayoutPanel GridGrid;
        private System.Windows.Forms.Label GridCaptionLabel;
        private Slb.Ocean.Petrel.UI.Controls.PresentationBox GridValue;
        private Slb.Ocean.Petrel.UI.DropTarget GridDropTarget;
        private System.Windows.Forms.TableLayoutPanel NumCellsGrid;
        private System.Windows.Forms.Label NumCellsCaption;
        private System.Windows.Forms.TableLayoutPanel CreatedPropertyGrid;
        private System.Windows.Forms.Label CreatedPropertyCaptionLabel;
        private System.Windows.Forms.Label NumCellsValue;
        private System.Windows.Forms.Button ShowButton;
        private Slb.Ocean.Petrel.UI.Controls.PresentationBox CreatedPropertyValue;
        private System.Windows.Forms.TableLayoutPanel DialogButtonsLayout;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;






    }
}
