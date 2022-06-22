namespace WpfApp1
{
    internal class RGBClass
    {
        private int r;

        public int R
        {
            get { return r; }
            set
            {
                r = r >= 0 ? (r < 256 ? value : 255) : 0;
            }
        }

        private int g;

        public int G
        {
            get { return g; }
            set
            {
                g = g >= 0 ? (g < 256 ? value : 255) : 0;
            }
        }

        private int b;
        public int B
        {
            get { return b; }
            set
            {
                b = b >= 0 ? (b < 256 ? value : 255) : 0;
            }
        }
    }
}



