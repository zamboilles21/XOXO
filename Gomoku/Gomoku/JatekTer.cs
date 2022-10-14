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
        public static List<Label> labelek = new List<Label>();
        public JatekTer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < labelek.Count() ; i++)
            {
                for (int j = 0; j < labelek.Count; j++)
                {

                }
            }
        }
    }
}
