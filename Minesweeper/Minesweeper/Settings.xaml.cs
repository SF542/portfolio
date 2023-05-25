using System.Windows;

namespace Minesweeper
{
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (chb.IsChecked == true)
                Data.sound = true;
            else
                Data.sound = false;
            MainWindow menu = new MainWindow();
            this.Hide();
            menu.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Data.sound == true)
                chb.IsChecked = true;
            else
                chb.IsChecked = false;
        }
    }
}
