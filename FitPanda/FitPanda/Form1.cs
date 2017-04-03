using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitPanda
{
    public partial class Form1 : Form
    {
        public string username, password;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var sr = new System.IO.StreamReader("C:\\" + textBox1.Text + "\\login.IO");
                username = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();

                if (username == textBox1.Text && password == textBox2.Text)
                {
                    MessageBox.Show("Logged in !");
                    Form3 form3 = new Form3();
                    form3.Show();
                }
                else
                    MessageBox.Show("Username or password is not found !");
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show("The user doesn t exist ", "Error!");
            }
        }
    }
}
