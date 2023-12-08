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

namespace OOOpj
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MyCab_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("THIS\nIS\nPLACEHOLDER");
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://spbvkid.fandom.com/ru/wiki/%D0%9E%D0%9E%D0%9E_%22%D0%9F%D0%BE%D0%BB%D0%B8%D0%BD%D0%BE%D0%BC_%D0%96%D0%B8%D0%B3%D0%B0%D0%BB%D0%BA%D0%B8%D0%BD%D0%B0%22");
        }
    }
}
