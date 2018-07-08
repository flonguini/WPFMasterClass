using System.Windows;

namespace Calculator
{
    public class SimpleMath
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double Substract(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double Divide(double number1, double number2)
        {
            if (number2 == 0)
            {
                MessageBox.Show("Division by 0 is not suported", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return 0;
            }
            return number1 / number2;
        }
    }
}
