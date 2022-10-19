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
    public partial class Form1 : Form
    {
        public static string player1 = "";
        public static string player2 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (txtbx_player1_name.Text.Length==0)
            {
                player1 = "Player 1";
            }
            else
            {
                player1 = txtbx_player1_name.Text;
            }
            if (txtbx_player2_name.Text.Length == 0)
            {
                player2 = "Player 2";
            }
            else
            {
                player2 = txtbx_player2_name.Text;
            }
            

            jatekter uj = new jatekter();
            this.Hide();
            uj.atadas(player1,player2);
            uj.Show();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Az amőbajátékok szabályai Amőba (gomoko, gomoku)   Az amőba a legismertebb és legegyszerűbb táblás játékok egyike. Általában négyzetrácsos papíron játsszák; a négyzetháló mérete lehet egyenlő a rendelkezésre álló papír méretével, de kisebb terület is kijelölhető.   A játékosok felváltva helyeznek egy-egy jelet a tábla valamelyik, még üres négyzetébe; mindenki a saját jelével játszik. (A leggyakoribb jelek az X és az O, de másmilyenek is használhatók.) Az nyer, akinek sikerül saját jeleiből ötöt egyenes vonalban - vízszintesen, függőlegesen vagy ferdén - egymás mellé helyeznie. (Öt és négy a leggyakoribb értékek. Hárommal, illetve ötnél nagyobb számokkal is játszhatunk.)   Hárman vagy többen is játszhatnak; ez esetben a sokféle jel miatt az állás nehezen áttekinthetővé válhat, ezért célszerű különböző színekkel játszani. Tik-tak-to  - - -     A játék az amőba még egyszerűbb változata, amőbának is nevezik. |1|2|3|  Táblája háromszor három négyzetből áll, amelyekbe a játékosokfelváltva rajzolják be jelüket.A cél három jelünket vízszintesen,| 4 | 5 | 6 | függőlegesen vagy átlósan egymás mellé állítani - utóbbi nyilváncsak a főátlókban lehetséges.Baloldalt látható a játék táblája a| 7 | 8 | 9 | mezőket jelző számokkal.Ezt a játékot csak ketten játszhatják.A tik - tak - to stratégiája igen egyszerű.A kezdő játékosnak a középső(5 - ös) mezőre kell tennie, majd ellenfele lépését követően egy sarokmezőre.Például: 5, 9; 3, 7; 2.Az utolsó lépéssel a kezdő nyert, hiszen ellenfele nem tehet az 1 - es és a 8 -as mezőre egyszerre.A másodikként lépő játékosnak szintén a sarokmezőket kell választania(hacsak a kezdőjátékos üresen nem hagyta a középső mezőt).Ugrálós amőba Ezt a játékot a tik-tak - tóéval megegyező táblán játssza két játékos, három - három bábuval.Először elhelyezik ezeket, felváltva egy-egy mezőre, arra törekedve, hogy hármat egy sorba állíthassanak. Ha ez nem sikerült, ugrálni kezdenek: felváltva felveszik egy - egy figurájukat, és a tábla egyik üres mezőjére teszik.Az nyer, akinek először sikerül sorbarakni bábuit. Térbeli amőba 3 ooo A játékot speciális táblán kell játszani: többszintes, polcszerű ooo emelvényen, amelynek minden szintje egy-egy négyzetrácsot tartalmaz. ooo A tábla kocka alakú, vagyis a négyzetrácsok annyi sorból és oszlopból állnak, ahány emelet van. (Ilyen felszerelést időnként 2 ooo lehet kapni a játékboltokban.) Baloldalt egy ilyen polc vázlata ooo látható, sarka felől nézve.Számok jelölik az emeletet, kisbetűk ooo az oszlopot, nagyok a sort.A játékosok felváltva helyezik figuráikat valamelyik mezőre; 1 oooC céljuk a tábla két szélét összekötő - 3 * 3 * 3 mezős táblán három, oooB 4 * 4 * 4 mezősön négy bábuból álló -sort kialakítani.Ez oooA többféleképpen lehetséges; az 1aA mezőtől például építhetünk sort abc az 1cA, 1aC, 1cC mezőkig -azonos emeleten maradva -, valamint a 3aA, 3cA, 3aC, 3cC mezőkig, mindhárom emeletet érintve. A játék ugrálós változatát is kipróbálhatjuk.");
        }
    }
}
