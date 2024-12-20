﻿using System;
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
    public partial class Form3 : Form
    {

        private int UserScore = 0;
        private int ComputerScore = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button_rock_Click(object sender, EventArgs e)
        {
            PlayGame("Rock");
        }

        private void button_scissors_Click(object sender, EventArgs e)
        {
            PlayGame("Scissors");
        }

        private void button_paper_Click(object sender, EventArgs e)
        {
            PlayGame("Paper");
        }

        private void PlayGame(string UserChoice)
        {
            Random random = new Random();
            string[] choices = { "Rock", "Scissors", "Paper" };
            string ComputerChoice = choices[random.Next(0,3)];

            string result = GetGameResult(UserChoice, ComputerChoice);

            textBox_result.AppendText($"User : {UserChoice} | Computer : {ComputerChoice}\r\n");
            textBox_result.AppendText($"Result : {result}\r\n\r\n");

            if (result == "User Wins")
            {
                UserScore++;
            }
            else if(result == "Computer Wins")
            {
                ComputerScore++;
            }

            textBox_result.AppendText($"User Score : {UserScore} | Computer Score : {ComputerScore}\r\n\r\n");

            if (UserScore == 3)
            {
                textBox_result.AppendText("User Wins the Game");
                ResetGame();
            }
            else if (ComputerScore == 3)
            {
                textBox_result.AppendText("Computer Wins the Game");
                ResetGame();
            }


        }

        private string GetGameResult(string UserChoice, string ComputerChoice)
        {
            if(UserChoice == ComputerChoice)
            {
                return "Draw";
            }

            if ((UserChoice == "Rock" && ComputerChoice == "Scissors") || (UserChoice == "Scissors" && ComputerChoice == "Paper") || (UserChoice == "Paper" && ComputerChoice == "Rock"))
            {
                return "User Wins";
            }
            else
            {
                return "Computer Wins";
            }

        }

        private void ResetGame()
        {
            UserScore = 0;
            ComputerScore = 0;
        }

    }
}
