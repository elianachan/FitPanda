using System;
using System.IO;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sw = new System.IO.StreamWriter("C:\\" + textBox1.Text + "\\login.IO");
                sw.Write(textBox1.Text + "\n" + textBox2.Text);
                sw.Close();
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                System.IO.Directory.CreateDirectory("C:\\" + textBox1.Text);
                var sw = new System.IO.StreamWriter("C:\\" + textBox1.Text + "\\login.IO");
                sw.Write(textBox1.Text + "\n" + textBox2.Text);
                sw.Close();
            }
            Hide();
            MessageBox.Show("You can log in NOW ! Thx !");
        }
    }
}
