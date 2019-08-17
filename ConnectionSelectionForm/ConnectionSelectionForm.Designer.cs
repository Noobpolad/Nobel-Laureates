namespace ConnectionSelectionForm
{
    partial class ConnectionSelectionForm
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
            this.ConnectionsComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectionTypeLabel = new System.Windows.Forms.Label();
            this.ConfirmConnectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectionsComboBox
            // 
            this.ConnectionsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionsComboBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ConnectionsComboBox.FormattingEnabled = true;
            this.ConnectionsComboBox.Location = new System.Drawing.Point(125, 117);
            this.ConnectionsComboBox.Name = "ConnectionsComboBox";
            this.ConnectionsComboBox.Size = new System.Drawing.Size(267, 33);
            this.ConnectionsComboBox.TabIndex = 0;
            // 
            // ConnectionTypeLabel
            // 
            this.ConnectionTypeLabel.AutoSize = true;
            this.ConnectionTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionTypeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ConnectionTypeLabel.Location = new System.Drawing.Point(171, 77);
            this.ConnectionTypeLabel.Name = "ConnectionTypeLabel";
            this.ConnectionTypeLabel.Size = new System.Drawing.Size(175, 25);
            this.ConnectionTypeLabel.TabIndex = 1;
            this.ConnectionTypeLabel.Text = "Connection Type";
            // 
            // ConfirmConnectionButton
            // 
            this.ConfirmConnectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmConnectionButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ConfirmConnectionButton.Location = new System.Drawing.Point(173, 175);
            this.ConfirmConnectionButton.Name = "ConfirmConnectionButton";
            this.ConfirmConnectionButton.Size = new System.Drawing.Size(170, 37);
            this.ConfirmConnectionButton.TabIndex = 2;
            this.ConfirmConnectionButton.Text = "Confirm";
            this.ConfirmConnectionButton.UseVisualStyleBackColor = true;
            this.ConfirmConnectionButton.Click += new System.EventHandler(this.ConfirmConnectionButton_Click);
            // 
            // ConnectionSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 289);
            this.Controls.Add(this.ConfirmConnectionButton);
            this.Controls.Add(this.ConnectionTypeLabel);
            this.Controls.Add(this.ConnectionsComboBox);
            this.Name = "ConnectionSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ConnectionsComboBox;
        private System.Windows.Forms.Label ConnectionTypeLabel;
        private System.Windows.Forms.Button ConfirmConnectionButton;
    }
}

