using System;
using System.Text;

namespace Ucu.Poo.GameOfLife;

public class ConsolePrinter
{
   public static void MostrarTablero(int [,] Board)
    {
        Console.Clear();

        bool[,] b = Board.gameboard;
        int width = Board.GetLength(0); //ancho del tablero, se lo "pido" a Board
        int height = Board.GetLength(1); //altura del tablero, se lo "pido" a Board
        
        StringBuilder s = new StringBuilder();
        for (int y = 0; y < height ; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if(b[x,y])
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
    }
}