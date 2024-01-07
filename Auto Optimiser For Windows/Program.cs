using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Windows Optimiser");
        Console.WriteLine("1. Uninstall All");
        Console.WriteLine("2. Coming Soon");
        Console.Write("Choice your option (1 or 2) : ");

        string choix = Console.ReadLine();

        switch (choix)
        {
            case "1":
                Option1();
                break;
            case "2":
                Option2();
                break;
            default:
                Console.WriteLine("Invalid choice, Please choose 1 or 2.");
                break;
        }
    }

    static void Option1()
    {
        Console.WriteLine("You chose option 1. Running the PowerShell command...");

        string[] powerShellCommands = new string[]
        {
            "Get-AppxPackage *WindowsAlarms* | Remove-AppxPackage",
            "Get-AppxPackage *AV1VideoExtension* | Remove-AppxPackage",
            "Get-AppxPackage *Microsoft.549981C3F5F10* | Remove-AppxPackage",
            "Get-AppxPackage *WindowsFeedbackHub* | Remove-AppxPackage",
            "Get-AppxPackage *HEIFImageExtension* | Remove-AppxPackage",
            "Get-AppxPackage *GetHelp* | Remove-AppxPackage",
            "Get-AppxPackage *WindowsMaps* | Remove-AppxPackage",
            "Get-AppxPackage *MicrosoftEdge* | Remove-AppxPackage",
            "Get-AppxPackage *Todos* | Remove-AppxPackage",
            "Get-AppxPackage *ZuneVideo* | Remove-AppxPackage",
            "Get-AppxPackage *MicrosoftOfficeHub* | Remove-AppxPackage",
            "Get-AppxPackage *Paint* | Remove-AppxPackage",
            "Get-AppxPackage *ZuneMusic* | Remove-AppxPackage",
            "Get-AppxPackage *BingNews* | Remove-AppxPackage",
            "Get-AppxPackage *WindowsNotepad* | Remove-AppxPackage",
            "Get-AppxPackage *OneDriveSync* | Remove-AppxPackage",
            "Get-AppxPackage *People* | Remove-AppxPackage",
            "Get-AppxPackage *Windows.Photos* | Remove-AppxPackage",
            "Get-AppxPackage *SkypeApp* | Remove-AppxPackage",
            "Get-AppxPackage *ScreenSketch* | Remove-AppxPackage",
            "Get-AppxPackage *MicrosoftSolitaireCollection* | Remove-AppxPackage",
            "Get-AppxPackage *WindowsSoundRecorder* | Remove-AppxPackage",
            "Get-AppxPackage *Teams* | Remove-AppxPackage",
            "Get-AppxPackage *BingWeather* | Remove-AppxPackage",
            "Get-AppxPackage *Xbox* | Remove-AppxPackage",
            "Get-AppxPackage *YourPhone* | Remove-AppxPackage",
        };

        foreach (string powerShellCommand in powerShellCommands)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{powerShellCommand}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            process.StartInfo = startInfo;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            Console.WriteLine($"PowerShell command executed successfully:\n{powerShellCommand}");
        }

        Console.ReadLine();
    }

    static void Option2()
    {
        Console.WriteLine("You chose option 2. Do what you have to do here.");
        Console.ReadLine();
    }
}
