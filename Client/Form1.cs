using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4 {
    public partial class Form1 : Form {
        private int checkBG = 0;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            paintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.paintBox_paint);
            picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_paint);
        }

        /// <summary>
        /// Prints Blackjack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paintBox_paint(object sender, System.Windows.Forms.PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.DrawString("BLACKJACK", new Font("Comic Sans MS", 19), System.Drawing.Brushes.Pink, new Point(0, 30));
        }
        /// <summary>
        /// Prints shapes/blackjack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBox_paint(object sender, System.Windows.Forms.PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(Color.Purple, 3), 0, 0, 150, 200);
            g.DrawEllipse(new Pen(Color.Red, 3), 0, 0, 150, 200);
            g.DrawString("BLACKJACK", new Font("Comic Sans MS", 15), System.Drawing.Brushes.Black, new Point(10, 70));
        }

        /// <summary>
        /// Lets you connect to server, Validates id there is a connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConn_Click(object sender, EventArgs e) {
            Conn ConnecttoServer = new Conn();
            String Conect= ConnecttoServer.TestConc(iptextbox.Text.ToLower(), "Let me start the Game");
            if (Conect == "Start Game") {
                GameForm gameForm = new GameForm(iptextbox.Text);
                gameForm.ShowDialog();
            }
            else {
                iptextbox.Text = Conect;
            }
        }

        /// <summary>
        /// Changes background color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGcolor_Click(object sender, EventArgs e) {
            if (checkBG % 2 == 0) {
                BackgroundImage = Image.FromFile("png/bg.jpg");
                checkBG++;
            }
            else {
                BackgroundImage = Image.FromFile("png/bg2.jpg");
                checkBG++;
            }



        }
    }
}
