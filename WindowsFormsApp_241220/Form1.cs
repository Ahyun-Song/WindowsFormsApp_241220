using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_241220
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int StudentCount;
                if (int.TryParse(textBox_input.Text, out StudentCount))
                {
                    string[] results = GenerateStudentScores(StudentCount);

                    textBox_result.Text = string.Join(Environment.NewLine, results);
                }
            }
            
           // e.SuppressKeyPress = true;
        }
        public string[] GenerateStudentScores(int count)
        {
            Random random = new Random();
            string[] StudentScores = new string[count];

            for (int i = 0; i < count; i++)
            {
                int score = random.Next(0, 101);
                StudentScores[i] = $"학생{i + 1}의 점수 : {score}점";
            }
            return StudentScores;
        }
       
    }
    
}
