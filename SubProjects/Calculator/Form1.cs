using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int result;
        public Form1()
        {
            InitializeComponent();

            InitVariables();
        }

        public void InitVariables()
        {
            comboBoxComboCalc_Operator.Items.Clear();
            comboBoxComboCalc_Operator.Items.Add("+");
            comboBoxComboCalc_Operator.Items.Add("-");
            comboBoxComboCalc_Operator.Items.Add("*");
            comboBoxComboCalc_Operator.Items.Add("/");

            comboBoxComboCalc_Operator.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxComboCalc_Operator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // oper1 변수에 Operand1의 값, oper2 변수에 Operand2의 값, oper3 변수에 Result의 값 문자열 형식으로 저장
            String oper1 = textBoxComboCalc_Oper1.Text;
            String oper2 = textBoxComboCalc_Oper2.Text;
            String oper3 = textBoxComboCalc_Result.Text;

            switch (comboBoxComboCalc_Operator.SelectedIndex)
            {
                // 문자열 형식을 정수형으로 변환하여 result에 넣고 다시 문자열로 바꾸어 Result에 출력
                case 0: // +일 경우
                    result = int.Parse(oper1) + int.Parse(oper2);
                    oper3 = result.ToString();
                    textBoxComboCalc_Result.Text = oper3;
                    break;
                case 1: // -일 경우
                    result = int.Parse(oper1) - int.Parse(oper2);
                    oper3 = result.ToString();
                    textBoxComboCalc_Result.Text = oper3;
                    break;
                case 2: // *일 경우
                    result = int.Parse(oper1) * int.Parse(oper2);
                    oper3 = result.ToString();
                    textBoxComboCalc_Result.Text = oper3;
                    break;
                case 3: // /일 경우
                    result = int.Parse(oper1) / int.Parse(oper2);
                    oper3 = result.ToString();
                    textBoxComboCalc_Result.Text = oper3;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 문자열 형식을 정수형으로 변환하여 result에 넣고 다시 문자열로 바꾸어 Result에 출력
            String oper1 = textBoxRadioCalc_Oper1.Text;
            String oper2 = textBoxRadioCalc_Oper2.Text;
            String oper3 = textBoxRadioCalc_Result.Text;
            

            if (plusbutton.Checked == true) // plusbutton이 체크 되어있다면
            {
                // 문자열 형식을 정수형으로 변환하여 result에 넣고 다시 문자열로 바꾸어 Result에 출력
                result = int.Parse(oper1) + int.Parse(oper2);
                oper3 = result.ToString();
                textBoxRadioCalc_Result.Text = oper3;
            }
            else if (minusbutton.Checked == true) // minusbutton이 체크 되어있다면
                result = int.Parse(oper1) - int.Parse(oper2);
                oper3 = result.ToString();
                textBoxRadioCalc_Result.Text = oper3;
        }
    }
}
