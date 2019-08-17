namespace ConnectionSelectionForm
{
    partial class LaureatesViewerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrizesDataGridView = new System.Windows.Forms.DataGridView();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.NameValueTextBox = new System.Windows.Forms.TextBox();
            this.SurnameValueTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SetAddFiltersCheckBox = new System.Windows.Forms.CheckBox();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.NumberOfLaureatesTrackBar = new System.Windows.Forms.TrackBar();
            this.NumberOfLaureatesTextBox = new System.Windows.Forms.TextBox();
            this.NUmberOfLaureatesLabel = new System.Windows.Forms.Label();
            this.ResetFiltersLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrizesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLaureatesTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PrizesDataGridView
            // 
            this.PrizesDataGridView.AllowUserToAddRows = false;
            this.PrizesDataGridView.AllowUserToDeleteRows = false;
            this.PrizesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrizesDataGridView.Location = new System.Drawing.Point(492, 34);
            this.PrizesDataGridView.Name = "PrizesDataGridView";
            this.PrizesDataGridView.ReadOnly = true;
            this.PrizesDataGridView.Size = new System.Drawing.Size(660, 430);
            this.PrizesDataGridView.TabIndex = 0;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FilterLabel.Location = new System.Drawing.Point(129, 34);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(104, 37);
            this.FilterLabel.TabIndex = 1;
            this.FilterLabel.Text = "Filters";
            // 
            // NameValueTextBox
            // 
            this.NameValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameValueTextBox.Location = new System.Drawing.Point(208, 110);
            this.NameValueTextBox.Name = "NameValueTextBox";
            this.NameValueTextBox.Size = new System.Drawing.Size(183, 31);
            this.NameValueTextBox.TabIndex = 2;
            // 
            // SurnameValueTextBox
            // 
            this.SurnameValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameValueTextBox.Location = new System.Drawing.Point(208, 149);
            this.SurnameValueTextBox.Name = "SurnameValueTextBox";
            this.SurnameValueTextBox.Size = new System.Drawing.Size(183, 31);
            this.SurnameValueTextBox.TabIndex = 3;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SurnameLabel.Location = new System.Drawing.Point(13, 152);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(189, 25);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Laureate Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NameLabel.Location = new System.Drawing.Point(13, 113);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(159, 25);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Laureate Name";
            // 
            // SetAddFiltersCheckBox
            // 
            this.SetAddFiltersCheckBox.AutoSize = true;
            this.SetAddFiltersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAddFiltersCheckBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SetAddFiltersCheckBox.Location = new System.Drawing.Point(162, 200);
            this.SetAddFiltersCheckBox.Name = "SetAddFiltersCheckBox";
            this.SetAddFiltersCheckBox.Size = new System.Drawing.Size(229, 29);
            this.SetAddFiltersCheckBox.TabIndex = 6;
            this.SetAddFiltersCheckBox.Text = "Set Additional Filters";
            this.SetAddFiltersCheckBox.UseVisualStyleBackColor = true;
            this.SetAddFiltersCheckBox.CheckedChanged += new System.EventHandler(this.SetAddFiltersCheckBox_CheckedChanged);
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.AutoSize = true;
            this.FromDateLabel.Enabled = false;
            this.FromDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FromDateLabel.Location = new System.Drawing.Point(13, 289);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(113, 25);
            this.FromDateLabel.TabIndex = 9;
            this.FromDateLabel.Text = "From Year";
            // 
            // ToDateLabel
            // 
            this.ToDateLabel.AutoSize = true;
            this.ToDateLabel.Enabled = false;
            this.ToDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToDateLabel.Location = new System.Drawing.Point(13, 331);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(89, 25);
            this.ToDateLabel.TabIndex = 11;
            this.ToDateLabel.Text = "To Year";
            // 
            // NumberOfLaureatesTrackBar
            // 
            this.NumberOfLaureatesTrackBar.Location = new System.Drawing.Point(19, 436);
            this.NumberOfLaureatesTrackBar.Maximum = 4;
            this.NumberOfLaureatesTrackBar.Name = "NumberOfLaureatesTrackBar";
            this.NumberOfLaureatesTrackBar.Size = new System.Drawing.Size(261, 45);
            this.NumberOfLaureatesTrackBar.TabIndex = 12;
            this.NumberOfLaureatesTrackBar.Scroll += new System.EventHandler(this.NumberOfLaureatesTrackBar_Scroll);
            // 
            // NumberOfLaureatesTextBox
            // 
            this.NumberOfLaureatesTextBox.Location = new System.Drawing.Point(244, 404);
            this.NumberOfLaureatesTextBox.Name = "NumberOfLaureatesTextBox";
            this.NumberOfLaureatesTextBox.ReadOnly = true;
            this.NumberOfLaureatesTextBox.Size = new System.Drawing.Size(36, 20);
            this.NumberOfLaureatesTextBox.TabIndex = 13;
            this.NumberOfLaureatesTextBox.Text = "0";
            // 
            // NUmberOfLaureatesLabel
            // 
            this.NUmberOfLaureatesLabel.AutoSize = true;
            this.NUmberOfLaureatesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUmberOfLaureatesLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NUmberOfLaureatesLabel.Location = new System.Drawing.Point(14, 399);
            this.NUmberOfLaureatesLabel.Name = "NUmberOfLaureatesLabel";
            this.NUmberOfLaureatesLabel.Size = new System.Drawing.Size(219, 25);
            this.NUmberOfLaureatesLabel.TabIndex = 14;
            this.NUmberOfLaureatesLabel.Text = "Number of Laureates:";
            // 
            // ResetFiltersLinkLabel
            // 
            this.ResetFiltersLinkLabel.AutoSize = true;
            this.ResetFiltersLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetFiltersLinkLabel.Location = new System.Drawing.Point(339, 436);
            this.ResetFiltersLinkLabel.Name = "ResetFiltersLinkLabel";
            this.ResetFiltersLinkLabel.Size = new System.Drawing.Size(52, 20);
            this.ResetFiltersLinkLabel.TabIndex = 15;
            this.ResetFiltersLinkLabel.TabStop = true;
            this.ResetFiltersLinkLabel.Text = "Reset";
            this.ResetFiltersLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetFiltersLinkLabel_LinkClicked);
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.Location = new System.Drawing.Point(473, 498);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(199, 44);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.CustomFormat = "yyyy";
            this.FromDateTimePicker.Enabled = false;
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDateTimePicker.Location = new System.Drawing.Point(136, 334);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.ShowUpDown = true;
            this.FromDateTimePicker.Size = new System.Drawing.Size(255, 20);
            this.FromDateTimePicker.TabIndex = 17;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.CustomFormat = "yyyy";
            this.ToDateTimePicker.Enabled = false;
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDateTimePicker.Location = new System.Drawing.Point(136, 292);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.ShowUpDown = true;
            this.ToDateTimePicker.Size = new System.Drawing.Size(255, 20);
            this.ToDateTimePicker.TabIndex = 19;
            this.ToDateTimePicker.Value = new System.DateTime(1900, 6, 8, 13, 32, 0, 0);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Enabled = false;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CategoryLabel.Location = new System.Drawing.Point(13, 247);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(99, 25);
            this.CategoryLabel.TabIndex = 20;
            this.CategoryLabel.Text = "Category";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Enabled = false;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(136, 253);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 21;
            // 
            // LaureatesViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 554);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ResetFiltersLinkLabel);
            this.Controls.Add(this.NUmberOfLaureatesLabel);
            this.Controls.Add(this.NumberOfLaureatesTextBox);
            this.Controls.Add(this.NumberOfLaureatesTrackBar);
            this.Controls.Add(this.ToDateLabel);
            this.Controls.Add(this.FromDateLabel);
            this.Controls.Add(this.SetAddFiltersCheckBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SurnameValueTextBox);
            this.Controls.Add(this.NameValueTextBox);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.PrizesDataGridView);
            this.Name = "LaureatesViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaureatesViewerForm";
            ((System.ComponentModel.ISupportInitialize)(this.PrizesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLaureatesTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PrizesDataGridView;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.TextBox NameValueTextBox;
        private System.Windows.Forms.TextBox SurnameValueTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.CheckBox SetAddFiltersCheckBox;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.Label ToDateLabel;
        private System.Windows.Forms.TrackBar NumberOfLaureatesTrackBar;
        private System.Windows.Forms.TextBox NumberOfLaureatesTextBox;
        private System.Windows.Forms.Label NUmberOfLaureatesLabel;
        private System.Windows.Forms.LinkLabel ResetFiltersLinkLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
    }
}