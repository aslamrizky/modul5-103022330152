// See https://aka.ms/new-console-template for more information
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
    public static void Main(String[] args)
    {
        PemrosesData data = new PemrosesData();
        Console.WriteLine("Nilai max: " + data.DapatkanNilaiTerbesar<int>(1030, 2233, 0152));
    }
}
