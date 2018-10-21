using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToegui
{
    public partial class Form1 : Form
    {
        private Player player1;
        private Player player2;
        public Form1()
        {
            InitializeComponent();
            Button[] mybutton = { button10,button2,button3,button4,button5,button6,button7,button8,button9 };
            foreach (Button button in mybutton)
            {
                button.Visible = false;
            }

            statuslabel.Visible = false;
            playernamelabel.Visible = false;
            
        }
       
        private void PlayGame(object sender)
        {
            Button button = sender as Button;
            if (playernamelabel.Text == player1.Name && button.Text == "")
            {
                player1.SetButton(button, statuslabel);
                ++Player.Counter;
                player1.CheckGameStatus(playbutton, button2, button3, button4,
            button5, button6, button7, button8, button9, button10, playernamelabel, statuslabel, player2);
            }
            else if (playernamelabel.Text == player2.Name && button.Text == "")
            {
                player2.SetButton(button, statuslabel);
                player2.CheckGameStatus(playbutton, button2, button3, button4,
            button5, button6, button7, button8, button9, button10, playernamelabel, statuslabel, player1);
            }
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) 
                && playbutton.Text == "PLAY")
            {
                if ((radioButton1.Checked || radioButton2.Checked)
                    && (radioButton3.Checked || radioButton4.Checked))
                {
                    panel1.Visible = false;
                    playernamelabel.Visible = true;
                    statuslabel.Visible = true;
                    

                    Button[] mybutton = { button10, button2, button3, button4, button5, button6, button7, button8, button9 };
                    foreach (Button button in mybutton)
                    {
                        button.Visible = true;
                    }

                    foreach (RadioButton x in panel2.Controls)
                    {
                        if (x.Checked)
                            player1 = new Player(textBox1.Text, x.Text);
                    }

                    foreach (RadioButton x in panel3.Controls)
                    {
                        if (x.Checked)
                            player2 = new Player(textBox2.Text, x.Text);
                    }
                    playernamelabel.Text = player1.Name;
                    statuslabel.Text = "TURN";
                    playbutton.Visible = false;
                }
               
            }
            else if (playbutton.Text == "PLAY AGAIN")
            {
                Player.Counter = 0;
                button10.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                playernamelabel.Text = player1.Name;
                statuslabel.Text = "TURN";
                playbutton.Visible = false;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            PlayGame(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayGame(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayGame(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayGame(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PlayGame(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PlayGame(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PlayGame(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PlayGame(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PlayGame(sender);
        }

    }
}
