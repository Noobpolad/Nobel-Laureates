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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionSelectionForm
{
    public partial class LaureatesViewerForm : Form
    {
        List<string> Categories = new List<string>();

        public LaureatesViewerForm()
        {
            InitializeComponent();
            InitializeEvents();
            InitializeData();
            this.Show();
        }

        private async void InitializeData()
        {
            await Task.Run(() => GlobalConfig.Connection.InitializePrizes());
            InitializeCategories();
            WireUpCategoriesComboBox();
            WireUpBox(GlobalConfig.Connection.Container.Prizes);
        }

        private void InitializeCategories()
        {
            foreach (PrizeModel prize in GlobalConfig.Connection.Container.Prizes)
            {
                if (!Categories.Contains(prize.Category))
                {
                    Categories.Add(prize.Category);
                }
            }
        }

        private void WireUpCategoriesComboBox()
        {
            CategoryComboBox.DataSource = Categories;
        }

        private void InitializeEvents()
        {
            PrizesDataGridView.DataBindingComplete += PrizesDataGridView_DataBindingComplete;
        }

        private void PrizesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SearchButton.Enabled = true;
        }

        private async void WireUpBox(List<PrizeModel> data)
        {
            List<RepresentationObject> presentationData = await Task.Run(() => GlobalConfig.Connection.ConverPrizesToRepresentationObjects(data));
            BindingSource binding = new BindingSource();
            binding.DataSource = presentationData;
            PrizesDataGridView.DataSource = binding;
        }

        private void SetAddFiltersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SetAddFiltersCheckBox.Checked)
            {
                FromDateTimePicker.Enabled = true;
                ToDateTimePicker.Enabled = true;
                FromDateLabel.Enabled = true;
                ToDateLabel.Enabled = true;
                CategoryLabel.Enabled = true;
                CategoryComboBox.Enabled = true;
            }
            else
            {
                FromDateTimePicker.Enabled = false;
                ToDateTimePicker.Enabled = false;
                FromDateLabel.Enabled = false;
                ToDateLabel.Enabled = false;
                CategoryLabel.Enabled = false;
                CategoryComboBox.Enabled = false;
            }
        }

        private void ResetFiltersLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NameValueTextBox.Text = "";
            SurnameValueTextBox.Text = "";
            SetAddFiltersCheckBox.CheckState = CheckState.Unchecked;
            NumberOfLaureatesTextBox.Text = "0";
            NumberOfLaureatesTrackBar.Value = 0;
            FromDateTimePicker.Value = DateTime.Now;
            ToDateTimePicker.Value = DateTime.Now;
            WireUpBox(GlobalConfig.Connection.Container.Prizes);
        }

        private void NumberOfLaureatesTrackBar_Scroll(object sender, EventArgs e)
        {
            NumberOfLaureatesTextBox.Text = NumberOfLaureatesTrackBar.Value.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<PrizeModel> output = GlobalConfig.Connection.Container.Prizes;
            SearchButton.Enabled = false;
            output = PerformFiltration(output);
            WireUpBox(output);
        }

        private List<PrizeModel> PerformFiltration(List<PrizeModel> data)
        {
            if (NameValueTextBox.Text.Length != 0)
            {
                data = GlobalConfig.Connection.FilterOnName(NameValueTextBox.Text, data);
            }
            if (SurnameValueTextBox.Text.Length != 0)
            {
                data = GlobalConfig.Connection.FilterOnSurname(SurnameValueTextBox.Text, data);
            }
            if (NumberOfLaureatesTextBox.Text != "0")
            {
                data = GlobalConfig.Connection.FilterOnShareNumber(Convert.ToInt32(NumberOfLaureatesTextBox.Text), data);
            }
            if (SetAddFiltersCheckBox.Checked)
            {
                data = GlobalConfig.Connection.FilterOnDates(Convert.ToInt32(FromDateTimePicker.Text), Convert.ToInt32(ToDateTimePicker.Text), data);
                data = GlobalConfig.Connection.FilterOnCategory((string)CategoryComboBox.SelectedItem, data);
            }

            return data;
        }
    }
}