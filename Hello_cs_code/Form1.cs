using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Hello_cs_code
{
    public partial class Form1 : Form
    {
        string my_var2;
        long my_var;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello This Is My First C# Code and I am Really Happy!!!!");
            MessageBox.Show("2 Line");
            MessageBox.Show("3 Line");
            MessageBox.Show("4 Line");
            MessageBox.Show("5 Line");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am Button 2!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am Button 3", "Hello!") ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
            //This line changes the color of my button 2
            button2.BackColor = Color.Green;
            this.BackColor = Color.Red;
            //THis
             button4.ForeColor = Color.Red;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "I'm  Beautiful Textbox ";
            this.button3.Text = "Hi Babe!";
            this.Text = "Hi I Love You; Me too!!!!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox2.Text=  DateTime.Now.ToString();
            // this.textBox2.Text = DateTime.Now.DayOfYear.ToString();
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
            //this.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox2.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //this.textBox3.Text = DateTime.Now.ToString();
            this.textBox3.Text = DateTime.Now.Hour.ToString() +":"+  DateTime.Now.Minute.ToString() +":" +DateTime.Now.Second.ToString() +":"+DateTime.Now.Millisecond.ToString() ;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Do you want to delete?","Finish",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2,MessageBoxOptions.DefaultDesktopOnly);
            //MessageBox.Show("Done!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
           // this.pictureBox1.Image = Image.FromFile("E:\\cs\\Koala.jpg");
            this.pictureBox1.BackgroundImage = Image.FromFile("E:\\cs\\Koala.jpg");

            this.BackgroundImage= Image.FromFile("E:\\cs\\Koala.jpg");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string msg=this.textBox4.Text ;
            //msg =this.textBox4.Text ;
            MessageBox.Show("Hi : "+  msg );
            MessageBox.Show("Hi : " + msg+" Wellcome Back");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ////string a1;
            ////string a2;
            ////a1 = this.textBox5.Text;
            ////a2 = this.textBox6.Text;
            ///
            int a1;
            int a2;
            //a1 =Convert.ToInt32(  this.textBox5.Text);
            //a2 =Convert.ToInt32( this.textBox6.Text);
            Int32.TryParse(this.textBox5.Text, out a1);
            int.TryParse(this.textBox6.Text, out a2);
            int a3;
            a3 = a1 + a2;

            MessageBox.Show( a3.ToString()  );
        }

      
        private void button15_Click(object sender, EventArgs e)
        {
            long a1;
            long a2;
           
            //a1 =Convert.ToInt32(  this.textBox5.Text);
            //a2 =Convert.ToInt32( this.textBox6.Text);
            long.TryParse(this.textBox5.Text, out a1);
            long.TryParse(this.textBox6.Text, out a2);
            long a3;
            a3 = a1 + a2;
            
            MessageBox.Show(a3.ToString());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double a1;
            double a2;
            //a1 =Convert.ToInt32(  this.textBox5.Text);
            //a2 =Convert.ToInt32( this.textBox6.Text);
            double.TryParse(this.textBox5.Text, out a1);
            double.TryParse(this.textBox6.Text, out a2);
            double a3;
            a3 = a1 + a2;

            MessageBox.Show(a3.ToString());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            float a1;
            float a2;
            //a1 =Convert.ToInt32(  this.textBox5.Text);
            //a2 =Convert.ToInt32( this.textBox6.Text);
            float.TryParse(this.textBox5.Text, out a1);
            float.TryParse(this.textBox6.Text, out a2);
            float a3;
            a3 = a1 + a2;
          
            MessageBox.Show(a3.ToString());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            decimal a1;
            decimal a2;
            //a1 =Convert.ToInt32(  this.textBox5.Text);
            //a2 =Convert.ToInt32( this.textBox6.Text);
            decimal.TryParse(this.textBox5.Text, out a1);
            decimal.TryParse(this.textBox6.Text, out a2);
            decimal a3;
            a3 = a1 + a2;

            MessageBox.Show(a3.ToString());
        }

        private void button19_Click(object sender, EventArgs e)

        {
            string p;
            // p = "C:\\Windows\\System32\\calc.exe";
            p = this.textBox7.Text;
            this.process1.StartInfo.FileName =p ;
            this.process1.Start();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\notepad.exe";
            this.process1.Start();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\mspaint.exe";
            this.process1.Start();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "E:\\Program Files (x86)\\Oranus Soft\\Automation.2018.1.April\\oranus_pro.exe";
            this.process1.Start();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Nice Time!");
            this.Close();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Int32 uyb;

            Int32.TryParse(this.textBox8.Text, out uyb);

            Int32 age;
            Int32 curr_year;
            curr_year = DateTime.Now.Year;
            age = curr_year - uyb;
            // MessageBox.Show(age.ToString());

            if (age > 35)
            {
                MessageBox.Show("You are middle aged!!!");
            }
            if (age<35)
            {
                MessageBox.Show("You are young! don't afraid!!!");
            }
            if (age==35)
            {
                MessageBox.Show("I don't know who you are!!!!!!!!");
            }
            //else
            //{
            //    MessageBox.Show("You are young! don't afraid!!!");
            //}
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Int32 i;
            for (i=0;i<20;i++)
            {
                MessageBox.Show("I am for loop: my number is: " + i.ToString());
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Int32 j;
            for (j=0;j<1000;j++)
            {
                this.comboBox1.Items.Add(j.ToString());
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Int32 mn;
            Int32.TryParse(this.textBox9.Text, out mn);
            string en_mon_name;
            en_mon_name = "unknown";
            if (mn==1)
            {
                // MessageBox.Show("January");
                en_mon_name= "January";
            }
            if (mn == 2)
            {
                // MessageBox.Show("February");
                en_mon_name = "February";
            }
            if (mn == 3)
            {
                //MessageBox.Show("March");
                en_mon_name = "March";
            }
            if (mn == 4)
            {
                //MessageBox.Show("April");
                en_mon_name = "April";
            }
            if (mn == 5)
            {
                //MessageBox.Show("May");
                en_mon_name = "May";
            }
            if (mn == 6)
            {
                // MessageBox.Show("June");
                en_mon_name = "June";
            }
            if (mn == 7)
            {
                // MessageBox.Show("July");
                en_mon_name = "July";
            }
            if (mn == 8)
            {
                // MessageBox.Show("August");
                en_mon_name = "August";
            }
            if (mn == 9)
            {
                // MessageBox.Show("September");
                en_mon_name = "September";
            }
            if (mn == 10)
            {
                // MessageBox.Show("October");
                en_mon_name = "October";
            }
            if (mn == 11)
            {
                //MessageBox.Show("November");
                en_mon_name = "November";
            }
            if (mn == 12)
            {
                //MessageBox.Show("December");
                en_mon_name = "December";
            }

            MessageBox.Show(en_mon_name);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Int32 mn;
            Int32.TryParse(this.textBox9.Text, out mn);
            string en_name;
            en_name = "unknows";

            switch (mn)
            {
                case 1:
                    en_name = "January";
                    break;

                case 2:
                    en_name = "February";
                    break;

                case 3:
                    en_name = "March";
                    break;

                case 4:
                    en_name = "April";
                    break;

                case 5:
                    en_name = "May";
                    break;

                case 6:
                    en_name = "June";
                    break;

                case 7:
                    en_name = "July";
                    break;

                case 8:
                    en_name = "August";
                    break;

                case 9:
                    en_name = "September";
                    break;

                case 10:
                    en_name = "October";
                    break;

                case 11:
                    en_name = "November";
                    break;

                case 12:
                    en_name = "December";
                    break;

                default:
                    en_name = "Wrong Number";
                    break;
            }
            MessageBox.Show(en_name);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            string m_name;
            m_name = this.textBox10.Text;
            string month_num;

            switch (m_name)
            {
                case "January":
                    month_num = "1";
                    break;

                case "February":
                    month_num = "2";
                    break;

                case "March":
                    month_num = "3";
                    break;


                case "April":
                    month_num = "4";
                    break;


                case "May":
                    month_num = "5";
                    break;

                case "June":
                    month_num = "6";
                    break;

                case "July":
                    month_num = "7";
                    break;

                case "August":
                    month_num = "8";
                    break;

                case "September":
                    month_num = "9";
                    break;

                case "October":
                    month_num = "10";
                    break;

                case "November":
                    month_num = "11";
                    break;

                case "December":
                    month_num = "12";
                    break;

                default:
                    month_num = "Not Valid!";
                    break;
            }

            MessageBox.Show("Your Month Number Is: " + month_num);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Boolean b;
            b = this.button18.Enabled;
            MessageBox.Show(b.ToString());
            this.button13.Enabled = b;
           // this.Visible = b;
        }
    }
}
