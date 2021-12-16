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
    public partial class Form1 : Form
    {
        PictureBox pb, pb1, pb2, pb3, pb4;
        Label lbl, lbl1, lbl2;
        Button bt, bt1, bt2;
        Random rnd = new Random();

        public static int choose = 0;
        public static int win = 0;
        public static int score = 0;
        public static int bscore = 0;

        public Form1()
        {
            this.Height = 720;
            this.Width = 1280;

            //Rock
            pb = new PictureBox();
            pb.Size = new Size(100, 100);
            pb.Location = new Point(200, 100);
            pb.ImageLocation = ("../../img/rock.png");
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.MouseClick += Pb_MouseClick;
            this.Controls.Add(pb);
            //Paper
            pb1 = new PictureBox();
            pb1.Size = new Size(100, 100);
            pb1.Location = new Point(600, 100);
            pb1.ImageLocation = ("../../img/paper.png");
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.MouseClick += Pb1_MouseClick;
            this.Controls.Add(pb1);
            //Scissors
            pb2 = new PictureBox();
            pb2.Size = new Size(100, 100);
            pb2.Location = new Point(1000, 100);
            pb2.ImageLocation = ("../../img/Scissors.png");
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.MouseClick += Pb2_MouseClick;
            this.Controls.Add(pb2);
            //Result player 
            pb3 = new PictureBox();
            pb3.Size = new Size(100, 100);
            pb3.Location = new Point(200, 300);
            pb3.ImageLocation = ("../../img/rock.png");
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pb3);
            //Result bot 
            pb4 = new PictureBox();
            pb4.Size = new Size(100, 100);
            pb4.Location = new Point(1000, 300);
            pb4.ImageLocation = ("../../img/rock.png");
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pb4);

            //Start Button
            bt = new Button();
            bt.Text = "Alusta";
            bt.Location = new Point(600, 600);
            bt.Click += Bt_Click;
            this.Controls.Add(bt);

            //Save Button
            bt1 = new Button();
            bt1.Text = "Salvesta skoor";
            bt1.Location = new Point(800, 600);
            bt1.Click += Bt1_Click;
            this.Controls.Add(bt1);

            //Save Button
            bt2 = new Button();
            bt2.Text = "Edetabel";
            bt2.Location = new Point(400, 600);
            bt2.Click += Bt1_Click;
            this.Controls.Add(bt2);

            //Lbl Result 
            lbl = new Label();
            lbl.Text = $"{score} skoor {score}";
            lbl.Size = new Size(100, 100);
            lbl.Location = new Point(590, 360);
            this.Controls.Add(lbl);
            //Lbl test 
            lbl1 = new Label();
            lbl1.Text = $"{score} skoor {score}";
            lbl1.Size = new Size(100, 100);
            lbl1.Location = new Point(200, 600);


            this.BackColor = System.Drawing.Color.White;
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            Hide();
            save Save = new save();
            Save.ShowDialog();
            Save = null;
            Show();
        }

        public void Bt_Click(object sender, EventArgs e)
        {
            int bot1 = rnd.Next(1, 4);
            //r
            if (choose == 1)
            {
                if (bot1 == 1)
                {
                    //r
                    win = 2;
                    pb4.Image = Image.FromFile("../../img/rock.png");
                }
                else if (bot1 == 2)
                {
                    //p
                    win = 0;
                    pb4.Image = Image.FromFile("../../img/paper.png");
                }
                else if (bot1 == 3)
                {
                    //s
                    win = 1;
                    pb4.Image = Image.FromFile("../../img/Scissors.png");
                }

            }
            //p
            else if (choose == 2)
            {
                if (bot1 == 1)
                {
                    //r
                    win = 1;
                    pb4.Image = Image.FromFile("../../img/rock.png");
                }
                else if (bot1 == 2)
                {
                    //p
                    win = 2;
                    pb4.Image = Image.FromFile("../../img/paper.png");
                }
                else if (bot1 == 3)
                {
                    //s
                    win = 0;
                    pb4.Image = Image.FromFile("../../img/Scissors.png");
                }

            }
            //s
            else if (choose == 3)
            {
                if (bot1 == 1)
                {
                    //r
                    win = 0;
                    pb4.Image = Image.FromFile("../../img/rock.png");
                }
                else if (bot1 == 2)
                {
                    //p
                    win = 1;
                    pb4.Image = Image.FromFile("../../img/paper.png");
                }
                else if (bot1 == 3)
                {
                    //s
                    win = 2;
                    pb4.Image = Image.FromFile("../../img/Scissors.png");
                }

            }
            if (win == 1)
            {
                score += 1;
            }
            else if (win == 0)
            {
                bscore += 1;
            }
            lbl.Text = $"{score} Score {bscore}";
            lbl1.Text = $"win{win} choose{choose} bscore{bscore} score{score} botchoose{bot1}";
            

        }

        private void Pb_MouseClick(object sender, MouseEventArgs e)
        {
            choose = 1;
            pb3.Image = Image.FromFile("../../img/rock.png");

        }

        private void Pb1_MouseClick(object sender, MouseEventArgs e)
        {
            choose = 2;
            pb3.Image = Image.FromFile("../../img/paper.png");
        }
        private void Pb2_MouseClick(object sender, MouseEventArgs e)
        {
            choose = 3;
            pb3.Image = Image.FromFile("../../img/Scissors.png");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
