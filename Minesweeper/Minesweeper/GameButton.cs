using System.Windows.Controls;

namespace Minesweeper
{
    internal class GameButton : Button
    {
        private int? id;
        private int r, c;
        private bool flag = false, idlocal = false;
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        public int R
        {
            get { return r; }
            set { r = value; }
        }
        public int C
        {
            get { return c; }
            set { c = value; }
        }
        public bool IdLocal
        {
            get { return idlocal; }
            set { idlocal = value; }
        }
    }
}
