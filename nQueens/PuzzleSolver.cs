using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nQueens
{
    public struct Pair
    {
        public int row, col;
        public Pair(int r, int c)
        {
            row = r;
            col = c;
        }
    }

    class PuzzleSolver
    {
        int n;
        int resultsNumber;

        int row = -1;
        int col;

        Stack<Pair> stk;
        int[,] board;

        bool isSolution;
        bool isFinished;

        List<int[,]> solutions;

        public PuzzleSolver(int n)
        {
            this.n = n;
            board = new int[n, n];
            stk = new Stack<Pair>();
            stk.Push(new Pair(0, 0));
            solutions = new List<int[,]>();
        }

        public void NextStep()
        {
            if (stk.Count != 0)
            {
                row = stk.Peek().row;
                col = stk.Peek().col;

                if (col == n)
                {
                    isSolution = true;
                    solutions.Add((int[,])board.Clone());
                    ++resultsNumber;
                    stk.Pop();
                    RemoveQueen(stk.Peek().row - 1, stk.Peek().col);
                }
                else if (row == n)
                {
                    isSolution = false;
                    stk.Pop();
                    if (stk.Count != 0)
                    {
                        RemoveQueen(stk.Peek().row - 1, stk.Peek().col);
                    }
                }
                else if (CheckQueen(row, col))
                {
                    isSolution = false;
                    PutQueen(row, col);
                    stk.Pop();
                    stk.Push(new Pair(row + 1, col));
                    stk.Push(new Pair(0, col + 1));
                }
                else
                {
                    isSolution = false;
                    stk.Pop();
                    stk.Push(new Pair(row + 1, col));
                }
            }
            else
            {
                isFinished = true;
            }
        }

        private void PutQueen(int row, int col)
        {
            if (0 <= row && row < n && 0 <= col && col < n)
                board[row, col] = 1;
        }

        private void RemoveQueen(int row, int col)
        {
            if (0 <= row && row < n && 0 <= col && col < n)
                board[row, col] = 0;
        }

        private bool CheckQueen(int row, int col)
        {
            if (0 <= row && row < n && 0 <= col && col < n)
            {
                for (int i = 0; i < n; ++i)
                {
                    if (board[i, col] == 1 || board[row, i] == 1)
                        return false;
                    if (0 <= row - i && 0 <= col - i && board[row - i, col - i] == 1)
                        return false;
                    if (row + i < n && col + i < n && board[row + i, col + i] == 1)
                        return false;
                    if (0 <= row - i && col + i < n && board[row - i, col + i] == 1)
                        return false;
                    if (row + i < n && 0 <= col - i && board[row + i, col - i] == 1)
                        return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public int NumberOfSolutions
        {
            get 
            { 
                return resultsNumber; 
            }
        }

        public int[,] Board
        {
            get 
            { 
                return board; 
            }
        }

        public int CurrentRow
        {
            get 
            { 
                return row; 
            }
        }

        public int CurrentCol
        {
            get 
            { 
                return col; 
            }
        }

        public bool IsSolution
        {
            get 
            {
                return isSolution;
            }
        }

        public bool IsFinished
        {
            get { return isFinished; }
        }

        public List<int[,]> Solutions
        {
            get
            {
                return solutions;
            }
        }
    }
}
