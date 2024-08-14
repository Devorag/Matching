﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MatchingSystem
{
    public class Game : INotifyPropertyChanged
    {
        public System.Drawing.Color _backColor = System.Drawing.Color.CornflowerBlue;
        public System.Drawing.Color _foreColor = System.Drawing.Color.Black;
        public ObservableCollection<Square> squares { get; private set; } = new();
        public ObservableCollection<Square> mismatchedSquares = new();

        List<string> icons = new()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        private Random random = new Random();

        public event PropertyChangedEventHandler? PropertyChanged;
        public event Action? OnMismatch;
        public event Action? OnGameComplete;


        public Square? FirstClicked { get; private set; }
        public Square? SecondClicked { get; private set; }

        public System.Drawing.Color SquareBackColor
        {
            get => _backColor;
            set
            {
                if (_backColor != value)
                {
                    _backColor = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged("BackColorMaui");
                }
            }
        }

        public System.Drawing.Color SquareForeColor
        {
            get => _foreColor;
            set
            {
                if (_foreColor != value)
                {
                    _foreColor = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged("ForeColorMaui");
                }
            }
        }

        public Microsoft.Maui.Graphics.Color ForeColorMaui
        {
            get => this.ConvertToMauiColor(this.SquareForeColor);
        }

        public Microsoft.Maui.Graphics.Color BackColorMaui
        {
            get => this.ConvertToMauiColor(this.SquareBackColor);
        }

        public void StartGame()
        {
            this.squares.Clear();
            for (int i = 0; i < 16; i++)
            {
                this.squares.Add(new Square { BackColor = _backColor });
            }
            AssignIconsToSquares();
            OnPropertyChanged(nameof(squares));
        }

        private void AssignIconsToSquares()
        {
            var shuffledIcons = icons.OrderBy(x => random.Next()).ToList();
            for (int i = 0; i < squares.Count; i++)
            {
                this.squares[i].Text = shuffledIcons[i];
                this.squares[i].ForeColor = SquareBackColor;
            }
        }

        public void HandleClick(Square clickedSquare)
        {
            if (FirstClicked == null)
            {
                FirstClicked = clickedSquare;
                FirstClicked.ForeColor = SquareForeColor;
            }
            else
            {
                SecondClicked = clickedSquare;
                SecondClicked.ForeColor = SquareForeColor;
                CheckForMatch();

                if (IsGameComplete())
                {
                    OnGameComplete?.Invoke();
                }
            }
        }

        public void HandleLabelClick(int index)
        {
            if (index < 0 || index >= this.squares.Count) return;

            Square clickedSquare = this.squares[index];
            HandleClick(clickedSquare);

            if (IsGameComplete())
            {
                OnGameComplete?.Invoke();
            }
        }

        private void CheckForMatch()
        {
            if (FirstClicked?.Text == SecondClicked?.Text)
            {
                FirstClicked = null;
                SecondClicked = null;
            }
            else
            {
                mismatchedSquares.Clear();
                mismatchedSquares.Add(FirstClicked);
                mismatchedSquares.Add(SecondClicked);
                OnMismatch?.Invoke();
            }
        }

        public void ResetClickedSquares()
        {
            foreach (var square in mismatchedSquares)
            {
                square.ForeColor = square.BackColor;
            }
            mismatchedSquares.Clear();
            FirstClicked = null;
            SecondClicked = null;
        }

        public bool IsGameComplete()
        {
            return squares.All(squares => squares.ForeColor == SquareForeColor);
        }

        public async Task HandleGameComplete()
        {
            await Task.Delay(200); 
            OnGameComplete?.Invoke();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Microsoft.Maui.Graphics.Color ConvertToMauiColor(System.Drawing.Color systemColor)
        {
            float red = systemColor.R / 255f;
            float green = systemColor.G / 255f;
            float blue = systemColor.B / 255f;
            float alpha = systemColor.A / 255f;

            return new Microsoft.Maui.Graphics.Color(red, green, blue, alpha);
        }
    }
}