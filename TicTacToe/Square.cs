namespace TicTacToe {
    internal class Square {
        public int Row { get; }
        public int Column { get; }

        public Square(int row, int column) {
            Row = row;
            Column = column;
        }
    }
}
