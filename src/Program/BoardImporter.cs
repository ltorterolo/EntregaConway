namespace Ucu.Poo.GameOfLife;
// branch board importer
using System.IO;

public class BoardImporter
{
    public static bool[,] LoadFromFile(string fileName)
    {
        string content = File.ReadAllText(fileName); // lee el archivo (string)
        string[] lines = content.Split('\n'); // parte el texto en lineas, cada linea es una fila del tablero
        
        // cant de filas y columnas
        int height = lines.Length; 
        int width  = lines[0].Length;
        
        // crea la matriz x = columna, y = fila
        bool[,] board = new bool[width, height];
        
        // recorre filas y columnas
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (lines[y][x] == '1')
                {
                    board[x, y] = true; // si lee 0, no hace nada, queda false por defecto
                }
            }
        }
        // devuelve el tablero completo
        return board;
    }
}
