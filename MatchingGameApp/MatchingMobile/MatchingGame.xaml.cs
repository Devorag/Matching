using MatchingSystem;
using System.Collections.ObjectModel;

namespace MatchingMobile
{
    public partial class MatchingGame : ContentPage
    {
        private Game game = new();
        private ObservableCollection<Button> lstButtons;
        private IDispatcherTimer timer;
        private bool isProcessing = false;

        public MatchingGame()
        {
            InitializeComponent();
            this.BindingContext = game;
            lstButtons = new ObservableCollection<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16 };

            timer = Dispatcher.CreateTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;

            game.OnMismatch += HandleMismatch;
            game.OnGameComplete += async () => await Game_OnGameComplete();

            for (int i = 0; i < lstButtons.Count; i++)
            {
                var button = lstButtons[i];
                button.AutomationId = i.ToString();
            }
        }

        private async Task Game_OnGameComplete()
        {
            if (isProcessing) return;
            await Task.Delay(200);
            Messagelbl.Text = "Congratulations you won the game!";
        }

        private void HandleMismatch()
        {
            if (!isProcessing)
            {
                isProcessing = true;
                timer.Start();
            }
        }
//AS Move code out of event handler
        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop();

            foreach (var square in game.mismatchedSquares)
            {
                var buttonIndex = game.squares.IndexOf(square);
                var button = lstButtons.FirstOrDefault(btn => btn.AutomationId == buttonIndex.ToString());
                if (button != null)
                {
                    button.BackgroundColor = square.BackColorMaui;
                }
            }

            game.ResetClickedSquares();
            isProcessing = false;
        }
//AS Move code out of event handler
        private void btn_Clicked(object sender, EventArgs e)
        {
            if (isProcessing) return;

            if (sender is Button button && int.TryParse(button.AutomationId, out int index))
            {
                var square = game.squares[index];
                game.HandleClick(square);

                if (game.FirstClicked != null && game.SecondClicked != null)
                {
                    isProcessing = true;
                }
            }
        }

        private void StartBtn_Clicked_1(object sender, EventArgs e)
        {
            Messagelbl.Text = "";
            game.StartGame();
        }
    }
}
