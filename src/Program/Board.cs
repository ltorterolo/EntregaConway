using System;

namespace Ucu.Poo.GameOfLife;

public class Board
{
    private Cell[,] GameBoard = new Cell[8, 8];

    public int Width { get; }
    public int Height { get; }

    // Constructor que recibe el tablero inicial en bools
    public Board(BoardImporter board)
    {

        public bool[,] tableroinicial = BoardImporter.LoadFromFile(board.txt);
    
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {

                GameBoard[x, y] = new Cell([x, y]);
            }
        }
    }

    // Consultar si una celda está viva
    public bool IsAlive(int x, int y)
    {
        return GameBoard[x, y].IsAlive;
    }

    // Cambiar estado de una celda
    public void SetCell(int x, int y, bool alive)
    {
        GameBoard[x, y].IsAlive = alive;
    }
}