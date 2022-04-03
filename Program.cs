using ChromaSDK;
using System;
using System.Threading;

namespace CSharp_SampleApp
{
    class Program
    {
        const int MAX_ITEMS = 47;

        static void PrintLegend(SampleApp app, int selectedIndex, bool supportsStreaming)
        {
            Console.WriteLine("C# CHROMA SAMPLE APP");
            Console.WriteLine();
            Console.WriteLine("Use UP and DOWN arrows to select an animation and press ENTER.");
            Console.WriteLine();

            int startIndex = 1;

            if (supportsStreaming)
            {
                startIndex = -9;
                Console.WriteLine("Streaming Info (SUPPORTED):");
                ChromaSDK.Stream.StreamStatusType status = ChromaAnimationAPI.CoreStreamGetStatus();
                Console.WriteLine(string.Format("Status: {0}", ChromaAnimationAPI.CoreStreamGetStatusString(status)));
                Console.WriteLine(string.Format("Shortcode: {0}", app.GetShortcode()));
                Console.WriteLine(string.Format("Stream Id: {0}", app.GetStreamId()));
                Console.WriteLine(string.Format("Stream Key: {0}", app.GetStreamKey()));
                Console.WriteLine(string.Format("Stream Focus: {0}", app.GetStreamFocus()));
                Console.WriteLine();
            }

            for (int index = startIndex; index <= MAX_ITEMS; ++index)
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

                if (index > 0)
                {
                    if ((index % 4) == 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("\t\t");
                    }
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
                int startIndex = 1;

                bool supportsStreaming = ChromaAnimationAPI.CoreStreamSupportsStreaming();

                if (supportsStreaming)
                {
                    startIndex = -9;
                }

                int selectedIndex = 1;

                if (supportsStreaming)
                {
                    selectedIndex = -9;
                }

                DateTime inputTimer = DateTime.MinValue;

                while (true)
                {
                    if (inputTimer < DateTime.Now)
                    {
                        Console.Clear();
                        PrintLegend(sampleApp, selectedIndex, supportsStreaming);
                        inputTimer = DateTime.Now + TimeSpan.FromMilliseconds(100);
                    }
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        if (selectedIndex > startIndex)
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
                        sampleApp.ExecuteItem(selectedIndex, supportsStreaming);
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
