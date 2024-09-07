namespace TicTacToe {
    internal class TTCGameController {

        public void Start() {
            TTCBoard Board = new();

        }

        private bool IsWinner(TTCBoard board, BoardCell value) {
            for (int i = 0; i < 3; i++) {
                if ((board.ContentsOf(i, 0) == value && board.ContentsOf(i, 1) == value && board.ContentsOf(i, 2) == value) || // Check row
                    (board.ContentsOf(0, i) == value && board.ContentsOf(1, i) == value && board.ContentsOf(2, i) == value))   // Check column
                {
                    return true;
                }
            }

            if ((board.ContentsOf(0, 0) == value && board.ContentsOf(1, 1) == value && board.ContentsOf(2, 2) == value) ||  // Main diagonal
                (board.ContentsOf(2, 0) == value && board.ContentsOf(1, 1) == value && board.ContentsOf(0, 2) == value))    // Anti-diagonal
            {
                return true;
            }

            return false;

        }

        private void RenderBoard(TTCBoard board) {
            for (int i = 0; i < 3; i++) {
                Console.WriteLine($" {GetCharacterFor(board.ContentsOf(i, 0))} | {GetCharacterFor(board.ContentsOf(i, 1))} | {GetCharacterFor(board.ContentsOf(i, 2))}");

                if (i < 2)
                {
                    Console.WriteLine("---+---+---");
                }
            }
        }

        private char GetCharacterFor(BoardCell cell) => cell switch {
            BoardCell.X => 'X',
            BoardCell.O => 'O',
            BoardCell.Empty => ' ',
            _ => ' '
        };
    }
}
