using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using WPF_BlackJack.Business;
using WPF_BlackJack.Models;

namespace WPF_BlackJack.Presentation.Views
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {

            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
