using System;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(BoardImporter.LoadFromFile("board.txt"));
            while (true)
            {
                ConsolePrinter.MostrarTablero(board);
                board = Motor.NuevoBoard(board);
                Thread.Sleep(500);
            }
        }
    }
}
