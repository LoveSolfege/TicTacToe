namespace TicTacToe {
    internal class Player {
        public BoardCell Symbol { get; }

        public Player(BoardCell symbol) {
            Symbol = symbol;
        }

        public Square PickSquare(TTCBoard board) {
            while (true) {
                Console.Write("Select Square 1-9: ");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();

                if (KeyToSquareMap.TryGetValue(key, out Square choice)) {
                    if (IsEmpty(board, choice))
                        return choice;
                    else
                        Console.WriteLine("Square is already taken");
                }
                else {
                    Console.WriteLine("Invalid key pressed.");
                }
            }
        }

        private bool IsEmpty(TTCBoard board, Square cell) {
            if (!board.IsEmpty(cell.Row, cell.Column))
                return false;
            return true;
        }

        Dictionary<ConsoleKey, Square> KeyToSquareMap = new Dictionary<ConsoleKey, Square>{
            {ConsoleKey.D1, new Square(0,0)},
            {ConsoleKey.D2, new Square(0,1)},
            {ConsoleKey.D3, new Square(0,2)},
            {ConsoleKey.D4, new Square(1,0)},
            {ConsoleKey.D5, new Square(1,1)},
            {ConsoleKey.D6, new Square(1,2)},
            {ConsoleKey.D7, new Square(2,0)},
            {ConsoleKey.D8, new Square(2,1)},
            {ConsoleKey.D9, new Square(2,2)}
        };  

    }
}
