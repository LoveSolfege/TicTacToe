namespace TicTacToe {
    internal class TTCBoard {
        private readonly BoardCell[,] _cells = new BoardCell[3,3];
        public BoardCell ContentsOf(int row, int column) => _cells[row,column];
        public void FillCell(int row, int column, BoardCell value) => _cells[row, column] = value;
        public bool IsEmpty(int row, int column) => _cells[row, column] == BoardCell.Empty;
    }
    public enum BoardCell { Empty, X, O}
}
