using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nQueens
{
    public partial class MainForm : Form
    {
        BoardRenderer renderer;
        PuzzleSolver solver;

        int n;
        int size;
        int leftX;
        int leftY;

        int interval;
        bool isStarted;
        bool isPaused;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            n = 4;
            size = 48;
            leftX = 180;
            leftY = 0;
            interval = 1000;
            intervalTrackBar.Value = 10;

            Reinitialize();
        }

        private void Reinitialize()
        {
            renderer = new BoardRenderer(new Point(leftX, leftY), size);
            solver = new PuzzleSolver(n);
            renderer.Board = solver.Board;
            renderer.CurrentQueen = new Point(solver.CurrentRow, solver.CurrentCol);
            if (this.Size.Height < (n + 1) * size + leftY)
            {
                this.SetClientSizeCore(this.Size.Width, (n + 2) * size + leftY);
            }
        }

        private void ClearListOfSolutions()
        {
            solutionsList.Items.Clear();
            solver.Solutions.Clear();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            renderer.Show(e.Graphics);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                StopVizualization();
                Invalidate();
            }
            else if (isStarted && e.KeyCode == Keys.Space)
            {
                if (!isPaused)
                {
                    PauseVizualization();
                }
                else
                {
                    ResumeVizualization();
                }
            }
            else if (e.KeyCode == Keys.Down && isPaused)
            {
                NextStep();
            }
        }

        private void nNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            n = (int)nNumericUpDown.Value;
            Reinitialize();
            Invalidate();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartVizualization();
            Invalidate();
        }

        private void StartVizualization()
        {
            Reinitialize();
            timer.Interval = interval;
            timer.Start();
            nNumericUpDown.Enabled = false;
            StartButton.Enabled = false;
            isStarted = true;
            isPaused = false;
            ClearListOfSolutions();
        }

        private void PauseVizualization()
        {
            timer.Stop();
            isPaused = true;
        }

        private void ResumeVizualization()
        {
            timer.Start();
            isPaused = false;
        }

        private void StopVizualization()
        {
            timer.Stop();
            nNumericUpDown.Enabled = true;
            StartButton.Enabled = true;
            isStarted = false;
            isPaused = false;
        }

        private void intervalTrackBar_ValueChanged(object sender, EventArgs e)
        {
            interval = 100 * intervalTrackBar.Value;
            timer.Interval = interval;
            intervalLabel.Text = interval.ToString() + " ms";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            NextStep();
            if (solver.IsFinished)
            {
                StopVizualization();
            }
        }

        private void NextStep()
        {
            solver.NextStep();
            renderer.CurrentQueen = new Point(solver.CurrentRow, solver.CurrentCol);
            renderer.Board = solver.Board;
            Invalidate();
            if (solver.IsSolution)
            {
                solutionsList.Items.Add("Solution " + solver.NumberOfSolutions);
            }
        }

        private void solutionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                List<int[,]> solutions = solver.Solutions;
                int index = solutionsList.SelectedIndex;
                renderer.CurrentQueen = new Point(-1, 0);
                renderer.Board = solutions[index];
                Invalidate();
            }
        }
    }
}
