using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4 {
    public partial class GameForm : Form {
        private string ipconn;
        private int cardVal1 = 0;
        private int cardVal2 = 0;
        private int cardVal3 = 0;
        private int cardVal4 = 0;
        private int oppCardVal1 = 0;
        private int oppCardVal2 = 0;
        private int oppCardVal3 = 0;
        private String _oppCard1;
        private String _oppCard2;
        private String _oppCard3 = "back";//prevents a crash later...
        private int extraCard = 3;
        static Random random = new Random();
        private int opp = random.Next(17, 21);

        public GameForm(string ipConnection) {
            InitializeComponent();
            ipconn = ipConnection;
        }
        /// <summary>
        /// Loads the game, gets the Oppenets cards and the players card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e) {
            Conn ClientServer = new Conn();
            String card1 = ClientServer.TestConc(ipconn, "Give me a card");
            Thread.Sleep(10); //IDK why but it prevents giving 2 the same card
            String card2 = ClientServer.TestConc(ipconn, "Give me a card");

            //OPP CARDS
            Thread.Sleep(10); //IDK why but it prevents giving 2 the same card
            _oppCard1 = ClientServer.TestConc(ipconn, "Give me a card");
            oppCardVal1 = cardNum(_oppCard1);
            Thread.Sleep(10); //IDK why but it prevents giving 2 the same card
            _oppCard2 = ClientServer.TestConc(ipconn, "Give me a card");
            oppCardVal2 = cardNum(_oppCard2);
            Thread.Sleep(10); //IDK why but it prevents giving 2 the same card
            if ((oppCardVal1+oppCardVal2) <= 15) {
                Thread.Sleep(10); //IDK why but it prevents giving 2 the same card
                _oppCard3 = ClientServer.TestConc(ipconn, "Give me a card");
                Thread.Sleep(10); //IDK why but it prevents giving 2 the same card
                oppCardVal3 = cardNum(_oppCard3);
                oppCard3.Visible = true;
            }
            else {
                oppCard3.Image = Image.FromFile("png/back.png");
            }

            CARDNUM1.Image = Image.FromFile("png/" + card1 + ".png");
            cardVal1 = cardNum(card1);
            CARDNUM2.Image = Image.FromFile("png/" + card2 + ".png");
            cardVal2 = cardNum(card2);
        }
        

        /// <summary>
        /// Pick up a card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHit_Click(object sender, EventArgs e) {
            Conn ClientServer = new Conn();
            Thread.Sleep(10); //IDK why but it prevents giving 2 the same card
            if ((cardVal1+cardVal2+cardVal3+cardVal4) > 21) {//BUST
                MessageBox.Show("BUST");
            }
            else {
                if (extraCard == 3) {
                    String card3 = ClientServer.TestConc(ipconn, "Give me a card");
                    CARDNUM3.Image = Image.FromFile("png/" + card3 + ".png");
                    cardVal3 = cardNum(card3);
                    CARDNUM3.Enabled = true;
                    CARDNUM3.Visible = true;
                    extraCard++;
                }
                else if (extraCard == 4) {
                    String card4 = ClientServer.TestConc(ipconn, "Give me a card");
                    CARDNUM4.Image = Image.FromFile("png/" + card4 + ".png");
                    cardVal4 = cardNum(card4);
                    CARDNUM4.Enabled = true;
                    CARDNUM4.Visible = true;
                    extraCard++;
                }
            }
        }

        /// <summary>
        /// Check if you won or lost.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStay_Click(object sender, EventArgs e) {
            //make it reveal opp cards
            if ((cardVal1 + cardVal2 + cardVal3 + cardVal4) > 21) {//BUST
                oppCard1.Image = Image.FromFile("png/" + _oppCard1 + ".png");
                oppCard2.Image = Image.FromFile("png/" + _oppCard2 + ".png");
                oppCard3.Image = Image.FromFile("png/" + _oppCard3 + ".png");
                MessageBox.Show("BUST :'(");
                this.Dispose();
                GameForm gf = new GameForm(ipconn);
                gf.Show();

            }
            else {
                if ((cardVal1 + cardVal2 + cardVal3 + cardVal4) > opp) {
                    oppCard1.Image = Image.FromFile("png/" + _oppCard1 + ".png");
                    oppCard2.Image = Image.FromFile("png/" + _oppCard2 + ".png");
                    oppCard3.Image = Image.FromFile("png/" + _oppCard3 + ".png");
                    MessageBox.Show("Winner :)");
                    this.Refresh();
                    this.Invalidate();
                    this.Dispose();
                    GameForm gf = new GameForm(ipconn);
                    gf.Show();
                }
                if ((cardVal1 + cardVal2 + cardVal3 + cardVal4) < opp) {
                    oppCard1.Image = Image.FromFile("png/" + _oppCard1 + ".png");
                    oppCard2.Image = Image.FromFile("png/" + _oppCard2 + ".png");
                    oppCard3.Image = Image.FromFile("png/" + _oppCard3 + ".png");
                    MessageBox.Show("Loser :(");
                    this.Refresh();
                    this.Invalidate();
                    this.Dispose();
                    GameForm gf = new GameForm(ipconn);
                    gf.Show();
                }
            }

        }

        /// <summary>
        /// A mathematical output of each card value.
        /// </summary>
        /// <param name="card"> enters a card string eg:a,1,2,3,4,5,6,7,8,9,10.J,Q,K</param>
        /// <returns></returns>
        private int cardNum(string card) {
            int value = 0;
            switch (card.Substring(0, 1)) {
                case "a":
                    value = 1;
                    break;
                case "2":
                    value = 2;
                    break;
                case "3":
                    value = 3;
                    break;
                case "4":
                    value = 4;
                    break;
                case "5":
                    value = 5;
                    break;
                case "6":
                    value = 6;
                    break;
                case "7":
                    value = 7;
                    break;
                case "8":
                    value = 8;
                    break;
                case "9":
                    value = 9;
                    break;
                case "10":
                    value = 10;
                    break;
                case "j":
                    value = 10;
                    break;
                case "q":
                    value = 10;
                    break;
                case "k":
                    value = 10;
                    break;
                default:
                    value = 0;
                    break;
            }
            return value;
        }

    }
}