using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {

        private static Point First; 
        private static Point Second;

        private static double Distance(Point a, Point b)
        {

            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

       
        public class GameObject
        {
            PictureBox pic = new PictureBox();
            public PictureBox Pic
            {
                get { return pic; }
                set { pic = value; }
            }
        }
        public class Level
        {
            public Level(int num, Form frm)
            {
                if(num == 1)
                {
                    PictureBox p1 = new PictureBox();
                    p1.Image = Properties.Resources.grass;
                    p1.Location = new Point(frm.Width / 2-60, 0);
                    p1.Size = new Size(120, 190);
                    p1.SizeMode = PictureBoxSizeMode.StretchImage;
                    p1.Tag = "texture";
                    frm.Controls.Add(p1);
                    p1.BringToFront();
                    PictureBox p2 = new PictureBox();
                    p2.Image = Properties.Resources.grass;
                    p2.Location = new Point(0, 100);
                    p2.Size = new Size(180, 65);
                    p2.SizeMode = PictureBoxSizeMode.StretchImage;
                    p2.Tag = "texture";
                    frm.Controls.Add(p2);
                    p2.BringToFront();
                    PictureBox p3 = new PictureBox();
                    p3.Image = Properties.Resources.grass;
                    p3.Location = new Point(frm.Width - 195, 100);
                    p3.Size = new Size(180, 65);
                    p3.SizeMode = PictureBoxSizeMode.StretchImage;
                    p3.Tag = "texture";
                    frm.Controls.Add(p3);
                    p3.BringToFront();
                    PictureBox p4 = new PictureBox();
                    p4.Image = Properties.Resources.grass;
                    p4.Location = new Point(130, 280);
                    p4.Size = new Size(220, 90);
                    p4.SizeMode = PictureBoxSizeMode.StretchImage;
                    p4.Tag = "texture";
                    frm.Controls.Add(p4);
                    p4.BringToFront();
                    PictureBox p5 = new PictureBox();
                    p5.Image = Properties.Resources.grass;
                    p5.Location = new Point(460, 280);
                    p5.Size = new Size(220, 90);
                    p5.SizeMode = PictureBoxSizeMode.StretchImage;
                    p5.Tag = "texture";
                    frm.Controls.Add(p5);
                    p5.BringToFront();
                    First = new Point(20, 30);
                    Second = new Point(frm.Width - 80, 30);
                    pl1.Pic.Location = First;
                    pl2.Pic.Location = Second;
                    fs = new FuelStation(frm, frm.Width/2 - 10, 425);
                }
                if(num == 2)
                {
                    PictureBox p = new PictureBox();
                    p.Image = Properties.Resources.grass;
                    p.Location = new Point(0, frm.Height-85);
                    p.Size = new Size(frm.Width, 20);
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Tag = "texture";
                    frm.Controls.Add(p);
                    p.BringToFront();
                    PictureBox p1 = new PictureBox();
                    p1.Image = Properties.Resources.grass;
                    p1.Location = new Point(110, 390);
                    p1.Size = new Size(250, 70);
                    p1.SizeMode = PictureBoxSizeMode.StretchImage;
                    p1.Tag = "texture";
                    frm.Controls.Add(p1);
                    p1.BringToFront();
                    PictureBox p2 = new PictureBox();
                    p2.Image = Properties.Resources.grass;
                    p2.Location = new Point(450, 310);
                    p2.Size = new Size(250, 70);
                    p2.SizeMode = PictureBoxSizeMode.StretchImage;
                    p2.Tag = "texture";
                    frm.Controls.Add(p2);
                    p2.BringToFront();
                    PictureBox p3 = new PictureBox();
                    p3.Image = Properties.Resources.grass;
                    p3.Location = new Point(110, 233);
                    p3.Size = new Size(250, 70);
                    p3.SizeMode = PictureBoxSizeMode.StretchImage;
                    p3.Tag = "texture";
                    frm.Controls.Add(p3);
                    p3.BringToFront();
                    PictureBox p4 = new PictureBox();
                    p4.Image = Properties.Resources.grass;
                    p4.Location = new Point(450, 150);
                    p4.Size = new Size(250, 70);
                    p4.SizeMode = PictureBoxSizeMode.StretchImage;
                    p4.Tag = "texture";
                    frm.Controls.Add(p4);
                    p4.BringToFront();
                    PictureBox p5 = new PictureBox();
                    p5.Image = Properties.Resources.grass;
                    p5.Location = new Point(110, 73);
                    p5.Size = new Size(250, 70);
                    p5.SizeMode = PictureBoxSizeMode.StretchImage;
                    p5.Tag = "texture";
                    frm.Controls.Add(p5);
                    p5.BringToFront();
                    PictureBox p6 = new PictureBox();
                    p6.Image = Properties.Resources.grass;
                    p6.Location = new Point(450, 0);
                    p6.Size = new Size(250, 70);
                    p6.SizeMode = PictureBoxSizeMode.StretchImage;
                    p6.Tag = "texture";
                    frm.Controls.Add(p6);
                    p6.BringToFront();
                    First = new Point(20, 380);
                    Second = new Point(frm.Width - 80, 380);
                    pl1.Pic.Location = First;
                    pl2.Pic.Location = Second;
                    fs = new FuelStation(frm, frm.Width / 2 -10, 405);
                }
                if(num == 3)
                {
                    PictureBox p = new PictureBox();
                    p.Image = Properties.Resources.grass;
                    p.Location = new Point(0, frm.Height - 85);
                    p.Size = new Size(frm.Width, 25);
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Tag = "texture";
                    frm.Controls.Add(p);
                    p.BringToFront();
                    PictureBox p1 = new PictureBox();
                    p1.Image = Properties.Resources.grass;
                    p1.Location = new Point(130, 390);
                    p1.Size = new Size(70, 70);
                    p1.SizeMode = PictureBoxSizeMode.StretchImage;
                    p1.Tag = "texture";
                    frm.Controls.Add(p1);
                    p1.BringToFront();
                    PictureBox p2 = new PictureBox();
                    p2.Image = Properties.Resources.grass;
                    p2.Location = new Point(200, 320);
                    p2.Size = new Size(70, 140);
                    p2.SizeMode = PictureBoxSizeMode.StretchImage;
                    p2.Tag = "texture";
                    frm.Controls.Add(p2);
                    p2.BringToFront();
                    PictureBox p3 = new PictureBox();
                    p3.Image = Properties.Resources.grass;
                    p3.Location = new Point(270, 250);
                    p3.Size = new Size(70, 210);
                    p3.SizeMode = PictureBoxSizeMode.StretchImage;
                    p3.Tag = "texture";
                    frm.Controls.Add(p3);
                    p3.BringToFront();
                    PictureBox p4 = new PictureBox();
                    p4.Image = Properties.Resources.grass;
                    p4.Location = new Point(340, 180);
                    p4.Size = new Size(140, 280);
                    p4.SizeMode = PictureBoxSizeMode.StretchImage;
                    p4.Tag = "texture";
                    frm.Controls.Add(p4);
                    p4.BringToFront();
                    PictureBox p5 = new PictureBox();
                    p5.Image = Properties.Resources.grass;
                    p5.Location = new Point(480, 250);
                    p5.Size = new Size(70, 210);
                    p5.SizeMode = PictureBoxSizeMode.StretchImage;
                    p5.Tag = "texture";
                    frm.Controls.Add(p5);
                    p5.BringToFront();
                    PictureBox p6 = new PictureBox();
                    p6.Image = Properties.Resources.grass;
                    p6.Location = new Point(550, 320);
                    p6.Size = new Size(70, 140);
                    p6.SizeMode = PictureBoxSizeMode.StretchImage;
                    p6.Tag = "texture";
                    frm.Controls.Add(p6);
                    p6.BringToFront();
                    PictureBox p7 = new PictureBox();
                    p7.Image = Properties.Resources.grass;
                    p7.Location = new Point(620, 390);
                    p7.Size = new Size(70, 70);
                    p7.SizeMode = PictureBoxSizeMode.StretchImage;
                    p7.Tag = "texture";
                    frm.Controls.Add(p7);
                    p7.BringToFront();
                    PictureBox p8 = new PictureBox();
                    p8.Image = Properties.Resources.grass;
                    p8.Location = new Point(375,100);
                    p8.Size = new Size(70, 280);
                    p8.SizeMode = PictureBoxSizeMode.StretchImage;
                    p8.Tag = "texture";
                    frm.Controls.Add(p8);
                    p8.BringToFront();

                    First = new Point(20, 380);
                    Second = new Point(frm.Width - 80, 380);
                    pl1.Pic.Location = First;
                    pl2.Pic.Location = Second;

                    fs = new FuelStation(frm, frm.Width / 2-10, 65);
                }
            }
        }

        static List<Bullet> bList = new List<Bullet>();
        public class Bullet : GameObject
        {
            bool active;
            int bulletSpeed = 5;
            public Bullet(Chopper c)
            {
                
                Pic.Image = Properties.Resources.bullet;
                Pic.Size = new Size(20, 5);
                if (c.side)
                {
                    Pic.Left = c.Pic.Left + c.Pic.Width;
                    Pic.Tag = "right";
                }
                if (!c.side)
                {
                    Pic.Left = c.Pic.Left - c.Pic.Width;
                    Pic.Tag = "left";
                }
                Pic.Top = c.Pic.Top + c.Pic.Height / 2;
                active = true;
                bList.Add(this);
            }
            public void Trace(Form frm)
            {
                if (Pic.Tag == "right")
                {
                    Pic.Left += bulletSpeed;
                    if (Pic.Left > frm.Width)
                    {
                        frm.Controls.Remove(Pic);

                    }
                }
                if (Pic.Tag == "left")
                {
                    Pic.Left -= bulletSpeed;
                    if (Pic.Left < 0)
                    {
                        frm.Controls.Remove(Pic);

                    }

                }

                if ((Pic.Tag == "left" || Pic.Tag == "right") && active)
                {
                    if (Pic.Bounds.IntersectsWith(pl1.Pic.Bounds))
                    {
                        if (Distance(pl2.Pic.Location, First) < Distance(pl2.Pic.Location, Second)) pl1.Die(false);
                        else pl1.Die(true);
                        frm.Controls.Remove(Pic);
                        active = false;

                    }
                    if (Pic.Bounds.IntersectsWith(pl2.Pic.Bounds))
                    {
                        if (Distance(pl1.Pic.Location, First) < Distance(pl1.Pic.Location, Second)) pl2.Die(false);
                        else pl2.Die(true);
                        frm.Controls.Remove(Pic);
                        active = false;

                    }

                    foreach (Control y in frm.Controls)
                    {
                        if (Pic.Bounds.IntersectsWith(y.Bounds) && ((y.Tag == "texture" && y is PictureBox)))
                        {
                            frm.Controls.Remove(Pic);
                            active = false;

                        }
                    }

                }
            }
        }
        public class FuelStation : GameObject
        {
            public FuelStation(Form frm, int x, int y)
            {
                Pic.Image = Properties.Resources.station;
                Pic.Location = new Point(x,y);
                Pic.Name = "FuelStation";
                Pic.Size = new Size(30, 35);
                Pic.SizeMode = PictureBoxSizeMode.StretchImage;
                frm.Controls.Add(Pic);
                Pic.BringToFront();
            }
            public void Fueling (Chopper c)
            {
                if ( Pic.Bounds.IntersectsWith(c.Pic.Bounds))
                {
                    if (c.curFuel + 5 < c.maxFuel)
                    {
                        c.curFuel += 5;
                    }
                    else if (c.curFuel < c.maxFuel)
                    {
                        c.curFuel = c.maxFuel;
                    }

                }
            }
        }


        public class Chopper : GameObject
        {
            public Image Left;
            public Image Right;
            int curX;
            int curY;
            public bool goleft, goright, goup, godown;
            public bool shot;
            public int curFuel;
            int speed = 2;
            int lives = 5;
            int reload = 70;
			public int maxFuel = 5000;
            public bool side; // true - to the right, false - to the left;
            //bool baseside;
            public int Lives { get => lives; set => lives = value; }
            public int CurFuel { get => curFuel; set => curFuel = value; }


            public Chopper(bool s, Image l, Image r)
            {
                Left = l;
                Right = r;
                goup = false;
                goleft = false;
                godown = false;
                goright = false;
                shot = false;
                side = s;
                //baseside = side;
                curFuel = maxFuel;
            }
            public void Update()
            {
                curX = Pic.Location.X;
                curY = Pic.Location.Y;
            }
            public void FallDown()
            {
                Pic.Location = new Point(Pic.Location.X, Pic.Location.Y + 1);
            }
            
            public void Move(Form frm)
            {
                foreach (Control x in frm.Controls)
                {
                    if ((x is PictureBox) && (x.Tag == "texture") && (x.Bounds.IntersectsWith(Pic.Bounds)))
                    {
                        Pic.Location = new Point(curX, curY);
                    }
                }
                if (Pic.Left <= 0)
                {
                    Pic.Left = 0;
                }
                if (Pic.Top <= 0)
                {
                    Pic.Top = 0;

                }
                if (Pic.Left >= frm.Width - Pic.Width - 15)
                {
                    Pic.Left = frm.Width - Pic.Width - 15;

                }
                if (Pic.Top >= frm.Height - Pic.Height - 70)
                {
                    Pic.Top = frm.Height - Pic.Height - 70;

                }

                Update();
                FallDown();
                
                if (curFuel > 0)
                {
                    if (goup)
                    {
                        Pic.Top -= speed;
                        curFuel--; ;
                    }
                    if (goleft)
                    {
                        
                        Pic.Image = Left;
                        side = false;
                        Pic.Left -= speed;
                        curFuel--;
                    }
                    if (godown)
                    {
                        Pic.Top += speed;
                        curFuel--;
                    }
                    if (goright)
                    {
                       
                        Pic.Image = Right;
                        side = true;
                        Pic.Left += speed;
                        curFuel--;
                    }
                }
            }

           
            //true - first, false - second
            public void Die(bool p)
            {
                Explode();
                Lives--;
                curFuel = maxFuel;
                if (Lives != 0)
                {
                    if (p)
                    {
                        //Flip();
                        Pic.Image = Right;
                        side = true;
                        Pic.Location = First;
                    }
                    if (!p)
                    {
                        //Flip();
                        Pic.Image = Left;
                        side = false;
                        Pic.Location = Second;
                    }
                }
            }
            public void Explode()
            {
                Pic.Image = Properties.Resources.exbg0008;
                Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            public void Shoot(Form frm)
            {

                if (shot && reload == 70)
                {
                    reload = 0;
                    Bullet b = new Bullet(this);
                    frm.Controls.Add(b.Pic);
                    b.Pic.BringToFront();

                    //b.Trace(frm);
                }
                if (reload != 70)
                {
                    reload++;
                }
                if (bList.Count != 0)
                {
                    foreach (Bullet b in bList)
                    {
                        b.Trace(frm);
                    }
                }
                
            }
        }
        public static PictureBox Player1
        {
            get
            {
                Form1 frm = new Form1();
                return frm.player1;
            }
        }
        public static PictureBox Player2
        {
            get
            {
                Form1 frm = new Form1();
                return frm.player2;
            }
        }
        static Chopper pl1 = new Chopper(true, Properties.Resources.ah6_left, Properties.Resources.ah6_right);
        static Chopper pl2 = new Chopper(false, Properties.Resources.z11_left, Properties.Resources.z11_right);
        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pl1.goup = true;
            }
            if (e.KeyCode == Keys.A)
            {
                pl1.goleft = true;
            }
            if (e.KeyCode == Keys.S)
            {
                pl1.godown = true;
            }
            if (e.KeyCode == Keys.D)
            {
                pl1.goright = true;
            }
            if (e.KeyCode == Keys.Q) pl1.shot = true;

            if (e.KeyCode == Keys.I)
            {
                pl2.goup = true;
            }
            if (e.KeyCode == Keys.J)
            {
                pl2.goleft = true;
            }
            if (e.KeyCode == Keys.K)
            {
                pl2.godown = true;
            }
            if (e.KeyCode == Keys.L)
            {
                pl2.goright = true;
            }
            if (e.KeyCode == Keys.U) pl2.shot = true;

        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pl1.goup = false;
            }
            if (e.KeyCode == Keys.A)
            {
                pl1.goleft = false;
            }
            if (e.KeyCode == Keys.S)
            {
                pl1.godown = false;
            }
            if (e.KeyCode == Keys.D)
            {
                pl1.goright = false;
            }
            if (e.KeyCode == Keys.Q) pl1.shot = false;

            if (e.KeyCode == Keys.I)
            {
                pl2.goup = false;
            }
            if (e.KeyCode == Keys.J)
            {
                pl2.goleft = false;
            }
            if (e.KeyCode == Keys.K)
            {
                pl2.godown = false;
            }
            if (e.KeyCode == Keys.L)
            {
                pl2.goright = false;
            }
            if (e.KeyCode == Keys.U) pl2.shot = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pl1.Move(this);
            pl2.Move(this);
            pl1.Shoot(this);
            pl2.Shoot(this);
            fs.Fueling(pl1);
            fs.Fueling(pl2);
            if (pl1.Pic.Bounds.IntersectsWith(pl2.Pic.Bounds))
            {
                pl1.Die(true);
                pl2.Die(false);

            }
         
            if (pl1.CurFuel > 0)
            {
                PBFuel1.Value = pl1.CurFuel;
            }
            else
            {
                PBFuel1.Value = 0;
            }
            if (pl1.CurFuel > 0)
            {
                PBFuel2.Value = pl2.CurFuel;
            }
            else
            {
                PBFuel2.Value = 0;
            }
            Score1.Text = pl1.Lives.ToString();
            Score2.Text = pl2.Lives.ToString();
            if (pl1.Lives == 0 && pl2.Lives == 0)
            {
                pl1.Explode();
                pl2.Explode();
                GameOver("Player 1 and Player 2");

            }

            else if (pl1.Lives == 0)
            {

                pl1.Explode();
                GameOver("Player 2");
            }

            else if (pl2.Lives == 0)
            {
                pl2.Explode();
                GameOver("Player 1");
            }
        }

        private void GameOver(string winner)
        {
            timer1.Stop();
            MessageBox.Show("Congratulations, " + winner + ", you win!!!");
            Application.Restart();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            Level l = new Level(2, this);
            timer1.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }
        static FuelStation fs;

        public Form1()
        {
            InitializeComponent();
            pl1.Pic = player1;
            pl2.Pic = player2;
            PBFuel1.Maximum = pl1.maxFuel;
            PBFuel2.Maximum = pl2.maxFuel;

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            Level l = new Level(1, this);
            timer1.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            Level l = new Level(3, this);
            timer1.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }
    }
}