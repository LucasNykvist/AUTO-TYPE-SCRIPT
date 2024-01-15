using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;

class Program
{
    // This program will read the text from a file and send it to the window that has focus after 2 seconds
    [STAThread]
    // The main function of the program
    static void Main()
    {
        // Read the text file into a string
        string text = File.ReadAllText("text.txt");

        // Wait for the user to focus the window
        Thread.Sleep(2000);

        // Send the text to the window and press enter at the end 
        foreach (char c in text)
        {
            SendKeys.SendWait(c.ToString());
        }

        SendKeys.SendWait("{ENTER}");
    }
}
