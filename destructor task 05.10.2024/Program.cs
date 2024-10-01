class Program
{
    public static void Main()
    {
        //Task1
        using (Play play = new Play("namePlay", "KTO TO TAM", "Genre", 2000))
        {

        }
        Play p = new Play("namePlay", "KTO TO TAM", "Genre", 2000);
        p.ShowInfo();
        p = null;
        GC.Collect(); //Вызываются автоматически
        GC.WaitForPendingFinalizers();
        //Task2
        Console.WriteLine();
        using (Store store = new Store("Name", "Adress", StoreType.Grocery))
        {

        }
        Store s = new Store("Name", "Adress", StoreType.Grocery);
        s.ShowInfo();
        s = null;
        GC.Collect(); //Вызываются автоматически
        GC.WaitForPendingFinalizers();
    }
}