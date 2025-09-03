namespace Ucu.Poo.GameOfLife;

public class Cell
{
    public bool Viva { get; set; }
    public Cell(bool alive) //defino el constructor para cell, seteando en un booleano para alive
    {
        Viva = alive;
    }
}