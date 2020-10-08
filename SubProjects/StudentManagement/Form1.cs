using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        private string FILE_NAME = "stu.dat";

        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            comboBoxStudent1Gender.Items.Clear();
            comboBoxStudent1Gender.Items.Add("남자");
            comboBoxStudent1Gender.Items.Add("여자");

            string[] genderData = { "남자", "여자" };
            comboBoxStudent2Gender.Items.AddRange(genderData);
            comboBoxStudent3Gender.Items.AddRange(genderData);

            comboBoxStudent1Gender.SelectedIndex = 0;
            comboBoxStudent2Gender.SelectedIndex = 0;
            comboBoxStudent3Gender.SelectedIndex = 0;

        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }



        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            
        }
        #region Student 1 Event handlers
        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void comboBoxStudent1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void textBoxStudent1Name_TextChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void textBoxStudent1Id_TextChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }
        #endregion

        private void LoadStudent()
        {

            using (BinaryWriter bw = new BinaryWriter(File.Open(FILE_NAME, FileMode.Create)))
            {

                bw.Write(textBoxStudent1Name.Text);
                bw.Write(textBoxStudent1Id.Text);
                bw.Write(comboBoxStudent1Gender.Text);

                bw.Write(textBoxStudent2Name.Text);
                bw.Write(textBoxStudent2Id.Text);
                bw.Write(comboBoxStudent2Gender.Text);

                bw.Write(textBoxStudent3Name.Text);
                bw.Write(textBoxStudent3Id.Text);
                bw.Write(comboBoxStudent3Gender.Text);
            }
        }
        private void SaveStudent()
        {
            string name;
            int id;
            string gender;

            if (File.Exists(FILE_NAME))
            {
                using (BinaryReader br = new BinaryReader(File.Open(FILE_NAME, FileMode.Open)))
                {
                    name = br.ReadString();
                    id = br.ReadInt32();
                    gender = br.ReadString();
                }
            }
        }
    }
}
