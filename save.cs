using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
namespace GG_RPS
{
    public partial class save : Form
    {
        Label lbl, lbl1, lbl2;
        TextBox tb;
        Button bt;
        public save()
        {
            tb = new TextBox();
            tb.Size = new Size(100, 100);
            tb.Location = new Point(100, 100);
            this.Controls.Add(tb);

            bt = new Button();
            bt.Text = "";
            bt.Location = new Point(100, 200);
            bt.Click += Bt_Click;
            this.Controls.Add(bt);



        }

        private void Bt_Click(object sender, EventArgs e)
        {
            string a = tb.Text.ToString();
            ExampleAsync(1, a);
        }

        public void ExampleAsync(int score, string name)
        {
            TextWriter tsw = new StreamWriter("../../highscore.txt", true);

            tsw.WriteLine($"Name {name} Score - {score}");

            tsw.Close();
        }

        private void save_Load(object sender, EventArgs e)
        {

        }
    }
}
