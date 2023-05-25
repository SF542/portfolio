using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Input;

namespace Minesweeper
{
    internal class MinesGround
    {
        int FlagsCounter = Data.mines;
        int LocalFlagsCounter = 0;
        int LocalMinesFlagsCounter = 0;
        GameButton[,] Bt;
        public GameButton[,] PrintCells(int rows, int columns, Grid grid, Random rnd, int mines)
        {
            Data.Counter = Data.mines;
            Bt = new GameButton[rows, columns];
            float l = -rows / 2;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Bt[i, j] = new GameButton();
                    Bt[i, j].Height = 20;
                    Bt[i, j].Width = 20;
                    Bt[i, j].Margin = new Thickness(40 * l, 20 * j, 0, 0);
                    Bt[i, j].HorizontalAlignment = HorizontalAlignment.Center;
                    Bt[i, j].VerticalAlignment = VerticalAlignment.Top;
                    Bt[i, j].Click += new RoutedEventHandler(NewButton_Click);
                    Bt[i, j].MouseRightButtonDown += new MouseButtonEventHandler(RNewButton_Click);
                    Bt[i, j].R = i;
                    Bt[i, j].C = j;
                    grid.Children.Add(Bt[i,j]);
                }
                l += 1;
            }
            for (int k = 0; k < mines; k++)
            {
                link1:
                int p = rnd.Next(rows);
                int m = rnd.Next(columns);
                if (Bt[p,m].Id == -1)
                {
                    goto link1;
                }
                else
                {
                    Bt[p, m].Id = -1;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (Bt[i,j].Id != -1)
                    {
                        int count = 0;
                        try
                        {
                            if (Bt[i - 1, j - 1].Id == -1) { count++; } //1
                        }
                        catch { }
                        try
                        {
                            if (Bt[i - 1, j].Id == -1) { count++; } //2
                        }
                        catch { }
                        try
                        {
                            if (Bt[i - 1, j + 1].Id == -1) { count++; } //3
                        }
                        catch { }
                        try
                        {
                            if (Bt[i, j - 1].Id == -1) { count++; } //4
                        }
                        catch { }
                        try
                        {
                            if (Bt[i, j + 1].Id == -1) { count++; } //5
                        }
                        catch { }
                        try
                        {
                            if (Bt[i + 1, j - 1].Id == -1) { count++; } //6
                        }
                        catch { }
                        try
                        {
                            if (Bt[i + 1, j].Id == -1) { count++; } //7
                        }
                        catch { }
                        try
                        {
                            if (Bt[i + 1, j + 1].Id == -1) { count++; } //8
                        }
                        catch { }
                        if (count == 0)
                            Bt[i, j].Id = null;
                        else
                            Bt[i, j].Id = count;
                        ColorNumbers.GetColorNumber(Bt[i,j], count);
                        Bt[i, j].FontWeight = FontWeights.Bold;
                    }
                }
            }
            return Bt;
        }
        private void NewButton_Click(object sender, RoutedEventArgs e) 
        {
            GameButton Bt = sender as GameButton;
            if (Bt.Flag == false)
            {
                if (Bt.Id == -1)
                {
                    if (Data.sound == true)
                    {
                        MediaPlayer mplayer = new MediaPlayer();
                        mplayer.Open(new Uri(@"..\..\EXPLODE.WAV", UriKind.RelativeOrAbsolute));
                        mplayer.Play();
                    } 
                    CloseAllCells();
                    OpenAllMines();
                    MessageBox.Show("Вы проиграли");
                }
                else
                {
                    if (Data.sound == true)
                    {
                        MediaPlayer mplayer = new MediaPlayer();
                        mplayer.Open(new Uri(@"..\..\CLICK.WAV", UriKind.RelativeOrAbsolute));
                        mplayer.Play();
                    }
                    Bt.IsEnabled = false;
                    if (Bt.Id == null)
                    {
                        OpenNearZeroCells(Bt.R, Bt.C);
                    }
                    if (Bt.Flag == true)
                    {
                        Bt.Flag = false;
                        FlagsCounter++;
                        LocalFlagsCounter--;
                        Data.Counter = FlagsCounter;
                    }
                    Bt.Content = Bt.Id.ToString();
                }
            }
        }
        public void CloseAllCells()
        {
            for (int i=0; i<Data.rows; i++)
            {
                for (int j = 0; j < Data.columns; j++)
                {
                    Bt[i, j].IsHitTestVisible = false;
                }
            }
        }
        public void OpenAllMines()
        {
            for (int i = 0; i < Data.rows; i++)
            {
                for (int j = 0; j < Data.columns; j++)
                {
                    if(Bt[i, j].Id == -1)
                    {
                        Bt[i, j].IsEnabled = false;
                        if(Bt[i,j].Flag == true)
                        {
                            BitmapImage bitimg2 = new BitmapImage();
                            bitimg2.BeginInit();
                            bitimg2.UriSource = new Uri(@"blueone.png", UriKind.RelativeOrAbsolute);
                            bitimg2.EndInit();
                            Image img2 = new Image();
                            img2.Stretch = Stretch.Fill;
                            img2.Source = bitimg2;
                            Bt[i, j].Content = img2;
                            Bt[i, j].Background = new ImageBrush(bitimg2);
                        }
                        else
                        {
                            BitmapImage bitimg = new BitmapImage();
                            bitimg.BeginInit();
                            bitimg.UriSource = new Uri(@"png-transparent-gray-spiked-ball-art-microsoft-minesweeper-minesweeper-classic-the-minesweeper-naval-mine-mines-game-symmetry-video-game-thumbnail.png", UriKind.RelativeOrAbsolute);
                            bitimg.EndInit();
                            Image img = new Image();
                            img.Stretch = Stretch.Fill;
                            img.Source = bitimg;
                            Bt[i, j].Content = img;
                            Bt[i, j].Background = new ImageBrush(bitimg);
                        }
                    }
                }
            }
        }
        public void OpenNearZeroCells(int i, int j)
        {
            if (Bt[i, j].Id == null)
            {
                try
                {
                    if (Bt[i - 1, j - 1].IdLocal == true) { }
                    else
                    {
                        OpenCell(Bt[i - 1, j - 1]);
                        if (Bt[i - 1, j - 1].Id == null)
                        {
                            Bt[i, j].IdLocal = true;
                            OpenNearZeroCells(i - 1, j - 1);
                        }
                        if (Bt[i - 1, j - 1].Flag == true)
                        {
                            Bt[i - 1, j - 1].Flag = false;
                            FlagsCounter++;
                            LocalFlagsCounter--;
                            Data.Counter = FlagsCounter;
                        }
                    }
                }
                catch { }
                try
                {
                    if (Bt[i - 1, j].IdLocal == true) { }
                    else
                    {
                        OpenCell(Bt[i - 1, j]);
                        if (Bt[i - 1, j].Id == null)
                        {
                            Bt[i, j].IdLocal = true;
                            OpenNearZeroCells(i - 1, j);
                        }
                        if (Bt[i - 1, j].Flag == true)
                        {
                            Bt[i - 1, j].Flag = false;
                            FlagsCounter++;
                            LocalFlagsCounter--;
                            Data.Counter = FlagsCounter;
                        }
                    }
                }
                catch { }
                try
                {
                    if (Bt[i - 1, j + 1].IdLocal == true) { }
                    else
                    {
                        OpenCell(Bt[i - 1, j + 1]);
                        if (Bt[i - 1, j + 1].Id == null)
                        {
                            Bt[i, j].IdLocal = true;
                            OpenNearZeroCells(i - 1, j + 1);
                        }
                        if (Bt[i - 1, j + 1].Flag == true)
                        {
                            Bt[i - 1, j + 1].Flag = false;
                            FlagsCounter++;
                            LocalFlagsCounter--;
                            Data.Counter = FlagsCounter;
                        }
                    }
                }
                catch { }
                try
                {
                    if (Bt[i, j - 1].IdLocal == true) { }
                    else
                    {
                        OpenCell(Bt[i, j - 1]);
                        if (Bt[i, j - 1].Id == null)
                        {
                            Bt[i, j].IdLocal = true;
                            OpenNearZeroCells(i, j - 1);
                        }
                        if (Bt[i, j - 1].Flag == true)
                        {
                            Bt[i, j - 1].Flag = false;
                            FlagsCounter++;
                            LocalFlagsCounter--;
                            Data.Counter = FlagsCounter;
                        }
                    }
                }
                catch { }
                try
                {
                    if (Bt[i, j + 1].IdLocal == true) { }
                    else
                    {
                        OpenCell(Bt[i, j + 1]);
                        if (Bt[i, j + 1].Id == null)
                        {
                            Bt[i, j].IdLocal = true;
                            OpenNearZeroCells(i, j + 1);
                        }
                        if (Bt[i, j + 1].Flag == true)
                        {
                            Bt[i, j + 1].Flag = false;
                            FlagsCounter++;
                            LocalFlagsCounter--;
                            Data.Counter = FlagsCounter;
                        }
                    }
                }
                catch { }
                try
                {
                    if (Bt[i + 1, j - 1].IdLocal == true) { }
                    else
                    {
                        OpenCell(Bt[i + 1, j - 1]);
                        if (Bt[i + 1, j - 1].Id == null)
                        {
                            Bt[i, j].IdLocal = true;
                            OpenNearZeroCells(i + 1, j - 1);
                        }
                        if (Bt[i + 1, j - 1].Flag == true)
                        {
                            Bt[i + 1, j - 1].Flag = false;
                            FlagsCounter++;
                            LocalFlagsCounter--;
                            Data.Counter = FlagsCounter;
                        }
                    }
                }
                catch { }
                try
                {
                    if (Bt[i + 1, j].IdLocal == true) { }
                    else
                    {
                        OpenCell(Bt[i + 1, j]);
                        if (Bt[i + 1, j].Id == null)
                        {
                            Bt[i, j].IdLocal = true;
                            OpenNearZeroCells(i + 1, j);
                        }
                        if (Bt[i + 1, j].Flag == true)
                        {
                            Bt[i + 1, j].Flag = false;
                            FlagsCounter++;
                            LocalFlagsCounter--;
                            Data.Counter = FlagsCounter;
                        }
                    }
                }
                catch { }
                try
                {
                    if (Bt[i + 1, j + 1].IdLocal == true) { }
                    else
                    {
                        OpenCell(Bt[i + 1, j + 1]);
                        if (Bt[i + 1, j + 1].Id == null)
                        {
                            Bt[i, j].IdLocal = true;
                            OpenNearZeroCells(i + 1, j + 1);
                        }
                        if (Bt[i + 1, j + 1].Flag == true)
                        {
                            Bt[i + 1, j + 1].Flag = false;
                            FlagsCounter ++;
                            LocalFlagsCounter--;
                            Data.Counter = FlagsCounter;
                        }
                    }
                }
                catch { }
            }
        }
        public void OpenCell(GameButton Btn)
        {
            Btn.IsEnabled = false;
            Btn.Content = Btn.Id.ToString();
        }
        private void RNewButton_Click(object sender, MouseButtonEventArgs e)
        {
            GameButton Bt = sender as GameButton;
            if (LocalFlagsCounter != Data.mines)
            {
                if (Bt.Flag == false)
                {
                    BitmapImage bitimg = new BitmapImage();
                    bitimg.BeginInit();
                    bitimg.UriSource = new Uri(@"flag.jpg", UriKind.RelativeOrAbsolute);
                    bitimg.EndInit();
                    Image img = new Image();
                    img.Stretch = Stretch.Fill;
                    img.Source = bitimg;
                    Bt.Content = img;
                    Bt.Background = new ImageBrush(bitimg);
                    Bt.Flag = true;
                    FlagsCounter--;
                    LocalFlagsCounter++;
                    if (Bt.Id == -1)
                    {
                        LocalMinesFlagsCounter++;
                    }
                }
                else if (Bt.Flag == true)
                {
                    Bt.Content = "";
                    Bt.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                    Bt.Flag = false;
                    FlagsCounter++;
                    LocalFlagsCounter--;
                    if (Bt.Id == -1)
                    {
                        LocalMinesFlagsCounter--;
                    }
                }
                if (LocalMinesFlagsCounter == Data.mines)
                {
                    if (Data.sound == true)
                    {
                        MediaPlayer mplayer = new MediaPlayer();
                        mplayer.Open(new Uri(@"..\..\win3.wav", UriKind.RelativeOrAbsolute));
                        mplayer.Play();
                    }
                    CloseAllCells();
                    MessageBox.Show("Победа!!!");
                }
            }
            else if (LocalFlagsCounter == Data.mines)
            {
                if (Bt.Flag == true)
                {
                    Bt.Content = "";
                    Bt.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                    Bt.Flag = false;
                    FlagsCounter++;
                    LocalFlagsCounter--;
                    if (Bt.Id == -1)
                    {
                        LocalMinesFlagsCounter--;
                    }
                }
                if (LocalMinesFlagsCounter == Data.mines)
                {
                    if (Data.sound == true)
                    {
                        MediaPlayer mplayer = new MediaPlayer();
                        mplayer.Open(new Uri(@"..\..\win3.wav", UriKind.RelativeOrAbsolute));
                        mplayer.Play();
                    }
                    CloseAllCells();
                    MessageBox.Show("Победа!!!");
                }
            }
            Data.Counter = FlagsCounter;
        }
    }
}