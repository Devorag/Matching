using MatchingSystem;
using System.Collections.ObjectModel;

namespace MatchingMobile
{
    public partial class MatchingGame : ContentPage
    {
        Game activegame;
        List<Game> lstGame = new() { new Game(), new Game(), new Game() };
        ObservableCollection<Button> lstButtons;
        IDispatcherTimer timer;
        private bool isProcessing = false;

        public MatchingGame()
        {
            InitializeComponent();
            Game1Rb.BindingContext = lstGame[0];
            Game2Rb.BindingContext = lstGame[1];
            Game3Rb.BindingContext = lstGame[2];
            activegame = lstGame[0];
            this.BindingContext = activegame;
            lstButtons = new ObservableCollection<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16 };

            timer = Dispatcher.CreateTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;

            activegame.OnMismatch += HandleMismatch;
            activegame.OnGameComplete += HandleGameComplete;


            for (int i = 0; i < lstButtons.Count; i++)
            {
                var button = lstButtons[i];
                button.AutomationId = i.ToString();

            }
        }

        private void HandleMismatch()
        {
            if (!isProcessing)
            {
                isProcessing = true;
                timer.Start();
            }
        }

        private void TimerTick()
        {
            timer.Stop();

            foreach (var square in activegame.mismatchedSquares)
            {
                var buttonIndex = activegame.squares.IndexOf(square);
                var button = lstButtons.FirstOrDefault(btn => btn.AutomationId == buttonIndex.ToString());
                if (button != null)
                {
                    button.BackgroundColor = square.BackColorMaui;
                }
            }

            activegame.ResetClickedSquares();
            isProcessing = false;
            EnableAllButtons();
        }
        private void DisableAllButtons()
        {
            foreach (var button in lstButtons) { button.IsEnabled = false; }
        }

        private void EnableAllButtons()
        {
            foreach (var button in lstButtons)
            {
                var buttonIndex = int.Parse(button.AutomationId);
                if (!activegame.squares[buttonIndex].IsMatched)
                {
                    button.IsEnabled = true;
                }
            }
        }

        //AS Move code out of event handler
        private void Timer_Tick(object? sender, EventArgs e)
        {
            TimerTick();
        }
        //AS Move code out of event handler
        private void btn_Clicked(object sender, EventArgs e)
        {
            if (isProcessing) return;

            if (sender is Button button && int.TryParse(button.AutomationId, out int index))
            {
                activegame.HandleLabelClick(index);
                if (activegame.FirstClicked != null && activegame.SecondClicked != null)
                {
                    DisableAllButtons();
                    isProcessing = true;
                }
            }
        }

        private void StartBtn_Clicked_1(object sender, EventArgs e)
        {
            Messagelbl.Text = "";
            activegame.StartGame();
        }

        private void Game_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                RadioButton rb = (RadioButton)sender;
                if (rb.BindingContext is Game selectedGame)
                {
                    activegame.OnMismatch -= HandleMismatch;
                    activegame.OnGameComplete -= HandleGameComplete;
                    activegame = selectedGame;
                    activegame.OnMismatch += HandleMismatch;
                    activegame.OnGameComplete += HandleGameComplete;
                    this.BindingContext = activegame;
                }
            }
        }
        private async Task HandleGameComplete()
        {   
            Messagelbl.Text = "Congratulations! You've won the game!";
            await Task.CompletedTask;
        }
    }
}
