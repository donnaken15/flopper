using System;
using System.Windows.Forms;

namespace FLOPPER_ui
{
    public partial class mainForm : Form
    {
        public string[] ops =
        {
            "Nothing",
"Addition",
"Subtraction",
"Multiply",
"Divide",
"Power",
"Print",
"Round",
"Floor",
"√",
"Sin",
"Cos",
"Tan",
"Ln",
"Log"
        };

        public mainForm()
        {
            InitializeComponent();
        }

        private void ops_add_Click(object sender, EventArgs e)
        {
            var newop = new selectOp();
            DialogResult opr = newop.ShowDialog();
            if (opr == DialogResult.OK)
            {
                list_ops.Items.Add(ops[newop.selectedOp]);
            }
        }
    }
}
