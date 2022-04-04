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

namespace Кенийские_башни
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Help_Class a = new Help_Class();
            a.RingsCount = Int32.Parse((string)((ComboBoxItem)rings_count.SelectedItem).Content);

            if (mode.SelectedIndex == 0)
            {
                Manual_Window manual_window = new Manual_Window(a);
                manual_window.ShowDialog();
            }
            else
            {
                Auto_Window auto_window = new Auto_Window(a);
                auto_window.ShowDialog();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /*System.Diagnostics.Process.GetCurrentProcess().Kill();*/
        }
    }
}
