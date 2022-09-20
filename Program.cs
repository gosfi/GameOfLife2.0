namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        byte[,] PlainBoard(int width, int height) 
        {
            byte[,] board = new byte[width, height];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i,j] = 0;
                }
            }

            return board;
        }
    }
}