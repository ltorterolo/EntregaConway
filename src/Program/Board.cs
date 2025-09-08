using System;

namespace Ucu.Poo.GameOfLife;

public class Board
{
    public Cell[,] GameBoard;

    public int width
    {
        get { return GameBoard.GetLength(0); }
    }

    public int height
    {
        get { return GameBoard.GetLength(1); }
    }

    // Constructor que recibe el tablero inicial
    public Board(Cell[,] tablero)
    {
        GameBoard = tablero;
    }


    // Consultar si una celda está viva
    public bool IsAlive(int x, int y)
    {
        return GameBoard[x, y].Viva;
    }

}