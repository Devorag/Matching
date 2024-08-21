using MatchingSystem;

namespace MatchingGame
{
    public partial class frmMatchingGame : Form
    {
        private Game game = new();
        private List<Label> lstLabels;
        private System.Windows.Forms.Timer timer = new() { Interval = 950 };
        private bool isProcessing = false;

        public frmMatchingGame()
        {
            InitializeComponent();
            lstLabels = new() { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11, lbl12, lbl13, lbl14, lbl15, lbl16 };
            InitializeGameBoard();

            game.OnMismatch += HandleMismatch;
            game.OnGameComplete += async () =>
            {
                if (isProcessing) return;
                MessageBox.Show("Congratulations! You've matched all the cards!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            for (int i = 0; i < lstLabels.Count; i++)
            {
                var label = lstLabels[i];
                label.Tag = i;
                label.Click += Label_Click;
            }

            timer.Tick += Timer_Tick;
            BtnStart.Click += BtnStart_Click;

            
        }


        private void InitializeGameBoard()
        {
            lstLabels.ForEach(lbl =>
            {
                lbl.BackColor = Color.CornflowerBlue;
                lbl.ForeColor = Color.CornflowerBlue;
                lbl.Text = string.Empty;
                lbl.Enabled = false;
            });
            BtnStart.Enabled = true;
        }

        private void StartGame()
        {
            game.StartGame();
            for (int i = 0; i < lstLabels.Count; i++)
            {
                var square = game.squares[i];
                var label = lstLabels[i];
                label.Tag = i;
                label.BackColor = square.BackColor;
                label.ForeColor = square.ForeColor;
                label.Text = square.Text;
            }
            ControlsEnabled();
        }

        private void ControlsEnabled()
        {
            foreach (Control c in tblBoard.Controls)
            {
                c.Enabled = true;
            }
            BtnStart.Enabled = true;
        }

        private void HandleMismatch()
        {
            timer.Start();
        }

        private void TimerTick()
        {
            timer.Stop();

            foreach (var square in game.mismatchedSquares)
            {
                var label = lstLabels.FirstOrDefault(lbl => lbl.Tag is int index && game.squares[index] == square);
                if (label != null)
                {
                    label.ForeColor = square.BackColor;
                }
            }

            game.ResetClickedSquares();
            isProcessing = false;
        }
        private void Label_Click(object? sender, EventArgs e)
        {
            if (isProcessing || !(sender is Label clickedLabel) || !(clickedLabel.Tag is int index)) return;

            game.HandleLabelClick(index);
            clickedLabel.ForeColor = game.squares[index].ForeColor;
            isProcessing = game.FirstClicked != null && game.SecondClicked != null;
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            TimerTick();
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
    }
}
