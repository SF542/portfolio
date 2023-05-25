using System;
using System.Windows;

namespace Minesweeper
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void BeforePlayWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menu = new MainWindow();
            this.Hide();
            menu.Show();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tb1.Visibility = Visibility.Visible;
            tb2.Visibility = Visibility.Visible;
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            tb1.Text = "9x9";
            tb2.Text = "10";
            tb1.Visibility = Visibility.Hidden;
            tb2.Visibility = Visibility.Hidden;
        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            tb1.Text = "17x17";
            tb2.Text = "50";
            tb1.Visibility = Visibility.Hidden;
            tb2.Visibility = Visibility.Hidden;
        }
        private void rb3_Checked_1(object sender, RoutedEventArgs e)
        {
            tb1.Text = "31x31";
            tb2.Text = "220";
            tb1.Visibility = Visibility.Hidden;
            tb2.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (tb1.Text == "" || tb2.Text == "")
            {
                MessageBox.Show("Выберите сложность");
            }
            else
            {
                string[] size = tb1.Text.Split('x');
                Data.rows = Convert.ToInt32(size[1]);
                Data.columns = Convert.ToInt32(size[0]);
                Data.mines = Convert.ToInt32(tb2.Text);
                PlayGround playGround = new PlayGround();
                playGround.Show();
                this.Hide();
            }
        }
    }
}
