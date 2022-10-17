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
    
    public partial class JatekTer : Form
    {
        static int mapsize = 10;
        static int turn = 0;
        static string elsonev="";
        static string masodiknev = "";
        public static Label[,] labelek = new Label[10,10];
        public JatekTer()
        {
            
            this.Text = "JatekTer";
            this.MinimumSize = new Size(800, 550);
            this.MaximumSize = new Size(800, 550);
            this.Size=new Size(800, 550);
            generatemap(mapsize);
        }

        private void generatemap(int c)
        {
            
            int x = 200;
            int y = 80;
            int size = 35;
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Label newlabel = new Label();
                    newlabel.Location = new Point(x + i * 35, y + j * 35);
                    newlabel.Width = size;
                    newlabel.Height = size;
                    newlabel.BackColor = Color.Gray;
                    newlabel.BorderStyle = BorderStyle.FixedSingle;
                    newlabel.Name = i + "_" + j;
                    newlabel.Text = "X";
                    this.Controls.Add(newlabel);
                    labelek[i, j] = newlabel;
                }
            }
        }

        public void playernames(string player1_name, string player2_name)
        {
            elsonev= player1_name;
            masodiknev = player2_name;
        }
    }
}
