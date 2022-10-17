using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string player1_name="";
            string player2_name = "";
            if (player1_text.Text.Length==0)
            {
                player1_name = "Player 1";
            }
            else
            {
                player1_name = player1_text.Text;
            }
            if (player2_text.Text.Length == 0)
            {
                player2_name = "Player 2";
            }
            else
            {
                player2_name = player2_text.Text;
            }


            JatekTer uj = new JatekTer();
            uj.playernames(player1_name,player2_name);
            this.Hide();
            uj.Show();
        }
    }
}
