using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kokszos
{
    public partial class jatekter : Form
    {
        static string player1_name;
        static string player2_name;
        static bool xSzel = false;
        static bool ySzel = false;
        static int turn = 0;
        static int size =10;
        public static Label[,] labelek = new Label[size, size];
        public jatekter()
        {
            InitializeComponent();
        }

        private void jatekter_Load(object sender, EventArgs e)
        {
            player jatekos = new player(player1_name, player2_name);
            player_1_name.Text = jatekos.player1;
            player_2_name.Text = jatekos.player2;
            generatemap();
            whoiswho();
            whosturn();



        }

        private void whosturn()
        {
            if (turn==0)
            {
                player1_turn.Image=Properties.Resources.arrow_left;
            }
            else
            {
                player2_turn.Image = Properties.Resources.arrow;
            }
            
        }

        private void whoiswho()
        {
            Random velet = new Random();
            int decide = velet.Next(0, 101);
            if (decide>50)
            {
                MessageBox.Show(player1_name + " kezd");
                imgbox_player_1.Image = Properties.Resources.X;
                imgbox_player_2.Image = Properties.Resources.circle;
                turn = 0;
            }
            else
            {

                MessageBox.Show(player2_name + " kezd");
                imgbox_player_2.Image = Properties.Resources.X;
                imgbox_player_1.Image = Properties.Resources.circle;
                turn = 1;
            }
        }

        private void generatemap()
        {
            Font LargeFont = new Font("Arial", 16);
            int x = 220;
            int y = 55;
            int square = 35;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Label newlabel = new Label();
                    newlabel.Location = new Point(x + i * 35, y + j * 35);
                    newlabel.Width = square;
                    newlabel.Height = square;
                    newlabel.BackColor = Color.Gray;
                    newlabel.BorderStyle = BorderStyle.FixedSingle;
                    newlabel.Name = i + "_" + j;
                    newlabel.Text = "";
                    newlabel.AutoSize = false;
                    newlabel.Font = LargeFont;
                    newlabel.TextAlign = ContentAlignment.MiddleCenter;
                    newlabel.Click += new EventHandler(Kattintas);
                    this.Controls.Add(newlabel);
                    labelek[i, j] = newlabel;

                }
            }
            
        }

        private void Kattintas(object sender, EventArgs e)
        {
            Label kattintottLabel = sender as Label;
            if (kattintottLabel.Text==""&&turn==0)
            {

                kattintottLabel.Text = "X";
                kattintottLabel.BackColor = Color.HotPink;
                kijotte(kattintottLabel);
                turn = 1;
            }
            else if (kattintottLabel.Text == "" && turn == 1)
            {
                kattintottLabel.Text = "O";
                kattintottLabel.BackColor = Color.CornflowerBlue;
                kijotte(kattintottLabel);
                turn = 0;
            }
        }

        private void kijotte(Label kattintottLabel)
        {

            
            int Y =Convert.ToInt32( kattintottLabel.Name.Split('_')[1]);
            int X = Convert.ToInt32(kattintottLabel.Name.Split('_')[0]);
            int summa = 0;
            switch (turn)
            {
                case 0:
                    switch (size)
                    {
                        case 10:

                            break;
                        case 3:
                            szelenvan(X, Y);
                            for (int i = 0; i < 3; i++)
                            {
                                if (labelek[i, Y].Text == "X")
                                {
                                    summa++;
                                }
                            }
                            if (summa == 3)
                            {
                                string message = "hurá hurá hurá jaj de nagyon jó, hogy  nyertél. akarsz újra játszani?";
                                string title = "jéj  nyertél";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, buttons);
                                if (result == DialogResult.No)
                                {
                                    Application.Exit();
                                }
                                else
                                {
                                    Application.Restart();
                                }
                            }
                            summa = 0;
                            if (summa<3)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (labelek[X, i].Text == "X")
                                    {
                                        summa++;
                                    }
                                }
                                
                            }
                            else if (summa == 3)
                            {
                                string message = "hurá hurá hurá jaj de nagyon jó, hogy  nyertél. akarsz újra játszani?";
                                string title = "jéj  nyertél";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, buttons);
                                if (result == DialogResult.No)
                                {
                                    Application.Exit();
                                }
                                else
                                {
                                    Application.Restart();
                                }
                            }
                            summa = 0;
                            if (summa < 3)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (labelek[X, i].Text == "X")
                                    {
                                        summa++;
                                    }
                                }

                            }
                            else if (summa==3)
                            {
                                string message = "hurá hurá hurá jaj de nagyon jó, hogy  nyertél. akarsz újra játszani?";
                                string title = "jéj  nyertél";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, buttons);
                                if (result == DialogResult.No)
                                {
                                    Application.Exit();
                                }
                                else
                                {
                                    Application.Restart();
                                }
                            }
                            summa = 0;
                            if (summa < 3)
                            {
                                
                                    if (labelek[2,0].Text == "X"&& labelek[1,1].Text == "X" && labelek[0,2].Text == "X")
                                    {
                                        string message = "hurá hurá hurá jaj de nagyon jó, hogy "+ player1_name+" nyert. akartok újra játszani?";
                                        string title = "jéj  nyertél";
                                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                        DialogResult result = MessageBox.Show(message, title, buttons);
                                        if (result == DialogResult.No)
                                        {
                                            Application.Exit();
                                        }
                                        else
                                        {
                                            Application.Restart();
                                        }
                                    }
                                    else if(labelek[0,2].Text == "X" && labelek[1,1].Text == "X" && labelek[2,0].Text == "X")
                                    {
                                        string message = "hurá hurá hurá jaj de nagyon jó, hogy " + player1_name + " nyert. akartok újra játszani?";
                                        string title = "jéj  nyertél";
                                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                        DialogResult result = MessageBox.Show(message, title, buttons);
                                        if (result == DialogResult.No)
                                        {
                                            Application.Exit();
                                        }
                                        else
                                        {
                                            Application.Restart();
                                        }
                                    }
                                    
                                
                                
                                
                                    
                                
                                
                            }
                            summa = 0;
                            break;
                        case 5:

                            break;
                    }
                    break;
                case 1:
                    switch (size)
                    {
                        case 10:

                            break;
                        case 3:
                            szelenvan(X, Y);
                            for (int i = 0; i < 3; i++)
                            {
                                if (labelek[i, Y].Text == "O")
                                {
                                    summa++;
                                }
                            }
                            if (summa == 3)
                            {
                                string message = "hurá hurá hurá jaj de nagyon jó, hogy "+player2_name +" nyert. akartok újra játszani?";
                                string title = "jéj  nyertél";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, buttons);
                                if (result == DialogResult.No)
                                {
                                    Application.Exit();
                                }
                                else
                                {
                                    Application.Restart();
                                }
                            }
                            summa = 0;
                            if (summa < 3)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (labelek[X, i].Text == "O")
                                    {
                                        summa++;
                                    }
                                }

                            }
                            else if (summa == 3)
                            {
                                string message = "hurá hurá hurá jaj de nagyon jó, hogy " + player2_name + " nyert. akartok újra játszani?";
                                string title = "jéj  nyertél";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, buttons);
                                if (result == DialogResult.No)
                                {
                                    Application.Exit();
                                }
                                else
                                {
                                    Application.Restart();
                                }
                            }
                            summa = 0;
                            if (summa < 3)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (labelek[X, i].Text == "O")
                                    {
                                        summa++;
                                    }
                                }

                            }
                            else if (summa == 3)
                            {
                                string message = "hurá hurá hurá jaj de nagyon jó, hogy " + player2_name + " nyert. akartok újra játszani?";
                                string title = "jéj  nyertél";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, buttons);
                                if (result == DialogResult.No)
                                {
                                    Application.Exit();
                                }
                                else
                                {
                                    Application.Restart();
                                }
                            }
                            summa = 0;
                            if (summa < 3)
                            {

                                if (labelek[2, 0].Text == "O" && labelek[1, 1].Text == "O" && labelek[0, 2].Text == "O")
                                {
                                    string message = "hurá hurá hurá jaj de nagyon jó, hogy " + player2_name + " nyert. akartok újra játszani?";
                                    string title = "jéj  nyertél";
                                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                    DialogResult result = MessageBox.Show(message, title, buttons);
                                    if (result == DialogResult.No)
                                    {
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        Application.Restart();
                                    }
                                }
                                else if (labelek[0, 2].Text == "O" && labelek[1, 1].Text == "O" && labelek[2, 0].Text == "O")
                                {
                                    string message = "hurá hurá hurá jaj de nagyon jó, hogy " + player2_name + " nyert. akartok újra játszani?";
                                    string title = "jéj  nyertél";
                                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                    DialogResult result = MessageBox.Show(message, title, buttons);
                                    if (result == DialogResult.No)
                                    {
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        Application.Restart();
                                    }
                                }







                            }
                            summa = 0;
                            break;
                        case 5:

                            break;
                    }
                    break;
            }
            
        }

        private void szelenvan(int X,int Y)
        {
            if (X==size-1||X==0)
            {
                xSzel = true;
            }
            if (Y==size-1 || Y == 0)
            {
                ySzel = true;
            }
        }

        public void atadas(string player1name, string player2name)
        {
            player1_name = player1name;
            player2_name = player2name;
        }

        private void jatekter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void jatekter_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Az amőbajátékok szabályai Amőba (gomoko, gomoku)   Az amőba a legismertebb és legegyszerűbb táblás játékok egyike. Általában négyzetrácsos papíron játsszák; a négyzetháló mérete lehet egyenlő a rendelkezésre álló papír méretével, de kisebb terület is kijelölhető.   A játékosok felváltva helyeznek egy-egy jelet a tábla valamelyik, még üres négyzetébe; mindenki a saját jelével játszik. (A leggyakoribb jelek az X és az O, de másmilyenek is használhatók.) Az nyer, akinek sikerül saját jeleiből ötöt egyenes vonalban - vízszintesen, függőlegesen vagy ferdén - egymás mellé helyeznie. (Öt és négy a leggyakoribb értékek. Hárommal, illetve ötnél nagyobb számokkal is játszhatunk.)   Hárman vagy többen is játszhatnak; ez esetben a sokféle jel miatt az állás nehezen áttekinthetővé válhat, ezért célszerű különböző színekkel játszani. Tik-tak-to  - - -     A játék az amőba még egyszerűbb változata, amőbának is nevezik. |1|2|3|  Táblája háromszor három négyzetből áll, amelyekbe a játékosokfelváltva rajzolják be jelüket.A cél három jelünket vízszintesen,| 4 | 5 | 6 | függőlegesen vagy átlósan egymás mellé állítani - utóbbi nyilváncsak a főátlókban lehetséges.Baloldalt látható a játék táblája a| 7 | 8 | 9 | mezőket jelző számokkal.Ezt a játékot csak ketten játszhatják.A tik - tak - to stratégiája igen egyszerű.A kezdő játékosnak a középső(5 - ös) mezőre kell tennie, majd ellenfele lépését követően egy sarokmezőre.Például: 5, 9; 3, 7; 2.Az utolsó lépéssel a kezdő  nyert, hiszen ellenfele nem tehet az 1 - es és a 8 -as mezőre egyszerre.A másodikként lépő játékosnak szintén a sarokmezőket kell választania(hacsak a kezdőjátékos üresen nem hagyta a középső mezőt).Ugrálós amőba Ezt a játékot a tik-tak - tóéval megegyező táblán játssza két játékos, három - három bábuval.Először elhelyezik ezeket, felváltva egy-egy mezőre, arra törekedve, hogy hármat egy sorba állíthassanak. Ha ez nem sikerült, ugrálni kezdenek: felváltva felveszik egy - egy figurájukat, és a tábla egyik üres mezőjére teszik.Az nyer, akinek először sikerül sorbarakni bábuit. Térbeli amőba 3 ooo A játékot speciális táblán kell játszani: többszintes, polcszerű ooo emelvényen, amelynek minden szintje egy-egy négyzetrácsot tartalmaz. ooo A tábla kocka alakú, vagyis a négyzetrácsok annyi sorból és oszlopból állnak, ahány emelet van. (Ilyen felszerelést időnként 2 ooo lehet kapni a játékboltokban.) Baloldalt egy ilyen polc vázlata ooo látható, sarka felől nézve.Számok jelölik az emeletet, kisbetűk ooo az oszlopot, nagyok a sort.A játékosok felváltva helyezik figuráikat valamelyik mezőre; 1 oooC céljuk a tábla két szélét összekötő - 3 * 3 * 3 mezős táblán három, oooB 4 * 4 * 4 mezősön négy bábuból álló -sort kialakítani.Ez oooA többféleképpen lehetséges; az 1aA mezőtől például építhetünk sort abc az 1cA, 1aC, 1cC mezőkig -azonos emeleten maradva -, valamint a 3aA, 3cA, 3aC, 3cC mezőkig, mindhárom emeletet érintve. A játék ugrálós változatát is kipróbálhatjuk.");
        }
    }
}
