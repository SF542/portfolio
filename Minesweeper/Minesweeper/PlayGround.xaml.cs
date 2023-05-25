using System;
using System.Windows;
using System.Windows.Controls;

namespace Minesweeper
{
    public partial class PlayGround : Window
    {
        public PlayGround()
        {
            InitializeComponent();
            Data.ChangeCounter += Data_ChangeCounter;
        }

        ~PlayGround()
        {
            Data.ChangeCounter -= Data_ChangeCounter;
        }

        private void Data_ChangeCounter(int obj)
        {
            tbBlock.Text = obj.ToString();
        }

        Button[,] Bt;
        int rs = Data.rows;
        int clms = Data.columns;
        int mns = Data.mines;
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            Field.Children.Clear();
            MinesGround minesfield = new MinesGround();
            Bt = minesfield.PrintCells(rs, clms, Field, new Random(), mns);
            tbBlock.Text = Data.mines.ToString();
            UpdateLayout();
            this.SizeToContent = SizeToContent.WidthAndHeight;
            Data.Counter = Data.mines;
        }

        private void PlayGround_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void PlayGround1_Loaded(object sender, RoutedEventArgs e)
        {
            MinesGround minesfield = new MinesGround();
            Bt = minesfield.PrintCells(rs, clms, Field, new Random(), mns);
            UpdateLayout();
            this.SizeToContent = SizeToContent.WidthAndHeight;
            tbBlock.Text = Data.Counter.ToString();
        }
    }
}
