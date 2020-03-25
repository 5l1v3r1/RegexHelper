using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Regex_Tester
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                tbOutput.Text = null;
                foreach(Match m in Regex.Matches(tbInput.Text, tbExpression.Text))
                {
                    tbOutput.AppendText(m.Value + "\r\n");
                }
            }
            catch (Exception ex) // In the event of a severe fuck-up.
            {
                tbOutput.Text = ex.Message;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MaximumSize = Size;
            MinimumSize = Size;
        }
    }
}
