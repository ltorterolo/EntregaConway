using System.CodeDom.Compiler;
using System.Diagnostics.Metrics;

namespace Ucu.Poo.GameOfLife;

public class Motor // reglas de celulas vivas 
{
    public NuevoBoard(Board board)
    {
        Cell[,] gameBoard = board.GetCells(); // importo el tablero de la clase Board 
        int boardWidth = gameBoard.GetLength(0); // saco las dimensiones del tablero
        int boardHeight = gameBoard.GetLength(1); // original para poder crear una copia
        
        Cell[,] cloneboard = new Cell[boardWidth, boardHeight]; //creo la copia 
        for (int x = 0; x < boardWidth; x++) // recorremos todo el tablero 
        {
            for (int y = 0; y < boardHeight; y++) 
            {
                int aliveNeighbors = 0; // para cada celda vuelve a 0 y arranca a contar
                cloneboard[x, y] = new Cell(gameBoard[x,y].Viva); // una vez  que identifico la cell, la inicilizo con el mismo valor que esta en el board original 
                                                            // pone un objeto de la clase Cell en cada celda, de esta forma no modifica el oroginal, crea una copia 
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j].Viva) // verifca no salir del tablero
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (gameBoard[x, y].Viva) //si la celda actual está viva
                {
                    aliveNeighbors--; //se resta porque no cuenta 
                }

                if (gameBoard[x, y].Viva && aliveNeighbors < 2) //comienza a acuilizar el tablero
                {
                    //Celula muere por baja población
                    cloneboard[x, y].Viva = false;
                }
                else if (gameBoard[x, y].Viva && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard[x, y].Viva = false;
                }
                else if (!gameBoard[x, y].Viva && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard[x, y].Viva = true;
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard[x, y].Viva = gameBoard[x, y].Viva;
                }
            }
        }
        gameBoard = cloneboard;
        return gameBoard;
    }
}