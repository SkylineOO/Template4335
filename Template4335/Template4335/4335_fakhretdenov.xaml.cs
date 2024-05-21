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
using System.Windows.Shapes;

namespace Template4335
{
    /// <summary>
    /// Логика взаимодействия для _4335_fakhretdenov.xaml
    /// </summary>
    public partial class _4335_fakhretdenov : Window
    {
        public _4335_fakhretdenov()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow maindWindow = new MainWindow();
            maindWindow.Show();
            this.Close();
        }
    }
}
