using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class ConsolePrinter
{
    public bool Tablero { get; set; }
    gameBoard.GetLength(0) //ancho del tablero, se lo "pido" a Board
    gameBoard.GetLength(1) //altura del tablero, se lo "pido" a Board

    public ConsolePrinter(bool b, int width, int height)
    {
        Tablero = b;
    }
        
   public MostrarTablero(Board)
    {
        Console.Clear();
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
        Console.WriteLine(s.ToString());
        //=================================================
        //Invocar método para calcular siguiente generación
        //=================================================
        Thread.Sleep(500);
    }
}