using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        bool turn = true; //X = true; O = false;
        int turn_count = 0;
        static string player1, player2;

        public TicTacToe()
        {
            InitializeComponent();
        }

        public static void SetPlayerNames(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tre i rad spel, skapat av Jakob Bergbom Olsson. 02/17/2017","TicTacToe about");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;

            winnerCheck();
        }

        private void winnerCheck()
        {
            bool winner = false;
            turn_count++;
            //Horisontella
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;

            //Vertikala
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            //Diagonella
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                winner = true;

            if (winner)
            {
                disableButtons();
                string champ = "";

                if (turn)
                {
                    champ = player2;
                    oWinCount.Text = (int.Parse(oWinCount.Text) + 1).ToString();
                }
                else
                {
                    champ = player1;
                    xWinCount.Text = (int.Parse(xWinCount.Text) + 1).ToString();
                }
                MessageBox.Show(champ + " wins!","Victory!");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("No one wins!", "Draw!");
                    drawCount.Text = (int.Parse(drawCount.Text) + 1).ToString();
                }
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            
                foreach (Control c in Controls)
                {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
            
        }

        private void button_enter(object sender, EventArgs e)
        {

            try
            {
                Button b = (Button)sender;
                if (b.Enabled)
                {
                    if (turn)
                        b.Text = "X";
                    else
                        b.Text = "O";
                }
            }
            catch { }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetWinCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oWinCount.Text = "0";
            xWinCount.Text = "0";
            drawCount.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            label1.Text = player1;
            label3.Text = player2;
        }
    }
}
