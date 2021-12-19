using System;
using System.Drawing;
using System.Windows.Forms;

namespace Тетрис
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Tetris
        {
            static Random rnd = new Random();
            int KolFigur = 8;

            public class Figura
            {
                public int ti, tj, n, m, pos, maxPos;
                public int[][,] masSost;
                public int[,] mas;
                public void SelectMas()
                {
                    mas = masSost[pos];
                    n = mas.GetLength(0);
                    m = mas.GetLength(1);
                }
                public void RatateLeft()
                {
                    if (pos > 0)
                        pos--;
                    else pos = maxPos - 1;
                    SelectMas();
                }
                public void RotateRight()
                {
                    if (pos < maxPos - 1)
                        pos++;
                    else pos = 0;
                    SelectMas();
                }
            }
            class Figura0 : Figura
            {
                public Figura0()
                {
                    maxPos = 4;
                    masSost = new int[4][,]
                    {
                        new int[,] { { 1, 0 }, { 1, 0 }, { 1,1} },
                        new int[,]{ { 0, 0, 1 }, { 1,1,1} },
                        new int[,]{ {1,1},{0,1},{0,1} },
                        new int[,]{ {1,1,1},{1,0,0} }
                    };
                    pos = rnd.Next(maxPos);
                    SelectMas();
                }
            }
            class Figura1 : Figura
            {
                public Figura1()
                {
                    maxPos = 2;
                    masSost = new int[2][,]
                    {
                        new int[,] { { 0, 2 }, { 2, 2 }, { 2, 0 } },
                        new int[,] { { 2, 2, 0 },{ 0, 2, 2 } }
                    };
                    pos = rnd.Next(maxPos);
                    SelectMas();
                }
            }
            class Figura2 : Figura
            {
                public Figura2()
                {
                    maxPos = 4;
                    masSost = new int[4][,]
                    {
                        new int[,]{{0,3,0},{3,3,3}},
                        new int[,]{{3,0},{3,3},{3,0}},
                        new int[,]{{3,3,3},{ 0, 3, 0 } },
                        new int[,]{{0,3},{3,3},{0,3}}
                    };
                    pos = rnd.Next(maxPos);
                    SelectMas();
                }
            }
            class Figura3 : Figura
            {
                public Figura3()
                {
                    maxPos = 2;
                    masSost = new int[2][,]
                    {
                        new int[,]{{4,0},{4,4},{0,4}},
                        new int[,]{{0,4,4},{4,4,0}}
                    };
                    pos = rnd.Next(maxPos);
                    SelectMas();
                }
            }
            class Figura4 : Figura
            {
                public Figura4()
                {
                    maxPos = 4;
                    masSost = new int[4][,]
                    {
                        new int[,]{{0,5},{0,5},{5,5}},
                        new int[,]{{5,5,5},{0,0,5}},
                        new int[,]{{5,5},{5,0},{5,0}},
                        new int[,]{{5,0,0},{5,5,5}}
                    };
                    pos = rnd.Next(maxPos);
                    SelectMas();
                }
            }
            class Figura5 : Figura
            {
                public Figura5()
                {
                    maxPos = 1;
                    masSost = new int[1][,]
                    {
                        new int[,]{{6,6},{6,6}}
                    };
                    pos = rnd.Next(maxPos);
                    SelectMas();
                }
            }
            class Figura6 : Figura
            {
                public Figura6()
                {
                    maxPos = 2;
                    masSost = new int[2][,]
                    {
                        new int[,]{{7},{7},{7},{7}},
                        new int[,]{{7,7,7,7}}
                    };
                    pos = rnd.Next(maxPos);
                    SelectMas();
                }
            }
            public int[,] IgrPole;
            public int RowCount, ColCount;
            public int CellWidth = 25;
            public int dx = 0, dy = 0;
            public int oldInterval;
            public int Level = 1;
            public int KolBallov = 0;
            public int KolLine = 0;
            public int NextLevel1;
            public bool RestoreInterval = false;
            public bool Pause = false;
            public bool GameOver = false;
            public Timer timer;
            public Figura figura = null;
            public Figura nextfigura = null;
            public Label lLevel, lLines, lBalls;
            Graphics g;
            Brush[] masBrush = { Brushes.White, Brushes.Red, Brushes.Blue, Brushes.Green, Brushes.CornflowerBlue, Brushes.Brown, Brushes.BlueViolet, Brushes.Coral };
            Bitmap[] masBitmap;

            public void PreviewFigura(Figura f)
            {
                int x1 = dx + ColCount * CellWidth + 10, y1 = dy;
                g.FillRectangle(Brushes.White, x1, y1, 6 * CellWidth, 6 * CellWidth);
                int i, j, otstx = x1 + (6 - f.m) * CellWidth / 2, otsty = dy + (6 - f.n) * CellWidth / 2;
                for (i = 0; i < f.n; i++)
                    for (j = 0; j < f.m; j++)
                        if (f.mas[i, j] > 0)
                            g.DrawImage(masBitmap[f.mas[i, j]], otstx + j * CellWidth, otsty + i * CellWidth, CellWidth, CellWidth);
            }
            public void Show()
            {
                int i, j;
                int nb;
                for (i = 0; i < RowCount; i++)
                    for (j = 0; j < ColCount; j++)
                    {
                        if (figura == null)
                            nb = IgrPole[i, j];
                        else
                        {
                            if (i >= figura.ti && i < figura.ti + figura.n && j >= figura.tj && j < figura.tj + figura.m)
                                if (figura.mas[i - figura.ti, j - figura.tj] > 0)
                                    nb = figura.mas[i - figura.ti, j - figura.tj];
                                else
                                    nb = IgrPole[i, j];
                            else
                                nb = IgrPole[i, j];
                        }
                        g.DrawImage(masBitmap[nb], j * CellWidth + dx, i * CellWidth + dy);
                    }
            }
            void timer_Tick(object sender, EventArgs e)
            {
                if (figura == null)
                {
                    figura = nextfigura;
                    switch (rnd.Next(KolFigur))
                    {
                        case 0:
                            {
                                nextfigura = new Figura0();
                                break;
                            }
                        case 1:
                            {
                                nextfigura = new Figura1();
                                break;
                            }
                        case 2:
                            {
                                nextfigura = new Figura2();
                                break;
                            }
                        case 3:
                            {
                                nextfigura = new Figura3();
                                break;
                            }
                        case 4:
                            {
                                nextfigura = new Figura4();
                                break;
                            }
                        case 5:
                            {
                                nextfigura = new Figura5();
                                break;
                            }
                        case 6:
                            {
                                nextfigura = new Figura6();
                                break;
                            }
                    }
                    PreviewFigura(nextfigura);
                    figura.ti = -figura.n;
                    figura.tj = (ColCount - figura.m) / 2;
                }
                else
                {
                    bool f = true;
                    int i, j;
                    if (figura.ti + figura.n == RowCount)
                        f = false;
                    else
                    {
                        for (i = 0; i < figura.n; i++)
                            for (j = 0; j < figura.m; j++)
                                if (i + figura.ti + 1 >= 0)
                                    if (IgrPole[i + figura.ti + 1, j + figura.tj] > 0 && figura.mas[i, j] > 0)
                                        f = false;
                    }
                    if (f)
                    {
                        figura.ti = figura.ti + 1;
                        Show();
                    }

                    else
                    {
                        for (i = 0; i < figura.n; i++)
                            for (j = 0; j < figura.m; j++)
                            {
                                if (figura.mas[i, j] > 0 && figura.ti + i >= 0) IgrPole[figura.ti + i, figura.tj + j] = figura.mas[i, j];
                                figura.mas[i, j] = 0;
                            }
                        i = RowCount - 1;
                        while (i >= 0)
                        {
                            int k = 0;
                            for (j = 0; j < ColCount; j++)
                                if (IgrPole[i, j] == 0) k++;

                            if (k == 0)
                            {
                                for (j = 0; j < ColCount; j++) IgrPole[i, j] = 0;
                                KolBallov += ColCount * Level;
                                KolLine += 1;
                                int NextLevel = 0;
                                if (KolBallov >= NextLevel)
                                {
                                    if (timer.Interval >= 100) timer.Interval -= 50;
                                    Level += 1;
                                    NextLevel1 *= 2;
                                }
                                ShowLabel();
                                for (k = i; k > 0; k--)
                                    for (j = 0; j < ColCount; j++) IgrPole[k, j] = IgrPole[k - 1, j];
                                Show();
                            }
                            else i--;
                        }

                        if (figura.ti <= 0)
                        {
                            timer.Enabled = false;
                            if (MessageBox.Show("Хотите начать новую игру?", "Игра закончена", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                for (i = 0; i < RowCount; i++)
                                    for (j = 0; j < ColCount; j++)
                                        IgrPole[i, j] = 0;
                                figura = null;
                                timer.Enabled = true;
                                timer.Interval = 500;
                                Level = 1;
                                KolBallov = 0;
                                KolLine = 0;
                                ShowLabel();
                            }
                            else Application.Exit();
                            Show();
                        }
                        figura = null;

                    }
                }
            }
            public void ShowLabel()
            {
                lLevel.Text = "Уровень:" + Convert.ToString(Level);
                lLines.Text = "Линий:" + Convert.ToString(KolLine);
                lBalls.Text = "Очки:" + Convert.ToString(KolBallov);
            }
            public Tetris(Graphics pov, int Row, int Col)
            {
                g = pov;
                RowCount = Row;
                ColCount = Col;
                IgrPole = new int[RowCount, ColCount];
                int i, j;
                for (i = 0; i < RowCount; i++)
                    for (j = 0; j < ColCount; j++) IgrPole[i, j] = 0;
                masBitmap = new Bitmap[masBrush.Length];
                for (i = 0; i < masBitmap.Length; i++)
                {
                    masBitmap[i] = new Bitmap(CellWidth, CellWidth);
                    Graphics rectBitmap = Graphics.FromImage(masBitmap[i]);
                    rectBitmap.FillRectangle(masBrush[i], 0, 0, CellWidth, CellWidth);
                    rectBitmap.DrawRectangle(Pens.Black, 0, 0, CellWidth, CellWidth);
                }

                int NextLevel = ColCount * Level * 10;
                switch (rnd.Next(KolFigur))
                {
                    case 0:
                        {
                            nextfigura = new Figura0(); break;
                        }
                    case 1:
                        {
                            nextfigura = new Figura1(); break;
                        }
                    case 2:
                        {
                            nextfigura = new Figura2(); break;
                        }
                    case 3:
                        {
                            nextfigura = new Figura3(); break;
                        }
                    case 4:
                        {
                            nextfigura = new Figura4(); break;
                        }
                    case 5:
                        {
                            nextfigura = new Figura5(); break;
                        }
                    case 6:
                        {
                            nextfigura = new Figura6(); break;
                        }
                }
                PreviewFigura(nextfigura);
                nextfigura.ti = -nextfigura.n;
                nextfigura.tj = (ColCount - nextfigura.m) / 2;
                Font font = new Font("Arial", 14, FontStyle.Bold);
                int h = (RowCount * CellWidth - 6 * CellWidth) / 4;
                int y = dy + 6 * CellWidth + h;
                lLevel = new Label();
                lLevel.Font = font;
                lLevel.AutoSize = true;
                lLevel.Left = dx + ColCount * CellWidth + 10;
                lLevel.Top = y;

                lLines = new Label();
                lLines.Font = font;
                lLines.AutoSize = true;
                lLines.Left = lLevel.Left;
                lLevel.Top = y + h;

                lBalls = new Label();
                lBalls.Font = font;
                lBalls.AutoSize = true;
                lBalls.Left = lLevel.Left;
                lBalls.Top = y + 2 * h;

                ShowLabel();

                timer = new Timer();
                timer.Enabled = false;
                timer.Interval = 500;
                timer.Tick += timer_Tick;
                timer.Enabled = true;
            }
        }

        Tetris tetris;

        private void Form1_Load(object sender, EventArgs e)
        {
            tetris = new Tetris(Graphics.FromHwnd(this.Handle), 20, 10);
            this.Width = tetris.dx + tetris.ColCount * tetris.CellWidth + tetris.CellWidth * 6 + 25;
            this.Height = tetris.dy + tetris.RowCount * tetris.CellWidth + 37;
            lPause.Left = tetris.dx + (tetris.ColCount * tetris.CellWidth - lPause.Width) / 2;
            lPause.Top = tetris.dy + (tetris.RowCount * tetris.CellWidth - lPause.Height) / 2;
            this.Controls.Add(tetris.lLevel);
            this.Controls.Add(tetris.lLines);
            this.Controls.Add(tetris.lBalls);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Down:
                    {
                        if(!tetris.RestoreInterval)
                        {
                            tetris.oldInterval = tetris.timer.Interval;
                            tetris.timer.Interval = 1;
                            tetris.RestoreInterval = true;
                        }
                        break;
                    }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            bool f;
            int i, j;
            switch(e.KeyCode)
            {
                case Keys.Left:
                    f= true;
                    if (tetris.figura == null || tetris.Pause)
                        f = false;
                    else
                        if (tetris.figura.tj == 0)
                        f = false;
                    else
                    {
                        for (i = 0; i < tetris.figura.n; i++)
                            if (tetris.figura.ti + i >= 0)
                                for (j = 0; j < tetris.figura.m; j++)
                                    if (tetris.figura.mas[i, j] != 0 && tetris.IgrPole[tetris.figura.ti + i, tetris.figura.tj + j - 1] != 0)
                                        f = false;
                    }
                    if(f)
                    {
                        tetris.figura.tj = tetris.figura.tj - 1;
                        tetris.Show();
                    }
                    break;
                case Keys.Right:
                    f = true;
                    if (tetris.figura == null || tetris.Pause)
                        f = false;
                    else
                        if (tetris.figura.tj + tetris.figura.m == tetris.ColCount)
                        f = false;
                    else
                    {
                        for (i = 0; i < tetris.figura.n; i++)
                            if (tetris.figura.ti + i >= 0)
                                for (j = 0; j < tetris.figura.m; j++)
                                    if (tetris.figura.mas[i, j] != 0 && tetris.IgrPole[tetris.figura.ti + i,tetris.figura.tj+j+1]!=0)
                            f = false;
                    }
                    if(f)
                    {
                        tetris.figura.tj = tetris.figura.tj + 1;
                        tetris.Show();
                    }
                    break;
                case Keys.Down:
                    tetris.timer.Interval = tetris.oldInterval;
                    tetris.RestoreInterval = false;
                    break;
                case Keys.Up:
                    if (tetris.figura != null && !tetris.Pause)
                    {
                        if(tetris.figura.n!=tetris.figura.m)
                        {
                            int ci, cj, li = 0, lj = 0, pi, pj, k = 0;

                            ci = tetris.figura.ti+tetris.figura.n / 2;
                            cj = tetris.figura.tj + tetris.figura.m / 2;

                            li = ci - tetris.figura.m / 2;
                            lj = cj - tetris.figura.n/ 2;

                            pi = li + tetris.figura.m - 1;
                            pj = lj + tetris.figura.n - 1;

                            if(li>=0 && lj>=0&&pi<tetris.RowCount&&pj<tetris.ColCount)
                            {
                                for (i = li; i <= pi; i++)
                                    for (j = lj; j <= pj; j++)
                                        if (tetris.IgrPole[i, j] > 0) k++;
                                if(k==0)
                                {
                                    tetris.figura.ti = li;
                                    tetris.figura.tj = lj;
                                    tetris.figura.RotateRight();
                                    tetris.Show();
                                }

                            }
                        }
                    }
                    break;
                case Keys.Space:
                    tetris.Show();
                    tetris.PreviewFigura(tetris.nextfigura);
                    tetris.timer.Enabled = !tetris.timer.Enabled;
                    tetris.Pause = !tetris.timer.Enabled;
                    lPause.Visible = !tetris.timer.Enabled;
                    break;
            }
        }
    }
}

   

