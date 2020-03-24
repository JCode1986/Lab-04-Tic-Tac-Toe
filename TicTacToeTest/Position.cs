namespace TicTacToeTest
{
    internal class Position
    {
        internal int Column;
        private int v1;
        private int v2;

        public Position(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int Row { get; internal set; }
    }
}