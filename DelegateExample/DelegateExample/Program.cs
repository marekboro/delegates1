
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DelegateExample;

class Program
{
    delegate void LogDel(string text);

    static void Main(string[] args)
    {
        LogDel logDel = new LogDel(LogTextToScreen);
        logDel("some text");
        Console.ReadKey();
    }

    static void LogTextToScreen(string text) {
        Console.WriteLine($"{DateTime.Now}: {text}");
    }

}
