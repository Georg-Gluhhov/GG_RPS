using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GG_RPS
{
    public partial class save : Form
    {
        Label lbl, lbl1, lbl2;
        TextBox dynamicTextBox ;
        public save()
        {
            this.Height = 400;
            this.Width = 400;
            dynamicTextBox.BackColor = Color.Red;
            dynamicTextBox.ForeColor = Color.Blue;
            dynamicTextBox.Text = "I am Dynamic TextBox";
            dynamicTextBox.Name = "DynamicTextBox";
            dynamicTextBox.Font = newFont("Georgia", 16);
        }

        private void save_Load(object sender, EventArgs e)
        {

        }
    }
}
