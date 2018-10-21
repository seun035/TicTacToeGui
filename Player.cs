using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToegui
{
    class Player
    {
        public string Name { get; set; }

        public string Marker { get; set; }

        public static int Counter { get; set; }

        public void SetButton (Button button, Label label)
        {
            if (label.Text != "WIN")
            {
                button.Text = Marker;
            }
        }

        public void CheckGameStatus(Button playbutton, Button button2, Button button3,Button button4,
           Button button5,Button button6,Button button7,Button button8,Button button9,Button button10,Label playernamelabel,
           Label statuslabel, Player player)
        {
            if (button10.Text == Marker && button2.Text == Marker && button3.Text == Marker ||
                button4.Text == Marker && button5.Text == Marker && button6.Text == Marker ||
                button7.Text == Marker && button8.Text == Marker && button9.Text == Marker ||
                button10.Text == Marker && button4.Text == Marker && button7.Text == Marker ||
                button2.Text == Marker && button5.Text == Marker && button8.Text == Marker ||
                button3.Text == Marker && button6.Text == Marker && button9.Text == Marker ||
                button10.Text == Marker && button5.Text == Marker && button9.Text == Marker ||
                button3.Text == Marker && button5.Text == Marker && button7.Text == Marker)
            {
                statuslabel.Text = "WINS!";
                playbutton.Text = "PLAY AGAIN";
                playbutton.Visible = true;
            }

            else if (Counter == 5)
            {
                playernamelabel.Text = "GAME";
                statuslabel.Text = "DRAW";
                playbutton.Text = "PLAY AGAIN";
                playbutton.Visible = true;
            }
            else
            {
                if (playernamelabel.Text == Name)
                    playernamelabel.Text = player.Name;
                else
                    playernamelabel.Text = Name;
            }
        }

        public Player(string name, string marker)
        {
            Name = name;
            Marker = marker;

        }
    }
}
