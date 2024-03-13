using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HangmanSystem
{
    public class LetterBox : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        string _letterboxvalue = "";
        System.Drawing.Color _forecolor;


        public string LetterBoxValue
        {
            get => _letterboxvalue;
            set
            {
                _letterboxvalue = value;
                InvokePropertyChanged();
            }
        }

        public System.Drawing.Color TextColor
        {
            get => _forecolor; 
            set
            {
                _forecolor = value;
                InvokePropertyChanged();
                InvokePropertyChanged("TextColorMaui");
            }
        }
        public Microsoft.Maui.Graphics.Color TextColorMaui
        {
            get => this.ConvertToMauiColor(this.TextColor);
        }

        public Microsoft.Maui.Graphics.Color ConvertToMauiColor(System.Drawing.Color systemColor)
        {
            float red = systemColor.R / 255f;
            float green = systemColor.G / 255f;
            float blue = systemColor.B / 255f;
            float alpha = systemColor.A / 255f;

            return new Microsoft.Maui.Graphics.Color(red, green, blue, alpha);
        }


        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
