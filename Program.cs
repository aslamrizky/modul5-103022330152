// See https://aka.ms/new-console-template for more information
public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
     }
}

public class PemrosesData()
{
    public dynamic DapatkanNilaiTerbesar<T>(T x1, T x2, T x3)
    {
        dynamic bil1 = x1;
        dynamic bil2 = x2;
        dynamic bil3 = x3;
        if (bil1 > bil2)
        {
            return bil1;
        } else if (bil3 > bil2)
        {
            return bil3;
        } else
        {
            return bil2;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<float> db = new SimpleDataBase<float>();
        db.AddNewData(10);
        db.AddNewData(30);
        db.AddNewData(22);
        db.PrintAllData();
        PemrosesData data = new PemrosesData();
        Console.WriteLine("Nilai max: " + data.DapatkanNilaiTerbesar<float>(10, 30, 22));
    }
}
