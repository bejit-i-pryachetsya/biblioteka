
using date_lib;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
          
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            // ����� ������� ����� ������ � �������������

           

            TimeSpan difference = Class1.GetDateDifference(startDate, endDate);
          
            label1.Text = $"������� �� �������: {difference.TotalHours} �����";

            //��������, �������� �� ��� ����������

            bool bo = true;
            if (textBox1.TextLength != 4 )
            {
                MessageBox.Show("������� ���������� ���!", "������");
                bo = false;
            }
            else if (bo == true)
            {
                try
                {
                    int year = Convert.ToInt32(textBox1.Text);
                    bool isLeapYear = Class1.IsLeapYear(year);
                    label3.Text = isLeapYear ? "��� ����������" : "��� �� ����������";
                }
                catch
                {
                    MessageBox.Show("������� ���������� ���!", "������!");
                }
            }
            else
            {
                MessageBox.Show(":(", "������!");
            }
            
           
             

            // ����� ������� ����� �� ��������� �������
            DateTime time = dateTimePicker3.Value;
            string timeOfDay = Class1.GetTimeOfDay(time);
            label2.Text = $"����� �����: {timeOfDay}";

            // �������������� ���� � �������
            if (radioButton1.Checked)
            {
                string formattedDateTime = Class1.FormatDateTime(DateTime.Now, "F");
                label4.Text = $"��������������� �����: {formattedDateTime}";
            }
            else if (radioButton2.Checked)
            {
                string formattedDateTime = Class1.FormatDateTime(DateTime.Now, "g");
                label4.Text = $"��������������� �����: {formattedDateTime}";
            }
            else if(radioButton3.Checked)
            {
                string formattedDateTime = Class1.FormatDateTime(DateTime.Now, "G");
                label4.Text = $"��������������� �����: {formattedDateTime}";
            }
            else if(radioButton4.Checked)
            {
                string formattedDateTime = Class1.FormatDateTime(DateTime.Now, "f");
                label4.Text = $"��������������� �����: {formattedDateTime}";
            }
            else
            {
                string formattedDateTime = Class1.FormatDateTime(DateTime.Now, "F");
                label4.Text = $"��������������� �����: {formattedDateTime}";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}