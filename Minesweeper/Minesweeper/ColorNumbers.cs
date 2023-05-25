using System.Windows.Media;

namespace Minesweeper
{
    static class ColorNumbers
    {
        public static void GetColorNumber(GameButton Btn, int cnt)
        {
            switch (cnt)
            {
                case 1:
                    Btn.Foreground = Brushes.Blue;
                    break;
                case 2:
                    Btn.Foreground = Brushes.Green;
                    break;
                case 3:
                    Btn.Foreground = Brushes.Red;
                    break;
                case 4:
                    Btn.Foreground = Brushes.Magenta;
                    break;
                case 5:
                    Btn.Foreground = Brushes.DarkOrange;
                    break;
                case 6:
                    Btn.Foreground = Brushes.Cyan;
                    break;
                case 7:
                    Btn.Foreground = Brushes.Black;
                    break;
                case 8:
                    Btn.Foreground = Brushes.DarkSlateGray;
                    break;
            }
        }
    }
}
