using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;

class Program
{
    [STAThread]
    static void Main()
    {
        string text = File.ReadAllText("text.txt");

        Thread.Sleep(2000);

        foreach (char c in text)
        {
            SendKeys.SendWait(c.ToString());
        }

        SendKeys.SendWait("{ENTER}");
    }
}
