using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Tạo và bắt đầu một luồng mới để thực thi hàm ff
        Thread ffThread = new Thread(new ThreadStart(ff));
        ffThread.Start();

        // Đợi cho luồng kết thúc
        ffThread.Join();

        // Hiển thị thông báo khi luồng kết thúc
        Console.WriteLine("Đã thực hiện xong");
    }

    static void ff()
    {
        Random random = new Random();
        while (true)
        {
            int n = random.Next();
            if (n % 2025 == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine(n);
                Thread.Sleep(100); // Delay 100ms
            }
        }
    }
}