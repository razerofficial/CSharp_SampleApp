using ChromaSDK;
using System;
using System.Threading;

namespace CSharp_SampleApp
{
    class Program
    {
        const int MAX_ITEMS = 47;

        static void PrintLegend(SampleApp app, int selectedIndex)
        {
            Console.WriteLine("C# CHROMA SAMPLE APP");
            Console.WriteLine();
            Console.WriteLine("Use UP and DOWN arrows to select an animation and press ENTER.");
            Console.WriteLine();

            for (int index = 1; index <= MAX_ITEMS; ++index)
            {
                if (index == selectedIndex)
                {
                    Console.Write("[*] ");
                }
                else
                {
                    Console.Write("[ ] ");
                }
                Console.Write("{0, 8}", app.GetEffectName(index));

                if ((index % 4) == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("\t\t");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to play selection.");
        }

        static void Main(string[] args)
        {
            SampleApp sampleApp = new SampleApp();
            sampleApp.Start();

            if (sampleApp.GetInitResult() == RazerErrors.RZRESULT_SUCCESS)
            {
                int selectedIndex = 1;

                sampleApp.ExecuteItem(selectedIndex);

                while (true)
                {
                    PrintLegend(sampleApp, selectedIndex);
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.Clear();

                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        if (selectedIndex > 1)
                        {
                            --selectedIndex;
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        if (selectedIndex < MAX_ITEMS)
                        {
                            ++selectedIndex;
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        sampleApp.ExecuteItem(selectedIndex);
                    }
                    Thread.Sleep(1);
                }

                ChromaAnimationAPI.StopAll();
                ChromaAnimationAPI.CloseAll();
                sampleApp.OnApplicationQuit();

            }

            Console.WriteLine("{0}", "C# Chroma Sample App [EXIT]");
        }
    }
}
