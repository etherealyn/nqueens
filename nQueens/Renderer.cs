using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace nQueens
{
    class BoardRenderer
    {
        Point location;
        SolidBrush brush;
        Pen pen;
        int size;
        int[,] board;

        int n;
        bool[] columns;

        int[] rows;
        int[] diag1;
        int[] diag2;

        Point currentQueen;
        Image queen;
        Image queeng;

        public BoardRenderer(Point location, int size)
        {
            this.location = location;
            this.size = size;
            pen = new Pen(Color.DimGray);
            queen = Image.FromFile(@"images\q48.png");
            queeng = Image.FromFile(@"images\q48g.png");
        }

        public int[,] Board
        {
            get
            {
                return board;
            }
            set
            {
                board = value;
                n = board.GetLength(0);
                columns = new bool[n];

                rows = new int[n];
                diag1 = new int[2 * n + 1];
                diag2 = new int[2 * n + 1];
            }
        }

        public Point CurrentQueen
        {
            get
            {
                return currentQueen;
            }
            set
            {
                currentQueen = value;
            }
        }

        public void Show(Graphics g)
        {
            Update();
            for (int i = 0; i < n; ++i)
            {
                if (!columns[i]) 
                    g.DrawImage(queen, location.X + i * size, location.Y);
            }

            for (int i = 0; i < n; ++i)
            {
                int y = location.Y + i * size;
                for (int j = 0; j < n; ++j)
                {
                    int x = location.X + j * size;
                    if ((i + j) % 2 != 0)
                        brush = new SolidBrush(Color.Gray);
                    else
                        brush = new SolidBrush(Color.GhostWhite);

                    //if (diag1[i - j + n - 1] || diag2[i + j] || columns[j])
                        //brush = new SolidBrush(Color.Green);
                    
                    g.FillRectangle(brush, x, size + y, size, size);

                    if (board[i, j] == 1 || currentQueen.X == i && currentQueen.Y == j)
                    {
                        if (columns[j])
                        {
                            if (rows[i] == 1 && diag1[i - j + n - 1] == 1 && diag2[i + j] == 1)
                                g.DrawImage(queen, x, size + y);
                            else
                                g.DrawImage(queeng, x, size + y);
                        }
                    }
                }
            }
            g.DrawRectangle(pen, location.X, location.Y + size, board.GetLength(0) * size, board.GetLength(1) * size);
        }

        private void Update()
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (board[j, i] == 1 || j == currentQueen.X && i == currentQueen.Y)
                    {
                        columns[i] = true;

                        rows[j]++;
                        diag1[j - i + n - 1]++;
                        diag2[i + j]++;
                        break;
                    }
                }
            }
        }
    }
}
