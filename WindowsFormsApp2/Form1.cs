using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) pictureBox8.Top = pictureBox8.Top - 10;
            if (e.KeyCode == Keys.Down) pictureBox8.Top = pictureBox8.Top + 10;
            if (e.KeyCode == Keys.Left) pictureBox8.Left = pictureBox8.Left - 10;
            if (e.KeyCode == Keys.Right) pictureBox8.Left = pictureBox8.Left + 10;

            if (pictureBox8.Top < 0) pictureBox8.Top = 0;
            if (pictureBox8.Left < 0) pictureBox8.Left = 0;
            if (pictureBox8.Top > 335) pictureBox8.Top = 335;

            if (pictureBox2.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox3.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox4.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox5.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox6.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox7.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox9.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox10.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox11.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox12.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox13.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox14.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox15.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox16.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
            if (pictureBox17.Bounds.IntersectsWith(pictureBox8.Bounds)) pictureBox8.Left = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox15.Left = pictureBox15.Left + 5;
            pictureBox16.Top = pictureBox16.Top + 15;
            pictureBox17.Left = pictureBox17.Left + 10;

            if (pictureBox15.Left > 465) pictureBox15.Left = 350;
            if (pictureBox16.Top > 290) pictureBox16.Top = 135;
            if (pictureBox17.Left > 465) pictureBox17.Left = 100;
        }
    }
}
