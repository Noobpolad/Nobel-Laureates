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
            this.SetDateCheckBox = new System.Windows.Forms.CheckBox();
            this.FromDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.ToDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NumberOfLaureatesTrackBar = new System.Windows.Forms.TrackBar();
            this.NumberOfLaureatesTextBox = new System.Windows.Forms.TextBox();
            this.NUmberOfLaureatesLabel = new System.Windows.Forms.Label();
            this.ResetFiltersLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrizesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLaureatesTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PrizesDataGridView
            // 
            this.PrizesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrizesDataGridView.Location = new System.Drawing.Point(492, 34);
            this.PrizesDataGridView.Name = "PrizesDataGridView";
            this.PrizesDataGridView.Size = new System.Drawing.Size(432, 430);
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
            this.NameValueTextBox.Size = new System.Drawing.Size(179, 31);
            this.NameValueTextBox.TabIndex = 2;
            // 
            // SurnameValueTextBox
            // 
            this.SurnameValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameValueTextBox.Location = new System.Drawing.Point(208, 149);
            this.SurnameValueTextBox.Name = "SurnameValueTextBox";
            this.SurnameValueTextBox.Size = new System.Drawing.Size(179, 31);
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
            this.NameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // SetDateCheckBox
            // 
            this.SetDateCheckBox.AutoSize = true;
            this.SetDateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDateCheckBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SetDateCheckBox.Location = new System.Drawing.Point(276, 205);
            this.SetDateCheckBox.Name = "SetDateCheckBox";
            this.SetDateCheckBox.Size = new System.Drawing.Size(111, 29);
            this.SetDateCheckBox.TabIndex = 6;
            this.SetDateCheckBox.Text = "Set date";
            this.SetDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // FromDateDateTimePicker
            // 
            this.FromDateDateTimePicker.Enabled = false;
            this.FromDateDateTimePicker.Location = new System.Drawing.Point(136, 289);
            this.FromDateDateTimePicker.Name = "FromDateDateTimePicker";
            this.FromDateDateTimePicker.Size = new System.Drawing.Size(261, 20);
            this.FromDateDateTimePicker.TabIndex = 7;
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.AutoSize = true;
            this.FromDateLabel.Enabled = false;
            this.FromDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FromDateLabel.Location = new System.Drawing.Point(13, 286);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(112, 25);
            this.FromDateLabel.TabIndex = 9;
            this.FromDateLabel.Text = "From Date";
            // 
            // ToDateLabel
            // 
            this.ToDateLabel.AutoSize = true;
            this.ToDateLabel.Enabled = false;
            this.ToDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToDateLabel.Location = new System.Drawing.Point(13, 329);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(88, 25);
            this.ToDateLabel.TabIndex = 11;
            this.ToDateLabel.Text = "To Date";
            // 
            // ToDateDateTimePicker
            // 
            this.ToDateDateTimePicker.Enabled = false;
            this.ToDateDateTimePicker.Location = new System.Drawing.Point(136, 332);
            this.ToDateDateTimePicker.Name = "ToDateDateTimePicker";
            this.ToDateDateTimePicker.Size = new System.Drawing.Size(261, 20);
            this.ToDateDateTimePicker.TabIndex = 10;
            // 
            // NumberOfLaureatesTrackBar
            // 
            this.NumberOfLaureatesTrackBar.Location = new System.Drawing.Point(18, 419);
            this.NumberOfLaureatesTrackBar.Name = "NumberOfLaureatesTrackBar";
            this.NumberOfLaureatesTrackBar.Size = new System.Drawing.Size(261, 45);
            this.NumberOfLaureatesTrackBar.TabIndex = 12;
            // 
            // NumberOfLaureatesTextBox
            // 
            this.NumberOfLaureatesTextBox.Location = new System.Drawing.Point(243, 387);
            this.NumberOfLaureatesTextBox.Name = "NumberOfLaureatesTextBox";
            this.NumberOfLaureatesTextBox.ReadOnly = true;
            this.NumberOfLaureatesTextBox.Size = new System.Drawing.Size(36, 20);
            this.NumberOfLaureatesTextBox.TabIndex = 13;
            this.NumberOfLaureatesTextBox.Text = "0";
            this.NumberOfLaureatesTextBox.TextChanged += new System.EventHandler(this.NumberOfLaureatesTextBox_TextChanged);
            // 
            // NUmberOfLaureatesLabel
            // 
            this.NUmberOfLaureatesLabel.AutoSize = true;
            this.NUmberOfLaureatesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUmberOfLaureatesLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NUmberOfLaureatesLabel.Location = new System.Drawing.Point(13, 382);
            this.NUmberOfLaureatesLabel.Name = "NUmberOfLaureatesLabel";
            this.NUmberOfLaureatesLabel.Size = new System.Drawing.Size(219, 25);
            this.NUmberOfLaureatesLabel.TabIndex = 14;
            this.NUmberOfLaureatesLabel.Text = "Number of Laureates:";
            // 
            // ResetFiltersLinkLabel
            // 
            this.ResetFiltersLinkLabel.AutoSize = true;
            this.ResetFiltersLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetFiltersLinkLabel.Location = new System.Drawing.Point(344, 419);
            this.ResetFiltersLinkLabel.Name = "ResetFiltersLinkLabel";
            this.ResetFiltersLinkLabel.Size = new System.Drawing.Size(99, 20);
            this.ResetFiltersLinkLabel.TabIndex = 15;
            this.ResetFiltersLinkLabel.TabStop = true;
            this.ResetFiltersLinkLabel.Text = "Reset Filters";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.Location = new System.Drawing.Point(375, 489);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(199, 44);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // LaureatesViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 554);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ResetFiltersLinkLabel);
            this.Controls.Add(this.NUmberOfLaureatesLabel);
            this.Controls.Add(this.NumberOfLaureatesTextBox);
            this.Controls.Add(this.NumberOfLaureatesTrackBar);
            this.Controls.Add(this.ToDateLabel);
            this.Controls.Add(this.ToDateDateTimePicker);
            this.Controls.Add(this.FromDateLabel);
            this.Controls.Add(this.FromDateDateTimePicker);
            this.Controls.Add(this.SetDateCheckBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SurnameValueTextBox);
            this.Controls.Add(this.NameValueTextBox);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.PrizesDataGridView);
            this.Name = "LaureatesViewerForm";
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
        private System.Windows.Forms.CheckBox SetDateCheckBox;
        private System.Windows.Forms.DateTimePicker FromDateDateTimePicker;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.Label ToDateLabel;
        private System.Windows.Forms.DateTimePicker ToDateDateTimePicker;
        private System.Windows.Forms.TrackBar NumberOfLaureatesTrackBar;
        private System.Windows.Forms.TextBox NumberOfLaureatesTextBox;
        private System.Windows.Forms.Label NUmberOfLaureatesLabel;
        private System.Windows.Forms.LinkLabel ResetFiltersLinkLabel;
        private System.Windows.Forms.Button SearchButton;
    }
}