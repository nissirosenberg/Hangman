using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HangmanSystem
{
    public class LetterButton : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        System.Drawing.Color _buttoncolor;
        bool _buttonenabled = false;
        public Microsoft.Maui.Graphics.Color _buttoncolormaui;

        public System.Drawing.Color ButtonColor
        {
            get => _buttoncolor;
            set
            {
                _buttoncolor = value;
                InvokePropertyChanged();
                InvokePropertyChanged("ButtonColorMaui");
            }
        }

        public Microsoft.Maui.Graphics.Color ButtonColorMaui
        {
            get => this.ConvertToMauiColor(this.ButtonColor);
            set
            {
                _buttoncolormaui = value;
                InvokePropertyChanged();
            }
        }

        public Microsoft.Maui.Graphics.Color ConvertToMauiColor(System.Drawing.Color systemColor)
        {
            float red = systemColor.R / 255f;
            float green = systemColor.G / 255f;
            float blue = systemColor.B / 255f;
            float alpha = systemColor.A / 255f;

            return new Microsoft.Maui.Graphics.Color(red, green, blue, alpha);
        }
        public bool ButtonEnabled
        {
            get => _buttonenabled; set
            {
                _buttonenabled = value;
                InvokePropertyChanged();
            }
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


    }
}
