using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication27
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mm = textBox2.Text + textBox3.Text;
            StreamWriter sw = new StreamWriter(mm);
            sw.Write(this.textBox1.Text);
            MessageBox.Show("hoagya bhaiii jan chor");
            sw.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text = "adress";
            this.label2.Text = "File Name";
            this.button1.Text = "Writer";
            this.button2.Text = "FS Write";
        }

        private void button2_Click(object sender, EventArgs e)
        {
              string fn = textBox1.Text + textBox2.Text;
              FileStream fs = new FileStream(fn,FileMode.Append);
            byte[] bb = new byte[100];
            Char[] ch = new char[100];

            ch = textBox1.Text.ToCharArray();
            Encoder en = Encoding.UTF8.GetEncoder();
            en.GetBytes(ch, 0, ch.Length, bb, 0, true);
            fs.Write(bb, 0, bb.Length);
            MessageBox.Show("  File Has Written");
            fs.Close();
   

        }
    }
}
