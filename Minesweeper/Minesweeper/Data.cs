using System;

namespace Minesweeper
{
    static class Data
    {
        public static event Action<int> ChangeCounter;
        public static int rows, columns,mines,counter;
        public static bool sound = true;
        public static int Counter
        {
            get => counter;
            set 
            {
                counter = value;
                ChangeCounter?.Invoke(counter);
            }
        }  
    }
}
