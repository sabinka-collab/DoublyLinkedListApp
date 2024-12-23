using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("процессы:");
        Process[] processes = Process.GetProcesses();

        foreach (Process process in processes)
        {
            try
            {
                Console.WriteLine($"имя процесса: {process.ProcessName} /n ID: {process.Id}, память: {process.VirtualMemorySize64} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"ошибка {process.ProcessName} {e.Message}");
            }
        }

        // Запуск приложения Блокнот
        try
        {
            Process.Start("notepad.exe");
            Console.WriteLine("приложение блокнот запущено");
        }
        catch (Exception e)
        {
            Console.WriteLine($"не удалось запустить блокнот {e.Message}");
        }

        static void kill()
        {
            Process[] a = Process.GetProcessesByName("notepad");
            foreach (Process notepad in a)
            {
                try
                {
                    notepad.Kill();
                    Console.WriteLine($"процесс завершен");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"не удалось завершить процесс : {e.Message}");
                }
            }
        }
    }
}