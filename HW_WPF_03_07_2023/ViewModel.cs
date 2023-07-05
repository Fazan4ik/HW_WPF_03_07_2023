using System;
using System.Windows.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Data;
using System.Globalization;

namespace HW_WPF_03_07_2023
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ColorMVVM color;
        private Color backgroundColor;

        public ViewModel()
        {
            color = new ColorMVVM();
        }

        public int AlphaChannel
        {
            get => color.Alpha;
            set
            {
                color.Alpha = value;
                OnPropertyChanged("AlphaChannel");
                UpdateBackgroundColor();
            }
        }

        public int RedChannel
        {
            get => color.Red;
            set
            {
                color.Red = value;
                OnPropertyChanged("RedChannel");
                UpdateBackgroundColor();
            }
        }

        public int GreenChannel
        {
            get => color.Green;
            set
            {
                color.Green = value;
                OnPropertyChanged("GreenChannel");
                UpdateBackgroundColor();
            }
        }

        public int BlueChannel
        {
            get => color.Blue;
            set
            {
                color.Blue = value;
                OnPropertyChanged("BlueChannel");
                UpdateBackgroundColor();
            }
        }

        public Color BackgroundColor
        {
            get => backgroundColor;
            set
            {
                backgroundColor = value;
                OnPropertyChanged("BackgroundColor");
            }
        }


        private void UpdateBackgroundColor()
        {
            BackgroundColor = Color.FromArgb((byte)AlphaChannel, (byte)RedChannel, (byte)GreenChannel, (byte)BlueChannel);
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, e);
            }
        }
    }
}
