using System.CodeDom.Compiler;
using System.Diagnostics.Metrics;

namespace Ucu.Poo.GameOfLife;

public class Motor // reglas de celulas vivas 
{
    public static Board NuevoBoard(Board board)
    {
        int boardWidth = board.width; // saco las dimensiones del tablero
        int boardHeight = board.height; // original para poder crear una copia
        
        Cell[,] cloneboard = new Cell[boardWidth, boardHeight]; //creo la copia 
        for (int x = 0; x < boardWidth; x++) // recorremos todo el tablero 
        {
            for (int y = 0; y < boardHeight; y++) 
            {
                int aliveNeighbors = 0; // para cada celda vuelve a 0 y arranca a contar
                cloneboard[x, y] = new Cell(board.IsAlive(x,y)); // una vez  que identifico la cell, la inicilizo con el mismo valor que esta en el board original 
                                                            // pone un objeto de la clase Cell en cada celda, de esta forma no modifica el oroginal, crea una copia 
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && board.IsAlive(i,j)) // verifca no salir del tablero
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (board.IsAlive(x,y)) //si la celda actual está viva
                {
                    aliveNeighbors--; //se resta porque no cuenta 
                }

                if (board.IsAlive(x,y) && aliveNeighbors < 2) //comienza a acuilizar el tablero
                {
                    //Celula muere por baja población
                    cloneboard[x, y].Viva = false;
                }
                else if (board.IsAlive(x,y) && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard[x, y].Viva = false;
                }
                else if (!board.IsAlive(x,y) && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard[x, y].Viva = true;
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard[x, y].Viva = board.IsAlive(x,y);
                }
            }
        }
        return new Board(cloneboard);
    }
}