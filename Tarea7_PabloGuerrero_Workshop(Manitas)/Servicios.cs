using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop
{
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMetal_Click(object sender, EventArgs e)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox("Under Construction...");
            customMessageBox.ShowDialog();
        }

        private void btnMech_Click(object sender, EventArgs e)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox("Under Construction...");
            customMessageBox.ShowDialog(); MessageBox.Show("Under Construction...");
        }

        private void btnWood_Click(object sender, EventArgs e)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox("Under Construction...");
            customMessageBox.ShowDialog();
        }

        private void btnPlumb_Click(object sender, EventArgs e)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox("Under Construction...");
            customMessageBox.ShowDialog();
        }
    }
}
