// See https://aka.ms/new-console-template for more information
class DataGeneric<T>
{
    public T Data { get; set; }
    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}

class Program
{
    static void Main()
    {
        DataGeneric<string> dataNIM = new DataGeneric<string>("103022300004");
        dataNIM.PrintData();
    }
}

