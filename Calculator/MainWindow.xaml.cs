using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double _lastNumber, _result;

        public MainWindow()
        {
            InitializeComponent();
            Result.Text = "0";
            AC.Click += AC_Click; //Define os eventos para os botões
            Invert.Click += Invert_Click;
            Percent.Click += Percent_Click;
            Equal.Click += Equal_Click;
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Result.Text, out _lastNumber))
            {
                _lastNumber /= 100;
                Result.Text = _lastNumber.ToString();
            }
        }

        private void Invert_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Result.Text, out _lastNumber))
            {
                _lastNumber *= -1;
                Result.Text = _lastNumber.ToString();
            }
        }

        private void AC_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "0";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.ToString() == "0")
                Result.Text = "8";
            else
                Result.Text = $"{Result.Text}8"; //$ Concatena strings
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.ToString() == "0")
                Result.Text = "9";
            else
                Result.Text = $"{Result.Text}9"; //$ Concatena strings
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.ToString() == "0")
                Result.Text = "4";
            else
                Result.Text = $"{Result.Text}4"; //$ Concatena strings
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.ToString() == "0")
                Result.Text = "5";
            else
                Result.Text = $"{Result.Text}5"; //$ Concatena strings
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.ToString() == "0")
                Result.Text = "6";
            else
                Result.Text = $"{Result.Text}6"; //$ Concatena strings
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.ToString() == "0")
                Result.Text = "1";
            else
                Result.Text = $"{Result.Text}1"; //$ Concatena strings
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.ToString() == "0")
                Result.Text = "2";
            else
                Result.Text = $"{Result.Text}2"; //$ Concatena strings
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.ToString() == "0")
                Result.Text = "3";
            else
                Result.Text = $"{Result.Text}3"; //$ Concatena strings
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.ToString() == "0")
                Result.Text = "0";
            else
                Result.Text = $"{Result.Text}0"; //$ Concatena strings
        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Equal_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.ToString() == "0")
                Result.Text = "7";
            else
                Result.Text = $"{Result.Text}7"; //$ Concatena strings
        }
    }
}
