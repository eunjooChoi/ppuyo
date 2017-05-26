using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace 뿌요뿌요
{
    public partial class Form1 : Form
    {

        SoundPlayer press = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    {
                        if(colorAlone.Visible==true && blackYou.Visible == true && blackRanking.Visible==true && blackEnd.Visible ==true)
                        {
                            press = new SoundPlayer(Application.StartupPath + @"\이동.wav");
                            press.Play();

                            colorAlone.Visible = false;
                            blackAlone.Visible = true;

                            colorYou.Visible = false;
                            blackYou.Visible = true;

                            colorRanking.Visible = false;
                            blackRanking.Visible = true;

                            colorEnd.Visible = true;
                            blackEnd.Visible = false;
                        }
                        else if (colorYou.Visible == true && blackAlone.Visible == true && blackRanking.Visible == true && blackEnd.Visible == true)
                        {
                            press = new SoundPlayer(Application.StartupPath + @"\이동.wav");
                            press.Play();

                            colorAlone.Visible = true;
                            blackAlone.Visible = false;

                            colorYou.Visible = false;
                            blackYou.Visible = true;

                            colorRanking.Visible = false;
                            blackRanking.Visible = true;

                            colorEnd.Visible = false;
                            blackEnd.Visible = true;
                        }
                        else if (colorRanking.Visible == true && blackYou.Visible == true && blackAlone.Visible == true && blackEnd.Visible == true)
                        {
                            press = new SoundPlayer(Application.StartupPath + @"\이동.wav");
                            press.Play();

                            colorAlone.Visible = false;
                            blackAlone.Visible = true;

                            colorYou.Visible = true;
                            blackYou.Visible = false;

                            colorRanking.Visible = false;
                            blackRanking.Visible = true;

                            colorEnd.Visible = false;
                            blackEnd.Visible = true;
                        }
                        else if (colorEnd.Visible == true && blackYou.Visible == true && blackRanking.Visible == true && blackRanking.Visible == true)
                        {
                            press = new SoundPlayer(Application.StartupPath + @"\이동.wav");
                            press.Play();

                            colorAlone.Visible = false;
                            blackAlone.Visible = true;

                            colorYou.Visible = false;
                            blackYou.Visible = true;

                            colorRanking.Visible = true;
                            blackRanking.Visible = false;

                            colorEnd.Visible = false;
                            blackEnd.Visible = true;
                        }
                        break;
                    }
                case Keys.Right:
                    {
                        if (colorAlone.Visible == true && blackYou.Visible == true && blackRanking.Visible == true && blackEnd.Visible == true)
                        {
                            press = new SoundPlayer(Application.StartupPath + @"\이동.wav");
                            press.Play();

                            colorAlone.Visible = false;
                            blackAlone.Visible = true;

                            colorYou.Visible = true;
                            blackYou.Visible = false;

                            colorRanking.Visible = false;
                            blackRanking.Visible = true;

                            colorEnd.Visible = false;
                            blackEnd.Visible = true;
                        }
                        else if (colorYou.Visible == true && blackAlone.Visible == true && blackRanking.Visible == true && blackEnd.Visible == true)
                        {
                            press = new SoundPlayer(Application.StartupPath + @"\이동.wav");
                            press.Play();

                            colorAlone.Visible = false;
                            blackAlone.Visible = true;

                            colorYou.Visible = false;
                            blackYou.Visible = true;

                            colorRanking.Visible = true;
                            blackRanking.Visible = false;

                            colorEnd.Visible = false;
                            blackEnd.Visible = true;
                        }
                        else if (colorRanking.Visible == true && blackYou.Visible == true && blackAlone.Visible == true && blackEnd.Visible == true)
                        {
                            press = new SoundPlayer(Application.StartupPath + @"\이동.wav");
                            press.Play();

                            colorAlone.Visible = false;
                            blackAlone.Visible = true;

                            colorYou.Visible = false;
                            blackYou.Visible = true;

                            colorRanking.Visible = false;
                            blackRanking.Visible = true;

                            colorEnd.Visible = true;
                            blackEnd.Visible = false;
                        }
                        else if (colorEnd.Visible == true && blackYou.Visible == true && blackRanking.Visible == true && blackAlone.Visible == true)
                        {
                            press = new SoundPlayer(Application.StartupPath + @"\이동.wav");
                            press.Play();

                            colorAlone.Visible = true;
                            blackAlone.Visible = false;

                            colorYou.Visible = false;
                            blackYou.Visible = true;

                            colorRanking.Visible = false;
                            blackRanking.Visible = true;

                            colorEnd.Visible = false;
                            blackEnd.Visible = true;
                        }
                        break;
                    }
                case Keys.Enter:
                    {
                        if (colorAlone.Visible == true) //나홀로 게임 시작
                        {
                            press = new SoundPlayer(Application.StartupPath + @"\선택.wav");
                            press.Play();
                            axWindowsMediaPlayer1.Ctlcontrols.pause();

                            Alone alone = new Alone();
                            alone.ShowDialog();
                            
                        }
                        else if (colorYou.Visible == true)  //너랑나랑 시작
                        {
                            press = new SoundPlayer(Application.StartupPath + @"\선택.wav");
                            press.Play();
                            axWindowsMediaPlayer1.Ctlcontrols.pause();

                            _1Por2P a = new _1Por2P();
                            a.ShowDialog();

                        }
                        else if (colorRanking.Visible == true)  //랭킹 시작
                        {
                            press = new SoundPlayer(Application.StartupPath + @"\선택.wav");
                            press.Play();
                            axWindowsMediaPlayer1.Ctlcontrols.pause();

                            Ranking ranking = new Ranking();
                            ranking.ShowDialog();
                        }
                        else if (colorEnd.Visible == true)  //끝내기
                            this.Close();
                        break;
                    }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            colorAlone.Visible = true;
           // colorYou.Visible = true;
           // colorRanking.Visible = true;
           // colorEnd.Visible = true;
            //blackAlone.Visible = true;
            blackYou.Visible = true;
            blackRanking.Visible = true;
            blackEnd.Visible = true;

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.mediaCollection.getByName("back1");
            //axWindowsMediaPlayer1.Ctlcontrols.play();

        }
    }
}
