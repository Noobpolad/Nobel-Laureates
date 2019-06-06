using NobelLaureates;
using NobelLaureates.Connection;
using NobelLaureates.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionSelectionForm
{
    public partial class LaureatesViewerForm : Form
    {
        public LaureatesViewerForm()
        {
            InitializeComponent();
            GlobalConfig.Connection.InitializePrizes();
            WireUpBox(GlobalConfig.Connection.ConverPrizesToRepresentationObjects(GlobalConfig.Connection.Container.Prizes));
        }


        private void WireUpBox(List<RepresentationObject> data)
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = data;
            PrizesDataGridView.DataSource = binding;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NumberOfLaureatesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SetDateCheckBox.Checked)
            {
                FromDateTimePicker.Enabled = true;
                ToDateTimePicker.Enabled = true;
                FromDateLabel.Enabled = true;
                ToDateLabel.Enabled = true;
            }
            else
            {
                FromDateTimePicker.Enabled = false;
                ToDateTimePicker.Enabled = false;
                FromDateLabel.Enabled = false;
                ToDateLabel.Enabled = false;
            }
        }

        private void ResetFiltersLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NameValueTextBox.Text = "";
            SurnameValueTextBox.Text = "";
            SetDateCheckBox.CheckState = CheckState.Unchecked;
            NumberOfLaureatesTextBox.Text = "0";
            NumberOfLaureatesTrackBar.Value = 0;
            FromDateTimePicker.Value = DateTime.Now;
            ToDateTimePicker.Value = DateTime.Now;
        }

        private void NumberOfLaureatesTrackBar_Scroll(object sender, EventArgs e)
        {
            NumberOfLaureatesTextBox.Text = NumberOfLaureatesTrackBar.Value.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<PrizeModel> output = GlobalConfig.Connection.Container.Prizes;

            if (NameValueTextBox.Text.Length != 0)
            {
                output = GlobalConfig.Connection.FilterOnName(NameValueTextBox.Text, GlobalConfig.Connection.Container.Prizes);
            }
            if (SurnameValueTextBox.Text.Length != 0)
            {
                output = GlobalConfig.Connection.FilterOnSurname(SurnameValueTextBox.Text, output);
            }
            if (NumberOfLaureatesTextBox.Text != "0")
            {
                output = GlobalConfig.Connection.FilterOnShareNumber(Convert.ToInt32(NumberOfLaureatesTextBox.Text), output);
            }
            if (SetDateCheckBox.Checked)
            {
                output = GlobalConfig.Connection.FilterOnDates(Convert.ToInt32(FromDateTimePicker.Text), Convert.ToInt32(ToDateTimePicker.Text), output);
            }

            WireUpBox(GlobalConfig.Connection.ConverPrizesToRepresentationObjects(output));

        }

        private void FromDateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
