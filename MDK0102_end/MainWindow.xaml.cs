using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace MDK0102_UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_LayoutUpdated(object sender, EventArgs e)
        {

            if (InputX.Text != "" && InputX.Text != null && InputX.Text != " " &&
                InputY.Text != "" && InputY.Text != null && InputY.Text != " ")
            {
                try
                {
                    MathManager MM = new MathManager();
                    double x = Convert.ToDouble(InputX.Text);
                    double y = Convert.ToDouble(InputY.Text);

                    LabelModuleA.Content = MM.ModuleA(x, y);
                    LabelModuleS.Content = MM.ModuleS(x, y);
                }
                catch (FormatException)
                {
                    MessageBox.Show($"Неверный формат строки", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    InputX.Text = null;
                    InputY.Text = null;
                }
                catch (Exception ee)
                {
                    MessageBox.Show($"{ee}", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    InputX.Text = null;
                    InputY.Text = null;
                }
            }
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
