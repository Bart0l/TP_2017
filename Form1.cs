using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {


        private bool pietro1Clicked = false;
        private bool pietro2Clicked = false;
        private bool pietro3Clicked = false;
        private bool pietro4Clicked = false;
        private bool pietro5Clicked = false;

        private int wysokosc = 0;
        private int waga = 0;
        private string ilosc;
        private string ilosc_Waga;
        private int i = 0;


        Stack<int> pasazerowie = new Stack<int>();

        public Form1()
        {

            

            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wysokosc = 5;
            pietro5Clicked = true;
            timer1_Tick(sender, e);
            // winda.Location = new Point(328, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            wysokosc = 98;
            pietro4Clicked = true;
            timer1_Tick(sender, e);
            //winda.Location = new Point(328, 98);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wysokosc = 193;
            pietro3Clicked = true;
            timer1_Tick(sender, e);
            //winda.Location = new Point(328, 193);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wysokosc = 288;
            pietro2Clicked = true;
            timer1_Tick(sender, e);
            //  winda.Location = new Point(328,288);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wysokosc = 380;
            pietro1Clicked = true;
            timer1_Tick(sender, e);
            
           // winda.Location = new Point(328, 380);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            winda.Location = new Point(328, 380);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            winda.Location = new Point(328, 288);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            winda.Location = new Point(328, 193);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            winda.Location = new Point(328, 98);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            winda.Location = new Point(328, 5);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_3(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
           
                pictureBox3.Location = new Point((winda.Location.X + 5), winda.Location.Y + 10);
                pictureBox3.Visible = true;
            
            
            waga = waga + 70;
            if (waga >= 600)
            {
                MessageBox.Show("Winda nie pomieści już więcej osób!");
                button11.Enabled = false;


                ilosc = Convert.ToString(i);
                label8.ForeColor = System.Drawing.Color.Black;
                label8.Text = ilosc;
                ilosc_Waga = Convert.ToString(waga-70);
                label7.Text = ilosc_Waga;
            }
            else
            {
                i++;
                pasazerowie.Push(i);


                if (i == 8)
                    label8.ForeColor = System.Drawing.Color.Red;
                ilosc = Convert.ToString(i);
                label8.Text = ilosc;
                ilosc_Waga = Convert.ToString(waga);
                label7.Text = ilosc_Waga;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (pietro1Clicked)
            {
                timer1.Start();
                if (winda.Location.Y < wysokosc)
                {
                    if(pictureBox3.Location.X == winda.Location.X+5)
                    pictureBox3.Location = new Point(winda.Location.X + 5, winda.Location.Y + 10);
                    winda.Location = new Point(winda.Location.X, winda.Location.Y + 1);
                }
                else
                {
                    if (pictureBox3.Location.X == winda.Location.X + 5)
                        pictureBox3.Location = new Point(winda.Location.X + 5, winda.Location.Y + 10);
                    winda.Location = new Point(winda.Location.X, winda.Location.Y - 1);
                }
                if (winda.Location.Y == wysokosc)
                {
                    timer1.Enabled = false;
                }
             
            }
            if (pietro2Clicked)
            {
                timer1.Start();
                if (winda.Location.Y < wysokosc)
                {
                    if (pictureBox3.Location.X == winda.Location.X + 5)
                        pictureBox3.Location = new Point(winda.Location.X + 5, winda.Location.Y + 10);
                    winda.Location = new Point(winda.Location.X, winda.Location.Y + 1);
                }
                else
                {
                    if (pictureBox3.Location.X == winda.Location.X + 5)
                        pictureBox3.Location = new Point(winda.Location.X + 5, winda.Location.Y + 10);
                    winda.Location = new Point(winda.Location.X, winda.Location.Y - 1);
                }
                if (winda.Location.Y == wysokosc)
                {
                    timer1.Enabled = false;
                }

            }
            if (pietro3Clicked)
            {
                timer1.Start();
                if (winda.Location.Y < wysokosc)
                {
                    if (pictureBox3.Location.X == winda.Location.X + 5)
                        pictureBox3.Location = new Point(winda.Location.X + 5, winda.Location.Y + 10);
                    winda.Location = new Point(winda.Location.X, winda.Location.Y + 1);
                }
                else
                {
                    if (pictureBox3.Location.X == winda.Location.X + 5)
                        pictureBox3.Location = new Point(winda.Location.X + 5, winda.Location.Y + 10);
                    winda.Location = new Point(winda.Location.X, winda.Location.Y - 1);
                }
                if (winda.Location.Y == wysokosc)
                {
                    timer1.Enabled = false;
                }

            }
            if (pietro4Clicked)
            {
                timer1.Start();
                if (winda.Location.Y < wysokosc)
                {
                    if (pictureBox3.Location.X == winda.Location.X + 5)
                        pictureBox3.Location = new Point(winda.Location.X + 5, winda.Location.Y + 10);
                    winda.Location = new Point(winda.Location.X, winda.Location.Y + 1);
                }
                else
                {
                    if (pictureBox3.Location.X == winda.Location.X + 5)
                        pictureBox3.Location = new Point(winda.Location.X + 5, winda.Location.Y + 10);
                    winda.Location = new Point(winda.Location.X, winda.Location.Y - 1);
                }
                if (winda.Location.Y == wysokosc)
                {
                   
                    timer1.Enabled = false;
                }

            }
            if (pietro5Clicked)
            {
                timer1.Start();
                if (winda.Location.Y < wysokosc)
                {
                    winda.Location = new Point(winda.Location.X, winda.Location.Y + 1);
                    if (pictureBox3.Location.X == winda.Location.X + 5)
                        pictureBox3.Location = new Point(winda.Location.X+5, winda.Location.Y + 10);
                }
                else
                {
                    if (pictureBox3.Location.X == winda.Location.X + 5)
                        pictureBox3.Location = new Point(winda.Location.X+5, winda.Location.Y + 10);
                    winda.Location = new Point(winda.Location.X, winda.Location.Y - 1);
                }
                if (winda.Location.Y == wysokosc)
                {
                    timer1.Enabled = false;
                }

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(winda.Location.X - 50, winda.Location.Y+10);
            pasazerowie.Pop();
            i = pasazerowie.Count();
            ilosc = Convert.ToString(i);
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Text = ilosc;
            ilosc_Waga = Convert.ToString(waga - (waga-(i*70)));
            label7.Text = ilosc_Waga;
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
