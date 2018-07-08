using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double _lastNumber, _result;
        SelectedOperator _selectedOperator;

        public MainWindow()
        {
            InitializeComponent();
            Result.Text = "0";
            AC.Click += AC_Click; //Define os eventos para os botões
            Invert.Click += Invert_Click;
            Percent.Click += Percent_Click;
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(Result.Text.ToString(), out double newNumber)) // Declaração do número novo dentro do argumento
            {
                switch (_selectedOperator)
                {
                    case SelectedOperator.Addition:
                        _result = SimpleMath.Add(_lastNumber, newNumber);
                        break;
                    case SelectedOperator.Substraction:
                        _result = SimpleMath.Substract(_lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        _result = SimpleMath.Multiply(_lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        _result = SimpleMath.Divide(_lastNumber, newNumber);
                        break;
                }
            }

            Result.Text = $"{_result}";
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int selectValue = 0;

            if (sender == Button0)
                selectValue = 0;
            if (sender == Button1)
                selectValue = 1;
            if (sender == Button2)
                selectValue = 2;
            if (sender == Button3)
                selectValue = 3;
            if (sender == Button4)
                selectValue = 4;
            if (sender == Button5)
                selectValue = 5;
            if (sender == Button6)
                selectValue = 6;
            if (sender == Button7)
                selectValue = 7;
            if (sender == Button8)
                selectValue = 8;
            if (sender == Button9)
                selectValue = 9;

            if (Result.Text.ToString() == "0")
                Result.Text = $"{selectValue}";
            else
                Result.Text = $"{Result.Text}{selectValue}"; //$ Concatena strings
        }

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Result.Text.ToString(), out _lastNumber))
            {
                Result.Text = "0";
            }

            if (sender == Multiply)
                _selectedOperator = SelectedOperator.Multiplication;
            if (sender == Adition)
                _selectedOperator = SelectedOperator.Addition;
            if (sender == Divide)
                _selectedOperator = SelectedOperator.Division;
            if (sender == Minus)
                _selectedOperator = SelectedOperator.Substraction;
        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.ToString().Contains(","))
            {
                // Do Nothing
            }
            else
            {
                if (double.TryParse(Result.Text, out _lastNumber))
                {
                    Result.Text = $"{_lastNumber},";
                }
            }
        }

    }
}
