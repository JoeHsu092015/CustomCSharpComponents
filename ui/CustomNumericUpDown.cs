using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ICV_Tool.components.ui
{
    public partial class CustomNumericUpDown : UserControl
    {
        public event EventHandler TextChanged;

        #region -> Properties
        public string Title
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }
        #endregion

        public CustomNumericUpDown()
        {
            InitializeComponent();
            labelTitle.ForeColor = Color.FromArgb(165, 165, 165);
            textBoxNum.ForeColor = Color.FromArgb(127, 127, 127);
            textBoxNum.BackColor = Color.FromArgb(242, 242, 242);
            textBoxNum.ReadOnly = true;
            customPanel1.BackColor = Color.FromArgb(242, 242, 242);
        }

        public int GetNumber()
        {
            return int.Parse(textBoxNum.Text);
        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int currentNum = int.Parse(textBoxNum.Text);
            textBoxNum.Text = (++currentNum).ToString();
            textBoxNum.Show();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int currentNum = int.Parse(textBoxNum.Text);
            currentNum--;
            if (currentNum < 1)
                currentNum = 1;

            textBoxNum.Text = (currentNum).ToString();
            textBoxNum.Show();
        }

        private void buttonDown_DoubleClick(object sender, EventArgs e)
        {
            buttonDown_Click(sender, e);
        }

        private void buttonUp_DoubleClick(object sender, EventArgs e)
        {
            buttonUp_Click(sender, e);
        }

        private void textBoxNum_TextChanged(object sender, EventArgs e)
        {
            TextChanged?.Invoke(sender, e);
        }
    }
}
