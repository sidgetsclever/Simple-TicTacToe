using static TicTacToe.Grid;

namespace TicTacToe
{
    public class Program
    {
        static int _exit = 0;
        private static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static void Main(string[] args)
        {
            Grid grid = new Grid(arr);
            do
            {
                Print();
                Console.WriteLine("Player 1 'X' input index:");
                int xIndex = int.Parse(Console.ReadLine());
                arr[xIndex] = 'X';

                _exit = Calculate();
                if (_exit == 1)
                {
                    break;
                }
                Print();

                Console.WriteLine("Player 2 'O' input index:");
                int oIndex = int.Parse(Console.ReadLine());
                arr[oIndex] = 'O';
                _exit = Calculate();
            } while (_exit == 0);
        }
    }
}