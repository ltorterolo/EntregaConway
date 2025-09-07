namespace Ucu.Poo.GameOfLife;

using System.IO;

public class BoardImporter
{
    public static bool[,] LoadFromFile(string url)
    {
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        
        // crea la matriz
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        
        // recorre filas y columnas
        for (int y = 0; y < contentLines.Length; y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if (contentLines[y][x] == '1')
                {
                    board[y, x] = true;
                }
            }
        }
        // devuelve el tablero completo
        return board;
    }
}
