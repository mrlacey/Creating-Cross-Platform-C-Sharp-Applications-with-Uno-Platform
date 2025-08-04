using Microsoft.UI.Xaml;

namespace HelloWorld;

public class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        Microsoft.UI.Xaml.Application.Start((p) => new App());
    }
}