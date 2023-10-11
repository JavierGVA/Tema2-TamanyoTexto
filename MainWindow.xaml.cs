using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_TamanyoTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mouse_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Tag.ToString() == "rpequenyo") {
                texto.FontSize = 36;
            }
            else if (radioButton.Tag.ToString() == "rmediano")
            {
                texto.FontSize = 48;
            }
            else
            {
                texto.FontSize = 72;
            }

        }
    }
}
