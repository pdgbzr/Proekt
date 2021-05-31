using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace race
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            over.Visible = false;
            button1.Visible = false;
            enemy1.Visible = true;
            enemy2.Visible = true;
            enemy3.Visible = true;
            coin1.Visible = true;
            coin2.Visible = true;
            coin3.Visible = true;
        }

        private void raceTimer_Tick(object sender, EventArgs e)
        {
            
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
        }

        int collected_coin = 0;


        Random r = new Random();
        int x, y;
         public void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0,90);
                enemy1.Location = new Point(x, y);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = r.Next(115, 210);
                enemy2.Location = new Point(x, y);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = r.Next(230, 290);
                enemy3.Location = new Point(x, y);
            }
            else
            {
                enemy3.Top += speed;
            }
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

         public void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 90);
                coin1.Location = new Point(x, y);
            }
            else
            {
                coin1.Top += speed;
            }
            
            if (coin2.Top >= 500)
            {
                x = r.Next(105, 190);
             
                coin2.Location = new Point(x, y);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = r.Next(200, 260);
                coin3.Location = new Point(x, y);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = r.Next(280, 320);
                coin4.Location = new Point(x, y);
            }
            else
            {
                coin4.Top += speed;
            }
        }

        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                raceTimer.Enabled = false;
                over.Visible = true;
                button1.Visible = true;
                enemy1.Visible = false;
                enemy2.Visible = false;
                enemy3.Visible = false;
                coin1.Visible = false;
                coin2.Visible = false;
                coin3.Visible = false;
                car.Visible = false;
                gamespeed = 0;
            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                raceTimer.Enabled = false;
                over.Visible = true;
                button1.Visible = true;
                enemy1.Visible = false;
                enemy2.Visible = false;
                enemy3.Visible = false;
                coin1.Visible = false;
                coin2.Visible = false;
                coin3.Visible = false;
                car.Visible = false;
                gamespeed = 0;
            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                raceTimer.Enabled = false;
                over.Visible = true;
                button1.Visible = true;
                enemy1.Visible = false;
                enemy2.Visible = false;
                enemy3.Visible = false;
                coin1.Visible = false;
                coin2.Visible = false;
                coin3.Visible = false;
                car.Visible = false;
                gamespeed = 0;
            }
        }

        

        public void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collected_coin++;
                label1.Text = "Coins = " + collected_coin.ToString();
                x = r.Next(0, 100);
                coin1.Location = new Point(x, 0);
            }
            
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collected_coin++;
                label1.Text = "Coins = " + collected_coin.ToString();
                x = r.Next(0, 100);
                coin2.Location = new Point(x, 0);
            }
            
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collected_coin++;
                label1.Text = "Coins = " + collected_coin.ToString();
                x = r.Next(0, 100);
                coin3.Location = new Point(x, 0);
            }
            
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collected_coin++;
                label1.Text = "Coins = " + collected_coin.ToString();
                x = r.Next(0, 100);
                coin4.Location = new Point(x, 0);
            }
        }



        public int gamespeed = 1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enemy1_Click(object sender, EventArgs e)
        {

        }

        private void enemy3_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm f = new mainForm();
            this.Hide();
            f.Show();
        }

        private void enemy2_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left >0)
                    car.Left -= gamespeed;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 380)
                    car.Left += gamespeed;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (car.Top < 480)
                    car.Top -= gamespeed;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (car.Top < 480)
                    car.Top += gamespeed;
            }

            if (e.KeyCode == Keys.F1)
            {
                if (gamespeed < 21)
                    gamespeed++;
            }
            if (e.KeyCode == Keys.F2)
            {
                if (gamespeed != 0)
                    gamespeed --;
            }

        }
       
    }
}
