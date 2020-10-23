using System;
using System.Windows.Forms;

namespace FLOPPER_ui
{
    public partial class selectOp : Form
    {
        public int selectedOp;

        public selectOp()
        {
            InitializeComponent();
        }

        private void cancel(object sender, FormClosingEventArgs e)
        {

        }

        private void choose(object sender, EventArgs e)
        {
            selectedOp = list_ops.SelectedIndex;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
