using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();         
        }
        public Action changedRGB;

        protected virtual void OnValueChanged() => changedRGB?.Invoke();       
        private RGBClass rGB = new RGBClass();
        public static int r, g, b=255;
        private void IncreaseValue(object o, EventArgs e)
        {
            Button button = (Button)o;
            switch (button.Name)
            {
                case "btnRed":
                    rGB.R += 5;
                    r=rGB.R;
                    lbRed.Content = r.ToString();
                    break;
                case "btnGreen":
                    rGB.G += 5;
                    g=rGB.G;
                    lbGreen.Content=g.ToString();
                    break;
                case "btnBlue":
                    rGB.B += 5;
                    b=rGB.B;
                    lbBlue.Content=b.ToString();
                    break;
            }
            OnValueChanged();
            changedRGB += ColorPicker;
        }
        private void DecreaseValue(object o, EventArgs e)
        {
            Label sender = (Label)o;
            switch (sender.Name)
            {
                case "lbRed":
                    rGB.R -= 5;
                    r = rGB.R;
                    lbRed.Content = r.ToString();
                    break;
                case "lbGreen":
                    rGB.G -= 5;
                    g = rGB.G;
                    lbGreen.Content = g.ToString();
                    break;
                case "lbBlue":
                    rGB.B -= 5;
                    b = rGB.B;
                    lbBlue.Content = b.ToString();
                    break;
            }
            OnValueChanged();
            changedRGB += ColorPicker;
        }
        private void ColorPicker()
        {
            Color color = Color.FromRgb(((byte)r), ((byte)g), ((byte)b));
            lbColorPicker.Background = new SolidColorBrush(color);
            tbRGBvalues.Text = $"#{r}{g}{b}";
        }

        private void lbRed_MouseDoubleClick(object sender, MouseButtonEventArgs e) => DecreaseValue(sender,e);

        private void lbGreen_MouseDoubleClick(object sender, MouseButtonEventArgs e) => DecreaseValue(sender, e);

        private void lbBlue_MouseDoubleClick(object sender, MouseButtonEventArgs e) => DecreaseValue(sender, e);

        private void btnRed_Click(object sender, RoutedEventArgs e) => IncreaseValue(sender, e);

        private void btnGreen_Click(object sender, RoutedEventArgs e) =>  IncreaseValue(sender,e);

        private void btnBlue_Click(object sender, RoutedEventArgs e) =>  IncreaseValue(sender,e);
        
    }
}