using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitVariable();
        }

        private void InitVariable()
        {
            textBoxDisplay.Text = "Hi, Hello, Good, \r\nNext Line.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBinaryWriter_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));

            bw.Write(1234);

            bw.Close();
        }

        private void buttonBinaryReader_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));

            int num1 = br.ReadInt32();

            Console.WriteLine("Read int = " + num1);

            br.Close();
        }

        private void buttonStreamWriter_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));
            sw.Write("김개똥");
        }

        private void buttonStreamReader_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
            textBoxDisplay.Text = "";

            while (sr.EndOfStream == false)
            {
                textBoxDisplay.Text += sr.ReadLine();
                textBoxDisplay.Text += "\r\n";
            }
            sr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
