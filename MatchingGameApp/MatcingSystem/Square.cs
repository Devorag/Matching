using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MatchingSystem
{
    public class Square : INotifyPropertyChanged
    {
        System.Drawing.Color _backColor = System.Drawing.Color.CornflowerBlue;
        System.Drawing.Color _foreColor = System.Drawing.Color.Black;
        public string _text = string.Empty;

        public event PropertyChangedEventHandler? PropertyChanged;

        public System.Drawing.Color BackColor
        {
            get => _backColor;
            set
            {
                if (_backColor != value)
                {
                    _backColor = value;
                    OnPropertyChanged();
                    this.OnPropertyChanged("BackColorMaui");
                }
            }
        }

        public System.Drawing.Color ForeColor
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

        public string Text
        {
            get => _text;
            set
            {
                if (_text != value)
                {
                    _text = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged("ForeColorMaui");
                }
            }
        }

        public Microsoft.Maui.Graphics.Color ForeColorMaui
        {
            get => this.ConvertToMauiColor(this.ForeColor);
        }


        public Microsoft.Maui.Graphics.Color BackColorMaui
        {
            get => this.ConvertToMauiColor(this.BackColor);
        }

        public void Clear()
        {
            Text = string.Empty;
            BackColor = System.Drawing.Color.CornflowerBlue;
            ForeColor = BackColor;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Microsoft.Maui.Graphics.Color ConvertToMauiColor(System.Drawing.Color systemColor)
        {
            float red = systemColor.R / 255f;
            float green = systemColor.G / 255f;
            float blue = systemColor.B / 255f;
            float alpha = systemColor.A / 255f;

            return new Microsoft.Maui.Graphics.Color(red, green, blue, alpha);
        }

    }
}
