using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using System.Threading;
using System.Media;

namespace BitClick
{
    public partial class Form1 : Form
    {
        private SoundPlayer music;
        int points = 0;
        int speed = 0;
        int _50b = 0;
        int value = 1;
        public Form1()
        {
            InitializeComponent();
            music = new SoundPlayer("sound.wav");
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void Form1_Load(object sender, EventArgs e)
        {
            start.Hide();
            stop.Hide();
            textBox2.Text = this.Text;
            value2.Hide();
            ability2.Hide();
            buy2.Hide();
            value3.Hide();
            ability3.Hide();
            buy3.Hide();
            value4.Hide();
            ability4.Hide();
            buy4.Hide();
            bitcoin.Hide();
            tip.Hide();
            dogslave.Hide();
            description.Text = "Nothing Found";
            free.Hide();
            ability1.Hide();
            music.Play();
            music.PlayLooping();
            start.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            points += 1;
            tip.Hide();
            textBox1.Text = points.ToString() + " BITCOINS";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/bXDeRvB");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            points += value;
            textBox1.Text = points.ToString() + " BITCOINS";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value2.Show();
            ability2.Show();
            buy2.Show();
            value3.Show();
            ability3.Show();
            buy3.Show();
            value4.Show();
            ability4.Show();
            buy4.Show();
            bitcoin.Show();
            that.Hide();
            tip.Show();
            get1.Hide();
            description.Show();
            description.Text = "Nothing Found";
        }

        private void buy2_Click(object sender, EventArgs e)
        {
            if (points >= 50)
            {
                points -= 50;
                _50b += 1;
                timer1.Start();
                start.Show();
                stop.Show();
                dogslave.Show();
                buy2.Enabled = false;
            }
            else
            {
                MessageBox.Show("You dont have Money to Buy | Total Money To Buy: 50 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/bXDeRvB");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            start.Enabled = false;
            stop.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            start.Enabled = true;
            stop.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 400;
                mouseY = MousePosition.Y - 20;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void offlineModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bitcoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            points += 1;
            textBox1.Text = points.ToString() + " BITCOINS";
        }

        private void hide_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void buy3_Click(object sender, EventArgs e)
        {
            if (points >= 200)
            {
                points -= 200;
                _50b += 1;
                value += 9;
            }
            else
            {
                MessageBox.Show("You dont have Money to Upgrade | Total Money To Buy: 200", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bitclick_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void buy4_Click(object sender, EventArgs e)
        {
            if (points >= 500)
            {
                points -= 500;
                _50b += 1;
                value += 10;
            }
            else
            {
                MessageBox.Show("You dont have Money to Upgrade | Total Money To Buy: 500", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buy2_MouseEnter(object sender, EventArgs e)
        {
            photo.Image = Properties.Resources.doge;
            description.Text = "Mine For You | Total Money to Buy: 50";
        }

        private void buy2_MouseLeave(object sender, EventArgs e)
        {
            photo.Image = Properties.Resources.nothing;
            description.Text = "Nothing Found";
        }

        private void buy3_MouseEnter(object sender, EventArgs e)
        {
            photo.Image = Properties.Resources.upgrade;
            description.Text = "Upgrade to mine 10 bitcoins | Total Money to Buy: 200";
        }

        private void buy3_MouseLeave(object sender, EventArgs e)
        {
            photo.Image = Properties.Resources.nothing;
            description.Text = "Nothing Found";
        }

        private void buy4_MouseEnter(object sender, EventArgs e)
        {
            photo.Image = Properties.Resources.upgrade;
            description.Text = "Upgrade to mine 20 bitcoins | Total Money to Buy: 500";
        }

        private void get1_MouseEnter(object sender, EventArgs e)
        {
            photo.Image = Properties.Resources._59699_cryptocurrency_zazzle_payment_bitcoin_logo_free_hq_image;
            description.Text = "Start Game";
        }

        private void get1_MouseLeave(object sender, EventArgs e)
        {
            photo.Image = Properties.Resources.nothing;
            description.Text = "Nothing Found";
        }

        private void clicked_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(147, 188, 15);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(22, 22, 22);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Process.Start("Bitclick.exe");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                music.Stop();
                checkBox1.Text = "Mute";
            }
            else
            {
                music.Play();
                music.PlayLooping();
                checkBox1.Text = "Music";
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void resetMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            points = 0;
            textBox1.Text = points.ToString() + " BITCOINS";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buy4_MouseLeave(object sender, EventArgs e)
        {
            photo.Image = Properties.Resources.nothing;
            description.Text = "Nothing Found";
        }
    }
}