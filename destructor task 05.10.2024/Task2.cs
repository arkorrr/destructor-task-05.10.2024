using System;

public enum StoreType
{
    Grocery,
    Household,
    Clothing,
    Footwear
}

public class Store : IDisposable
{
    private bool disposed = false;

    public string Name { get; set; }
    public string Address { get; set; }
    public StoreType Type { get; set; }

    public Store(string name, string address, StoreType type)
    {
        Name = name;
        Address = address;
        Type = type;
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
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Type: {Type}");
    }
    ~Store()
    {
        Dispose(false);
        Console.WriteLine($"Store '{Name}' has been removed from memory.");
    }
}
