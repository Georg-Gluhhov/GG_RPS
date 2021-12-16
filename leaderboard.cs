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

namespace GG_RPS
{
    public partial class leaderboard : Form
    {
        Label lb1;
        ComboBox cmb;

        public leaderboard()
        {
            this.Height = 720;
            this.Width = 400;
            cmb = new ComboBox();

            cmb.Size = new Size(400, 720);
            cmb.Location = new Point(0, 0);
            cmb.DropDownStyle = ComboBoxStyle.Simple;
            this.Controls.Add(cmb);

            var path = "../../highscore.txt"; // Путь к произвольному текстовому файлу
            var myList = File.ReadAllLines(path);
            foreach (var item in myList)
            {
                cmb.Items.Add(item);
            }


        }


        private void leaderboard_Load(object sender, EventArgs e)
        {

        }
    }
}
