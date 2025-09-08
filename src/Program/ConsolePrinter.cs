using System;
using System.Text;

namespace Ucu.Poo.GameOfLife;

public class ConsolePrinter
{
    public static void MostrarTablero(Board board) // llamo a Board
    {
        Console.Clear();

        Cell[,] b = board.GameBoard;
        int width = board.width; //ancho del tablero, se lo "pido" a Board
        int height = board.height; //altura del tablero, se lo "pido" a Board
        
        StringBuilder s = new StringBuilder();
        for (int y = 0; y < height ; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if(b[x,y].Viva)
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n");
        }
        Console.WriteLine(s.ToString());
    }
}