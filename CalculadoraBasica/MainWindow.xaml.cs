
using System.Windows;


namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int resultado;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void OperadorTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            if (operadorTextBox.Text == "+" ||
                operadorTextBox.Text == "-" ||
                operadorTextBox.Text == "*" ||
                operadorTextBox.Text == "/" )
            {
                calcularButton.IsEnabled = true;
            }
            else
            {
                calcularButton.IsEnabled = false;
            }
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(operando1TextBox.Text, out resultado) && int.TryParse(operando2TextBox.Text, out resultado))
            {
                if (operadorTextBox.Text == "+")
                {
                    resultado = int.Parse(operando1TextBox.Text) + int.Parse(operando2TextBox.Text);
                }
                else if (operadorTextBox.Text == "-")
                {
                    resultado = int.Parse(operando1TextBox.Text) - int.Parse(operando2TextBox.Text);
                }
                else if (operadorTextBox.Text == "*")
                {
                    resultado = int.Parse(operando1TextBox.Text) * int.Parse(operando2TextBox.Text);
                }
                else
                {
                    resultado = int.Parse(operando1TextBox.Text) / int.Parse(operando2TextBox.Text);
                }

                resultadoTextBox.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Se ha producido un error. Revisa los operandos.");
            }
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Text = "";
            operando2TextBox.Text = "";
            operadorTextBox.Text = "";
            resultadoTextBox.Text = "";
        }
    }
}
