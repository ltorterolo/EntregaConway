namespace Ucu.Poo.GameOfLife;
// branch board importer
using System.IO;

public class BoardImporter
{
    public static Cell[,] LoadFromFile(string fileName)
    {
        string content = File.ReadAllText(fileName); // lee el archivo (string)
        string[] lines = content.Split('\n'); // parte el texto en lineas, cada linea es una fila del tablero
        
        // cant de filas y columnas
        int height = lines.Length; 
        int width  = lines[0].Length;
        
        // crea la matriz x = columna, y = fila
        Cell[,] board = new Cell[width, height];
        
        // recorre filas y columnas
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (lines[y][x] == '1')
                {
                    board[x, y] = new Cell(true);
                }
                else
                {
                    board[x, y] = new Cell(false);
                }
            }
        }
        // devuelve el tablero completo
        return board;
    }
}
