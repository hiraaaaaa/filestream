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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tt = textBox1.Text + textBox2.Text;
            StreamReader sr = new StreamReader(tt);
            this.textBox3.Text = sr.ReadToEnd();
            sr.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "adress";
            this.label2.Text = "File Name";
            this.button1.Text = "Read";
            this.button2.Text = "FS Read";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fn = textBox1.Text + textBox2.Text;
            FileStream fs = new FileStream(fn, FileMode.Open);
            byte[] bb = new byte[100];
            Char[] ch = new char[100];
            fs.Read(bb, 0, 100);

            Decoder de = Encoding.UTF8.GetDecoder();
            de.GetChars(bb, 0, bb.Length, ch, 0);
            foreach (char c in ch)
            {
                this.textBox3.Text += c;
            }
        }
    }
}