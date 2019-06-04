using NobelLaureates;
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
    public partial class ConnectionSelectionForm : Form
    {
        List<ConnectionType> availableConnections = new List<ConnectionType>() { ConnectionType.CSV, ConnectionType.JSON };

        public ConnectionSelectionForm()
        {
            InitializeComponent();
            WireUpList();
        }

        private void ConfirmConnectionButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.InitializeConnection((ConnectionType)ConnectionsComboBox.SelectedItem);
            LaureatesViewerForm lvf = new LaureatesViewerForm();
            lvf.Show();
            this.Enabled = false;
            lvf.FormClosed += Lvf_FormClosed;
        }

        private void Lvf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void WireUpList()
        {
            ConnectionsComboBox.DataSource = null;
            ConnectionsComboBox.DataSource = availableConnections;
        }
    }
}
