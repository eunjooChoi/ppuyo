using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using ClassLibrary1;
using System.IO;
using System.Media;


namespace 뿌요뿌요
{
    public partial class You : Form
    {
        #region 뿌요뿌요 패턴
        private int[,] pattern = new int[4, 9]
        {
            {
                0,0,0,
                0,0,0,
                0,0,0
            },
            {
                0,0,0,
                0,0,0,
                0,0,0
            },
            {
                0,0,0,
                0,0,0,
                0,0,0
            },
            {
                0,0,0,
                0,0,0,
                0,0,0
            }
        };
        #endregion
        private int[,] gameBoard = new int[8, 14];
        private int[,] burstBoard = new int[8, 14];
        private int[,] puyoColor = new int[8, 14];
        private int[,] nextPuyo = new int[3, 3];
        private int[,] nextBoard = new int[5, 5];	//다음블록 판

        private int WD = 33;
        private int nowx;
        private int nowy;
        private int speed;
        private int nowRotation;
        private int puyoblock1;
        private int puyoblock2;
        private int nextblock;
        private bool isplaying = false;
        private int timer_count = 1;
        private Graphics g;

        private string name;

        private Thread twinkle;
        private Thread makeHudle;

        Random randomBlock = new Random();
        private System.Windows.Forms.Timer hTimer0;

        private StreamWriter writeFile;     //
        private FileStream storeFile;           //파일에 스트림을 하기 위한 변수들

        SoundPlayer drop = new SoundPlayer(); //space  누를때 효과음
        private int combo;

        public You()
        {
            InitBoard();
            hTimer0 = new System.Windows.Forms.Timer();
            InitializeComponent();
        }


        private void DrawNextBlock()        //다음 블럭 만들기
        {
            EraserNextBoard();      //다음블럭판 초기화

            // 다음불럭으로 배열설정

            for (int i = 0; i < 4; i++)
            {
                if (pattern[nextblock, i] != 0)
                    nextBoard[i, 1] = pattern[nextblock, i];
            }
            for (int i = 0; i < 4; i++)
            {
                if (pattern[nextblock, i + 4] != 0)
                    nextBoard[i, 2] = pattern[nextblock, i + 4];
            }
            for (int i = 0; i < 4; i++)
            {
                if (pattern[nextblock, i + 8] != 0)
                    nextBoard[i, 3] = pattern[nextblock, i + 8];
            }
            //			for (int i = 0; i < 4; i++) 
            //			{
            //				if (pattern[nextblock,0, i + 12 ] != 0)
            //					nextBoard[i,3 ] = pattern[nextblock,0, i + 12 ];				
            //			}
            nextPictureBox.Refresh();       //다음 블럭을 다시 그려준다			
        }

        private void nextPictureBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (0 != nextBoard[i, j])
                    {
                        if (1 == nextBoard[i, j])
                        {
                            imageList.Draw(e.Graphics, i * WD, j * WD, WD, WD, 1);
                        }
                        else if (2 == nextBoard[i, j])
                        {
                            imageList.Draw(e.Graphics, i * WD, j * WD, WD, WD, 2);
                        }
                        else if (3 == nextBoard[i, j])
                        {
                            imageList.Draw(e.Graphics, i * WD, j * WD, WD, WD, 3);
                        }
                        else if (4 == nextBoard[i, j])
                        {
                            imageList.Draw(e.Graphics, i * WD, j * WD, WD, WD, 4);
                        }
                        else if (5 == nextBoard[i, j])
                        {
                            imageList.Draw(e.Graphics, i * WD, j * WD, WD, WD, 5);
                        }
                        else if (6 == nextBoard[i, j])
                        {
                            imageList.Draw(e.Graphics, i * WD, j * WD, WD, WD, 6);
                        }
                        else if (7 == nextBoard[i, j])
                        {
                            imageList.Draw(e.Graphics, i * WD, j * WD, WD, WD, 7);
                        }
                        else if (8 == nextBoard[i, j])
                        {
                            imageList.Draw(e.Graphics, i * WD, j * WD, WD, WD, 8);
                        }
                        else if (9 == nextBoard[i, j])
                        {
                            imageList.Draw(e.Graphics, i * WD, j * WD, WD, WD, 9);
                        }

                    }
                    else if (0 == nextBoard[i, j])
                    {
                        imageList.Draw(e.Graphics, i * WD, j * WD, WD, WD, 0);
                    }

                }
            }
        }
        private void InitBoard()        //게임판 초기화
        {
            nowx = 2;       //시작위치 초기화
            nowy = 0;
            speed = 1000;

            //바닥줄 처리
            for (int i = 0; i < 8; i++)
                gameBoard[i, 13] = (int)Block.Wall;

            //양쪽벽 처리
            for (int j = 0; j < 14; j++)
            {
                gameBoard[0, j] = (int)Block.Wall;
                gameBoard[7, j] = (int)Block.Wall;
            }

            // 나머지 공간은 0으로 채움
            for (int m = 1; m < 7; m++)
                for (int n = 0; n < 13; n++)
                    gameBoard[m, n] = (int)Block.BackGround;
            EraserNextBoard();      //다음블럭판초기화
        }
        private void EraserNextBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    nextPuyo[i, j] = (int)Block.BackGround;
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            picturePaint(e);
        }
        private void picturePaint(System.Windows.Forms.PaintEventArgs e)
        {
            g = e.Graphics;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if ((int)Block.BackGround != gameBoard[i, j])
                        imageList.Draw(g, i * WD, j * WD, WD, WD, gameBoard[i, j]);
                    else if ((int)Block.BackGround == gameBoard[i, j])
                        imageList.Draw(g, i * WD, j * WD, WD, WD, (int)Block.BackGround);
                }
            }
        }

        private void gameStart()
        {
            InitBoard();
            speed = 1000;
            hTimer0.Enabled = true;
            hTimer0.Tick += new EventHandler(BlockTimer);
            hTimer0.Interval = speed;
            hTimer0.Start();
            isplaying = true;
            twinkle = new Thread(Twinkle);
            makeHudle = new Thread(hudle);
            makeHudle.Start();
            twinkle.Start();
            CreateBlock();
        }
        private void Eraser()
        {
            for (int i = 0; i < 3; i++)
            {
                if (pattern[nowRotation, i] != 0)
                    gameBoard[nowx + i, nowy] = 0;
            }
            for (int i = 3; i < 6; i++)
            {
                if (pattern[nowRotation, i] != 0)
                    gameBoard[nowx + i - 3, nowy + 1] = 0;
            }
            for (int i = 6; i < 9; i++)
            {
                if (pattern[nowRotation, i] != 0)
                    gameBoard[nowx + i - 6, nowy + 2] = 0;
            }
        }
        private void BlockTimer(object sender, EventArgs e)
        {
            DownBlock();
        }
        private void DownBlock()    //한칸씩 블럭을 내려준다
        {
            if (!IsCrash(nowx, nowy, nowRotation))
            {
                Eraser();
                nowy++;
                DrawNowPuyo();
            }
            else
            {
                if (nowy != -1)
                {
                    DropBlock();
                    CreateBlock();
                }
                else
                {
                    textBox1.AppendText("게임 종료!");
                }
            }
        }
        private void Twinkle()
        {
            while (true)
            {
                Thread.Sleep(500);
                if (pattern[0, 4] > 6)
                {
                    for (int i = 0; i < 4; i++)
                        pattern[i, 4] = (pattern[i, 4] / 16) + 2;
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                        pattern[i, 4] = (pattern[i, 4] - 2) * 16 + 7;
                }
                try
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        DrawNowPuyo();
                    }));
                }
                catch { }

            }
        }
        private void ConnectPuyo()
        {
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    if (gameBoard[i, j] != 0 && gameBoard[i, j] != 102)
                    {
                        int count = 0;
                        bool left, right, up, down;
                        left = false;
                        right = false;
                        up = false;
                        down = false;
                        int temp;

                        if (gameBoard[i, j] > 6 && gameBoard[i, j] < 88) { temp = (gameBoard[i, j] - 7) / 16 + 2; }
                        else { temp = gameBoard[i, j]; }

                        int min = (temp - 2) * 16 + 7;
                        int max = (temp - 2) * 16 + 22;

                        //오른쪽이 같을 때
                        if (temp == gameBoard[i + 1, j] || (min <= gameBoard[i + 1, j] && gameBoard[i + 1, j] <= max))
                        {
                            count++;
                            right = true;
                        }
                        //왼쪽이 같을 때
                        if (temp == gameBoard[i - 1, j] || (min <= gameBoard[i - 1, j] && gameBoard[i - 1, j] <= max))
                        {
                            count++;
                            left = true;
                        }
                        //아래쪽이 같을 때
                        if (temp == gameBoard[i, j + 1] || (min <= gameBoard[i, j + 1] && gameBoard[i, j + 1] <= max))
                        {
                            count++;
                            down = true;
                        }
                        //위쪽이 같을 때
                        if (temp == gameBoard[i, j - 1] || (min <= gameBoard[i, j - 1] && gameBoard[i, j - 1] <= max))
                        {
                            count++;
                            up = true;
                        }
                        switch (count)
                        {
                            case 0:
                                if (gameBoard[i, j] > 6 && gameBoard[i, j] < 88) { gameBoard[i, j] = (gameBoard[i, j] - 7) / 16 + 2; }
                                break;
                            case 1:
                                if (left) { gameBoard[i, j] = min + 1; }
                                else if (right) { gameBoard[i, j] = min + 2; }
                                else if (up) { gameBoard[i, j] = min + 3; }
                                else if (down) { gameBoard[i, j] = min + 4; }
                                break;
                            case 2:
                                if (left && right) { gameBoard[i, j] = min + 5; }
                                else if (left && up) { gameBoard[i, j] = min + 6; }
                                else if (left && down) { gameBoard[i, j] = min + 7; }
                                else if (right && up) { gameBoard[i, j] = min + 8; }
                                else if (right && down) { gameBoard[i, j] = min + 9; }
                                else if (up && down) { gameBoard[i, j] = min + 10; }
                                break;
                            case 3:
                                if (left && right && up) { gameBoard[i, j] = max - 4; }
                                else if (left && right && down) { gameBoard[i, j] = max - 3; }
                                else if (right && up && down) { gameBoard[i, j] = max - 1; }
                                else if (left && up && down) { gameBoard[i, j] = max - 2; }
                                break;
                            case 4:
                                gameBoard[i, j] = max;
                                break;
                        }
                    }
                }
            }
        }
        private void DropBlock()
        {
            for (int i = 1; i < 7; i++)
            {
                for (int j = 13; j > 0; j--)
                {
                    int k = 0;
                    if (gameBoard[i, j] == (int)Block.BackGround)
                    {
                        while (j - k > 0)
                        {
                            if (gameBoard[i, j - k] != (int)Block.BackGround)
                            {
                                break;
                            }
                            k++;
                        }
                    }
                    if (k != 0)
                    {
                        gameBoard[i, j] = gameBoard[i, j - k];
                        gameBoard[i, j - k] = (int)Block.BackGround;
                    }
                    if (gameBoard[i, j] % 16 == 7 && gameBoard[i, j] < 88)
                        gameBoard[i, j] = gameBoard[i, j] / 16 + 2;
                }
            }
        }
        private bool IsSwap(int x, int y, int nowRotation)
        {
            if (nowy == -1 && (nowRotation == 2))
                nowy++;
            if (nowRotation == 0)
            {
                if (gameBoard[nowx + 1, nowy + 2] != 0)
                {
                    if (gameBoard[nowx + 1, nowy] != 0)
                        return false;
                    else
                        nowy--;
                }
            }
            if (nowRotation == 1)
            {
                if (gameBoard[nowx, nowy + 1] != 0)
                {
                    if (gameBoard[nowx + 2, nowy + 1] != 0)
                        return false;
                    else
                        nowx++;
                }
            }
            if (nowRotation == 3)
            {
                if (gameBoard[nowx + 2, nowy + 1] != 0)
                {
                    if (gameBoard[nowx, nowy + 1] != 0)
                        return false;
                    else
                        nowx--;
                }
            }
            return true;
        }
        private bool IsCrash(int x, int y, int nowRotation)
        {
            if ((nowRotation == 0))
            {
                if (gameBoard[nowx + 1, nowy + 2] != (int)Block.BackGround)
                    return true;
                if (gameBoard[nowx + 2, nowy + 2] != (int)Block.BackGround)
                    return true;
            }
            else if ((nowRotation == 2))
            {
                if (gameBoard[nowx, nowy + 2] != (int)Block.BackGround)
                    return true;
                if (gameBoard[nowx + 1, nowy + 2] != (int)Block.BackGround)
                    return true;
            }
            else if ((nowRotation == 1))
            {
                if (gameBoard[nowx + 1, nowy + 3] != (int)Block.BackGround)
                    return true;
            }
            else if ((nowRotation == 3))
            {
                if (gameBoard[nowx + 1, nowy + 2] != (int)Block.BackGround)
                    return true;
            }
            return false;
        }
        private void DrawNowPuyo()
        {
            if (nowy < 14 && nowx < 8)
            {
                if (nowy != -1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (pattern[nowRotation, i] != 0)
                            gameBoard[nowx + i, nowy] = pattern[nowRotation, i];
                    }
                }
                for (int i = 3; i < 6; i++)
                {
                    if (pattern[nowRotation, i] != 0)
                        gameBoard[nowx + i - 3, nowy + 1] = pattern[nowRotation, i];
                }
                for (int i = 6; i < 9; i++)
                {
                    if (pattern[nowRotation, i] != 0)
                        gameBoard[nowx + i - 6, nowy + 2] = pattern[nowRotation, i];
                }
            }
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    pictureBox1.Refresh();
                }));
            }
            catch { }

        }
        private void CreateBlock()
        {
            combo = 0;
            puyoblock1 = randomBlock.Next(5) + 2;
            puyoblock2 = randomBlock.Next(5) + 2;
            for (int i = 0; i < 4; i++)
            {
                pattern[i, 4] = puyoblock1;
            }
            pattern[0, 5] = puyoblock2; // 가로모양
            pattern[1, 7] = puyoblock2; // 세로모양
            pattern[2, 3] = puyoblock2; // 가로모양
            pattern[3, 1] = puyoblock2; // 세로모양
            nowRotation = 0;
            nowx = 2;
            nowy = -1;
            DrawNowPuyo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            drop = new SoundPlayer(Application.StartupPath + @"\출발.wav");
            drop.Play();

            //////axWindowsMediaPlayer2.Ctlcontrols.play();

            isplaying = true;
            button1.Enabled = false;
            textBox1.Enabled = false;
            gameStart();
            timer1.Start();
        }
        private void You_KeyDown(object sender, KeyEventArgs e)
        {
            if (isplaying)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (nowx == 0)
                    {

                    }
                    else if (nowx == 1 && nowRotation == 2)
                    {

                    }
                    else {
                        Eraser();
                        if (nowRotation == 0)
                        {
                            if (gameBoard[nowx, nowy + 1] != 0)
                                nowx++;
                        }
                        else if (nowRotation == 1)
                        {
                            if (gameBoard[nowx, nowy + 1] != 0)
                                nowx++;
                            else if (gameBoard[nowx, nowy + 2] != 0)
                                nowx++;
                        }
                        else if (nowRotation == 2)
                        {
                            if (gameBoard[nowx - 1, nowy + 1] != 0)
                                nowx++;
                        }
                        else if (nowRotation == 3)
                        {
                            if (gameBoard[nowx, nowy] != 0)
                                nowx++;
                            else if (gameBoard[nowx, nowy + 1] != 0)
                                nowx++;
                        }
                        nowx--;
                        DrawNowPuyo();
                    }
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (nowx == 5)
                    {

                    }
                    else if (nowx == 4 && nowRotation == 0)
                    {

                    }
                    else {
                        Eraser();
                        if (nowRotation == 0)
                        {
                            if (gameBoard[nowx + 3, nowy + 1] != 0)
                                nowx--;
                        }
                        else if (nowRotation == 1)
                        {
                            if (gameBoard[nowx + 2, nowy + 1] != 0)
                                nowx--;
                            else if (gameBoard[nowx + 2, nowy + 2] != 0)
                                nowx--;
                        }
                        else if (nowRotation == 2)
                        {
                            if (gameBoard[nowx + 2, nowy + 1] != 0)
                                nowx--;
                        }
                        else if (nowRotation == 3)
                        {
                            if (gameBoard[nowx + 2, nowy] != 0)
                                nowx--;
                            else if (gameBoard[nowx + 2, nowy + 1] != 0)
                                nowx--;
                        }
                        nowx++;
                        DrawNowPuyo();
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (!IsCrash(nowx, nowy, nowRotation))
                    {
                        Eraser();
                        nowy++;
                        DrawNowPuyo();
                    }
                    else
                    {
                        DropBlock();
                        checkPuyo();
                        ConnectPuyo();

                        CreateBlock();
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    Eraser();
                    if (IsSwap(nowx, nowy, nowRotation))
                    {
                        nowRotation++;
                        if (nowRotation == 4) { nowRotation = 0; }
                    }
                    DrawNowPuyo();
                }
                else if (e.KeyCode == Keys.Space)
                {
                    DropBlock();
                    Eraser();
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 9; j++)
                            pattern[i, j] = 0;
                    }
                    checkPuyo();
                    ConnectPuyo();
                    burstPuyo();
                    CreateBlock();
                }
            }
        }

        private void burstPuyo()
        {
            bool check = false;
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    if (gameBoard[i, j] != 0 && gameBoard[i, j] != 102)
                    {
                        if (SamePuyo(i, j, 0, 0) >= 3)
                        {
                            check = true;
                            burstEffect();
                            DeletePuyo(i, j, gameBoard[i, j]);
                            gameBoard[i, j] = 0;
                            DropBlock();
                        }
                    }
                }
            }
            if (check) burstPuyo();
        }

        private void burstEffect()
        {
            checkhudle();
            combo++;
            textBox1.AppendText(combo + "COMBO!\n");
            twinkle.Abort();
            hTimer0.Enabled = false;

            drop = new SoundPlayer(Application.StartupPath + @"\bomb.wav");
            drop.Play();

            for (int i = 1; i < 7; i++)
            {
                for (int j = 12; j > 0; j--)
                {
                    if (burstBoard[i, j] == 1)
                        gameBoard[i, j] = 87 + 3 * (puyoColor[i, j] - 2);
                    if (burstBoard[i, j] == 2)
                        gameBoard[i, j] = 103;
                }
            }
            DrawNowPuyo();
            Thread.Sleep(150);
            for (int i = 1; i < 7; i++)
            {
                for (int j = 12; j >= 0; j--)
                {
                    if (burstBoard[i, j] == 1)
                        gameBoard[i, j]++;
                    if (burstBoard[i, j] == 2)
                        gameBoard[i, j] = 104;
                }
            }
            DrawNowPuyo();
            Thread.Sleep(150);
            for (int i = 1; i < 7; i++)
            {
                for (int j = 12; j >= 0; j--)
                {
                    if (burstBoard[i, j] == 1)
                        gameBoard[i, j]++;
                    if (burstBoard[i, j] == 2)
                        gameBoard[i, j] = 105;
                }
            }
            DrawNowPuyo();
            Thread.Sleep(150);
            for (int i = 1; i < 7; i++)
            {
                for (int j = 12; j >= 0; j--)
                {
                    if (burstBoard[i, j] == 1)
                        gameBoard[i, j] = (gameBoard[i, j] - 87) / 3 + 2;
                    if (burstBoard[i, j] == 2)
                        gameBoard[i, j] = 0;
                }
            }

            int a = Int32.Parse(scoreLable.Text);
            a += 100;
            scoreLable.Text = a.ToString();

            twinkle = new Thread(Twinkle);
            twinkle.Start();
            hTimer0.Enabled = true;
        }

        private void checkhudle()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (burstBoard[i, j] == 1)
                    {
                        if (gameBoard[i + 1, j] == 102)
                            burstBoard[i + 1, j] = 2;
                        if (gameBoard[i - 1, j] == 102)
                            burstBoard[i - 1, j] = 2;
                        if (gameBoard[i, j + 1] == 102)
                            burstBoard[i, j + 1] = 2;
                        if (gameBoard[i, j - 1] == 102)
                            burstBoard[i, j - 1] = 2;
                    }
                }
            }
        }

        private void checkPuyo()
        {
            Eraser();
            if (nowRotation == 0)
            {
                burstBoardSet0();
                for (int i = 12; i > 0; i--)
                {
                    if (gameBoard[nowx + 1, i] != (int)Block.BackGround && gameBoard[nowx + 1, i - 1] == (int)Block.BackGround)
                    {
                        if (SamePuyo(nowx + 1, i, 0, 0) >= 3)
                        {
                            burstEffect();
                            DeletePuyo(nowx + 1, i, gameBoard[nowx + 1, i]);
                            gameBoard[nowx + 1, i] = 0;
                            DropBlock();
                        }
                    }
                }

                burstBoardSet0();
                for (int i = 12; i > 0; i--)
                {
                    if (gameBoard[nowx + 2, i] != (int)Block.BackGround && gameBoard[nowx + 2, i - 1] == (int)Block.BackGround)
                    {
                        if (SamePuyo(nowx + 2, i, 0, 0) >= 3)
                        {
                            burstEffect();
                            DeletePuyo(nowx + 2, i, gameBoard[nowx + 2, i]);
                            gameBoard[nowx + 2, i] = 0;
                            DropBlock();
                        }
                    }
                }
                burstBoardSet0();
            }
            else if (nowRotation == 2)
            {
                burstBoardSet0();
                for (int i = 12; i > 0; i--)
                {
                    if (gameBoard[nowx, i] != (int)Block.BackGround && gameBoard[nowx, i - 1] == (int)Block.BackGround)
                    {
                        if (SamePuyo(nowx, i, 0, 0) >= 3)
                        {
                            burstEffect();
                            DeletePuyo(nowx, i, gameBoard[nowx, i]);
                            gameBoard[nowx, i] = 0;
                            DropBlock();
                        }
                    }
                }
                burstBoardSet0();
                for (int i = 12; i > 0; i--)
                {
                    if (gameBoard[nowx + 1, i] != (int)Block.BackGround && gameBoard[nowx + 1, i - 1] == (int)Block.BackGround)
                    {
                        if (SamePuyo(nowx + 1, i, 0, 0) >= 3)
                        {
                            burstEffect();
                            DeletePuyo(nowx + 1, i, gameBoard[nowx + 1, i]);
                            gameBoard[nowx + 1, i] = 0;
                            DropBlock();
                        }
                    }
                }
                burstBoardSet0();
            }
            else if (nowRotation == 1 || nowRotation == 3)
            {
                burstBoardSet0();
                for (int i = 12; i > 0; i--)
                {
                    if (gameBoard[nowx + 1, i] != (int)Block.BackGround && gameBoard[nowx + 1, i - 1] != (int)Block.BackGround && gameBoard[nowx + 1, i - 2] == (int)Block.BackGround)
                    {
                        if (SamePuyo(nowx + 1, i, 0, 0) >= 3)
                        {
                            burstEffect();
                            DeletePuyo(nowx + 1, i, gameBoard[nowx + 1, i]);
                            gameBoard[nowx + 1, i] = 0;
                        }
                        if (puyoblock1 != puyoblock2 && SamePuyo(nowx + 1, i - 1, 0, 0) >= 3)
                        {
                            burstEffect();
                            DeletePuyo(nowx + 1, i - 1, gameBoard[nowx + 1, i - 1]);
                            gameBoard[nowx + 1, i - 1] = 0;
                        }
                        DropBlock();
                    }
                }
            }
        }
        private void burstBoardSet0()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 14; j++)
                    burstBoard[i, j] = 0;

            }
        }
        private void DeletePuyo(int x, int y, int value)
        {
            if (value > 6 && value < 88) { value = (value - 7) / 16 + 2; }

            if (x > 0 && x < 8 && y > 0 && y < 13 && gameBoard[x, y] != 102)
            {
                if (puyoColor[x + 1, y] == value)
                {
                    gameBoard[x + 1, y] = 0;
                    puyoColor[x + 1, y] = 0;
                    DeletePuyo(x + 1, y, value);
                }
                if (puyoColor[x - 1, y] == value)
                {
                    puyoColor[x - 1, y] = 0;
                    gameBoard[x - 1, y] = 0;
                    DeletePuyo(x - 1, y, value);
                }
                if (puyoColor[x, y + 1] == value)
                {
                    gameBoard[x, y + 1] = 0;
                    puyoColor[x, y + 1] = 0;
                    DeletePuyo(x, y + 1, value);
                }
                if (puyoColor[x, y - 1] == value)
                {
                    puyoColor[x, y - 1] = 0;
                    gameBoard[x, y - 1] = 0;
                    DeletePuyo(x, y - 1, value);
                }
            }
            else
                return;

        }
        private int SamePuyo(int x, int y, int state, int count)
        {
            int a = 0, b = 0, c = 0, d = 0;
            int temp;

            if (gameBoard[x, y] > 6 && gameBoard[x, y] < 88) { temp = (gameBoard[x, y] - 7) / 16 + 2; }
            else { temp = gameBoard[x, y]; }

            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    if (gameBoard[i, j] > 6 && gameBoard[x, y] < 88)
                        puyoColor[i, j] = (gameBoard[i, j] - 7) / 16 + 2;
                    else if (gameBoard[i, j] == 102)
                    {

                    }
                    else
                        puyoColor[i, j] = gameBoard[i, j];
                }
            }

            if (x > 0 && x < 8 && y > 0 && y < 13)
            {
                if (state != 2 && burstBoard[x, y + 1] == 0 && temp == puyoColor[x, y + 1])
                {
                    burstBoard[x, y] = 1;
                    burstBoard[x, y + 1] = 1;
                    count++;
                    a = SamePuyo(x, y + 1, 1, 0);
                }

                if (state != 1 && burstBoard[x, y - 1] == 0 && temp == puyoColor[x, y - 1])
                {
                    burstBoard[x, y] = 1;
                    burstBoard[x, y - 1] = 1;
                    count++;
                    b = SamePuyo(x, y - 1, 2, 0);
                }

                if (state != 4 && burstBoard[x + 1, y] == 0 && temp == puyoColor[x + 1, y])
                {
                    burstBoard[x, y] = 1;
                    burstBoard[x + 1, y] = 1;
                    count++;
                    c = SamePuyo(x + 1, y, 3, 0);
                }

                if (state != 3 && burstBoard[x - 1, y] == 0 && temp == puyoColor[x - 1, y])
                {
                    burstBoard[x, y] = 1;
                    burstBoard[x - 1, y] = 1;
                    count++;
                    d = SamePuyo(x - 1, y, 4, 0);
                }
            }
            return count + a + b + c + d;
        }

        private void You_FormClosing(object sender, FormClosingEventArgs e)
        {
            //axWindowsMediaPlayer2.Ctlcontrols.stop();
            if (isplaying)
            {
                isplaying = false;
                makeHudle.Abort();
                twinkle.Abort();
            }

        }
        private void hudle()
        {
            while (isplaying)
            {
                Thread.Sleep(10000);

                drop = new SoundPlayer(Application.StartupPath + @"\died.wav");
                drop.Play();

                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.KeyDown -= You_KeyDown;
                    twinkle.Abort();
                }));

                hTimer0.Enabled = false;
                int[,] temp = new int[4, 9];
                this.Invoke(new MethodInvoker(delegate ()
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (pattern[i, j] > 6)
                            {
                                temp[i, j] = pattern[i, j] / 16 + 2;
                            }
                            else
                            {
                                temp[i, j] = pattern[i, j];
                            }
                        }
                    }
                }));
                this.Invoke(new MethodInvoker(delegate ()
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            textBox1.AppendText(temp[i, j].ToString() + " ");
                        }
                    }
                }));
                Eraser();
                //패턴 초기화
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 9; j++)
                        pattern[i, j] = 0;
                }

                //장애물 블록 생성
                int count = 0;
                for (int i = 1; i < 7; i++)
                {
                    if (randomBlock.Next(2) % 2 == 0)
                    {
                        gameBoard[i, 0] = 102;
                        count++;
                    }
                }
                DrawNowPuyo();

                //drop
                int k = 0;
                int count2 = 0;

                while (count2 != count)
                {
                    Thread.Sleep(150);
                    for (int i = 1; i < 7; i++)
                    {
                        if (gameBoard[i, k] == 102)
                        {
                            if (k == 0 || k > 0 && gameBoard[i, k - 1] != 102)
                            {
                                if (gameBoard[i, k + 1] == 0)
                                {
                                    gameBoard[i, k + 1] = 102;
                                    gameBoard[i, k] = 0;
                                    DrawNowPuyo();
                                }
                                else if (gameBoard[i, k + 1] != 0)
                                {
                                    count2++;
                                }
                            }
                        }
                    }
                    k++;
                    if (k == 13) break;
                }
                DropBlock();
                pattern = temp;
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.KeyDown += You_KeyDown;
                    DrawNowPuyo();

                    twinkle = new Thread(Twinkle);
                    twinkle.Start();
                    hTimer0.Enabled = true;
                }));

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Width = pictureBox2.Width - 3;
            timer_count++;
            if (timer_count == 50)
            {
                pictureBox2.BackColor = Color.Red;
            }
            if (pictureBox2.Width <= 0)
            {
                makeHudle.Abort();
                //axWindowsMediaPlayer2.Ctlcontrols.stop();

                drop = new SoundPlayer(Application.StartupPath + @"\게임오버.wav");
                drop.Play();

                timer1.Stop();
                hTimer0.Stop();
                name = Microsoft.VisualBasic.Interaction.InputBox("Time Over", "랭킹저장");

                storeFile = new FileStream(Application.StartupPath + @"\Rank.txt", FileMode.Append);//파일을 열고
                writeFile = new StreamWriter(storeFile);    //스트림 초기화

                writeFile.WriteLine(name + "|" + Int32.Parse(scoreLable.Text));    //이름|점수 식으로 파일에 쓰고
                writeFile.Flush();

                writeFile.Close();
                storeFile.Dispose();
                storeFile.Close();  //리소스 해제

                Ranking ranking = new Ranking();
                ranking.Owner = this;
                ranking.name = name;
                ranking.score = Int32.Parse(scoreLable.Text);
                ranking.ShowDialog();

                this.Close();

            }
        }

        private void You_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            picturePaint(e);
            DrawNowPuyo();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //   axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.mediaCollection.getByName("back2");

        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }

        //private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        //{
        //    //axWindowsMediaPlayer2.currentPlaylist = //axWindowsMediaPlayer2.mediaCollection.getByName(Application.StartupPath + @"\back2.wav");
        //}
    }
}
