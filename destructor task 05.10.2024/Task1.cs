using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Play : IDisposable
{
    private bool disposed = false;
    public string namePlay {  get; set; }
    public string PIB { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public Play(string namePlay, string PIB, string Genre, int Year)
    {
        this.namePlay = namePlay;
        this.PIB = PIB;
        this.Genre = Genre;
        this.Year = Year;
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;
        { }

        if (disposing)
        {
            // Освобождаем управляемые ресурсы
        }
        // освобождаем неуправляемые объекты
        disposed = true;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name of play: {namePlay}");
        Console.WriteLine($"PIB: {PIB}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Year: {Year}");
    }
    ~Play()
    {
        Dispose(false);
        Console.WriteLine($"Play '{namePlay}' has been removed from memory.");
    }
}
