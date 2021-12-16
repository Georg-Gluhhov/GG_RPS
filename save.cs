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
using static GG_RPS.Form1;
namespace GG_RPS
{
    public partial class save : Form
    {
        TextBox tb;
        Button bt;
        Label lb1;
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

            lb1 = new Label();
            lb1.Text = "Mis su nimi on?";
            lb1.Size = new Size(100, 100);
            lb1.Location = new Point(100, 50);
            this.Controls.Add(lb1);



        }

        private void Bt_Click(object sender, EventArgs e)
        {
            string a = tb.Text.ToString();
            int b = bscore;
            int s = score;
            ExampleAsync(s,b,a);
        }

        public static void ExampleAsync(int score1, int bscore1, string name)
        {
            TextWriter tsw = new StreamWriter("../../highscore.txt", true);

            tsw.WriteLine($"Name {name} Score - {score1} BotScore -{bscore1}");

            tsw.Close();
        }

        private void save_Load(object sender, EventArgs e)
        {

        }
    }
}
