// Board Class
// Contains all information about a board state
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using static Stone;

public class Board
{
    private int boardSize;
    // private char[,] boardState = new char[19, 19];
    private List<Stone> boardState;

    public Board(int bSize)
    {
        boardSize = bSize;

        for (int x = 0; x < boardSize; x++)
        {
            boardState.add(new List<Stone(x, y, "empty")>);
            for (int y = 0; y < boardSize; y++)
            {
                boardState[x, y] = '+';
            }
        }
    }

    public void printBoard()
    {
        for (int x = 0; x < boardSize; x++)
        {
            for (int y = 0; y < boardSize; y++)
            {
                Console.Write("{0} ", boardState[x, y]);
            }
            Console.WriteLine();
        }
    }
}