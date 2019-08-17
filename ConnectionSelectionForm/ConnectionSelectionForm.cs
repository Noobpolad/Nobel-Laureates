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

        /// <summary>
        /// Call the LaureatesViewerForm form, during the execution of which, disable the current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmConnectionButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.InitializeConnection((ConnectionType)ConnectionsComboBox.SelectedItem);
            LaureatesViewerForm lvf = new LaureatesViewerForm();
            lvf.FormClosed += Lvf_FormClosed;
            this.Enabled = false;
        }

        /// <summary>
        /// When the called form is closed, enable current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lvf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        /// <summary>
        /// Wire the connection options.
        /// </summary>
        private void WireUpList()
        {
            ConnectionsComboBox.DataSource = null;
            ConnectionsComboBox.DataSource = availableConnections;
        }
    }
}
