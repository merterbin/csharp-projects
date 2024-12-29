using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafızaOyunu
{    
    public partial class Form1 : Form
    {
        List<string> icons = new List<string>()
        {
        "w", "e", "t", "Y", "ö", "S", "N", "G","l","T","Z","M","E","s","-","ü",",","J","!","%",
        "w", "e", "t", "Y", "ö", "S", "N", "G","l","T","Z","M","E","s","-","ü",",","J","!","%",
        };
        bool playerOne = true;
        int p1score = 0;
        bool playerTwo = false;
        int p2score = 0;
        Random random = new Random();
        int randomIndex;
        Timer showTimer = new Timer();
        Timer countTimer = new Timer();
        Timer returnTimer = new Timer();
        Timer checkWinner = new Timer();
        Button firstSelectedButton;
        Button secondSelectedButton;

        public Form1()  
        {            
            InitializeComponent();
            addImage();
            showTimer.Tick += ShowTimer_Tick;
            showTimer.Start();
            showTimer.Interval = 5000;
            checkWinner.Tick += CheckWinner_Tick;
            checkWinner.Start();
            checkWinner.Interval = 1000;
            returnTimer.Tick += ReturnTimer_Tick;
            countTimer.Tick += CountTimer_Tick;
            P1Score.Text = "Puan: " + p1score.ToString();
            P2Score.Text = "Puan: " + p2score.ToString();            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            winnerLbl.Visible = false;
            winnerLbl.BackColor = Color.Transparent;            
        }
        private void Buton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (firstSelectedButton == null)
            {
                firstSelectedButton = btn;
                countTimer.Start();
                countTimer.Interval = 5000;
                btn.ForeColor = Color.Purple;
                return;
            }
            else if (secondSelectedButton == null && !(firstSelectedButton == null))
            {
                secondSelectedButton = btn;
                btn.ForeColor = Color.Purple;
            }
            if (firstSelectedButton.Text == secondSelectedButton.Text)
            {
                if (playerOne && !playerTwo) 
                { 
                    p1score++;
                    P1Score.Text ="Puan: " +  p1score.ToString();
                }
                else
                {
                    p2score++;
                    P2Score.Text = "Puan: " + p2score.ToString();
                }                
                correctAnswer();
                countTimer.Stop();
            }
            else if (firstSelectedButton.Text != secondSelectedButton.Text)
            {
                if (playerOne)
                {
                    playerOne = false;
                    playerTwo = true;
                }
                else
                {
                    playerOne = true;
                    playerTwo = false;
                }
                returnTimer.Start();
                returnTimer.Interval = 1000;
                countTimer.Stop();
            }            
        }
        private void isWinner() 
        {
            if (p1score > 10)
            {
                winnerLbl.Text = "Oyun Bitti 1. Oyuncu Kazandı";
                winnerLbl.Visible = true;
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        item.Click -= Buton_Click;
                        item.ForeColor = Color.Purple;
                    }
                }

            }
            if (p2score > 10)
            {
                winnerLbl.Text = "Oyun Bitti " + "2. Oyuncu Kazandı";
                winnerLbl.Visible = true;
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        item.Click -= Buton_Click;
                        item.ForeColor = Color.Purple;
                    }
                }
            }
            else if (p1score == 10 && p2score == 10)
            {
                winnerLbl.ForeColor = Color.Black;
                winnerLbl.Text = "Oyun Bitti "+ " Durum Berabere";
                winnerLbl.Visible = true;
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        item.ForeColor = Color.Purple;
                        item.Enabled = false;
                    }
                }
            }
        }
        private void correctAnswer()
        {
            firstSelectedButton.ForeColor = Color.Purple;
            secondSelectedButton.ForeColor = Color.Purple;
            firstSelectedButton = null;
            secondSelectedButton = null;
        }
        private void whoPlay()
        {
            if (playerOne && !playerTwo)
            {
                Player1.ForeColor = Color.Green;
                Player2.ForeColor = Color.Black;
            }
            else
            {
                Player2.ForeColor = Color.Green;
                Player1.ForeColor = Color.Black;
            }
        }
        private void addImage()
        {
            Button btn;
            foreach (Control items in this.Controls)
            {
                if (items is Button)
                {
                    btn = items as Button;
                    randomIndex = random.Next(icons.Count);
                    btn.Text = icons[randomIndex];
                    btn.ForeColor = Color.Purple;
                    icons.RemoveAt(randomIndex);
                }
            }
        }
        private void CheckWinner_Tick(object sender, EventArgs e)
        {
            isWinner();
            whoPlay();
        }
        private void CountTimer_Tick(object sender, EventArgs e)
        {
            countTimer.Stop();
            firstSelectedButton.ForeColor = firstSelectedButton.BackColor;
            firstSelectedButton = null;       
            if (playerOne) {                 
                playerOne = false;
                playerTwo = true;
            }
            else
            {
                playerOne = true;
                playerTwo = false;
            }
        }
        private void ReturnTimer_Tick(object sender, EventArgs e)
        {
            returnTimer.Stop();
            firstSelectedButton.ForeColor = firstSelectedButton.BackColor;
            secondSelectedButton.ForeColor = secondSelectedButton.BackColor;
            firstSelectedButton = null;
            secondSelectedButton = null;
        }
        private void ShowTimer_Tick(object sender, EventArgs e)
        {
            showTimer.Stop();
            foreach(Control item in Controls)
            {
                if(item is Button)
                    item.ForeColor = item.BackColor;
            }
        }
        private void Player1_Click(object sender, EventArgs e)
        {

        }
    }
}
