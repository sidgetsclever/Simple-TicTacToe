namespace TicTacToe
{
    internal class Grid
    {
        public static char[] _arr;

        public Grid(char[] arr)
        {
            _arr = arr;
        }
        public static void Print()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arr[1], _arr[2], _arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arr[4], _arr[5], _arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arr[7], _arr[8], _arr[9]);
            Console.WriteLine("     |     |      ");
        }

        public static int Calculate()
        {
            // diag1
            if ((_arr[1] == _arr[5]) && (_arr[5] == _arr[9]))
            {
                Console.Clear();
                Declare(_arr[1]);
                return 1;
            }

            // diag2
            if ((_arr[3] == _arr[5]) && (_arr[5] == _arr[7]))
            {
                Console.Clear();
                Declare(_arr[3]);
                return 1;
            }

            // vert1
            if ((_arr[1] == _arr[4]) && (_arr[4] == _arr[7]))
            {
                Console.Clear();
                Declare(_arr[1]);
                return 1;
            }

            // vert2
            if ((_arr[2] == _arr[5]) && (_arr[5] == _arr[8]))
            {
                Console.Clear();
                Declare(_arr[2]);
                return 1;
            }

            // vert3
            if ((_arr[3] == _arr[6]) && (_arr[6] == _arr[9]))
            {
                Console.Clear();
                Declare(_arr[3]);
                return 1;
            }

            Console.Clear();
            return 0;
        }

        private static void Declare(char sign)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(sign == 'X' ? "Player 1 Won!!" : "Player 2 Won!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
