using Virtual;
using System;
using Monitor;
using Keyboard;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Diagnostics.Tracing;
namespace Lab1
{
    class Programm
    {
        static void Main()
        {
            List<Periphery> peripheries = new List<Periphery>();
            List<Monitor.Monitor> monitors = new List<Monitor.Monitor>();
            List<Keyboard.Keyboard> keyboards = new List<Keyboard.Keyboard>();
            string inputstr = "0";
            int input = 0;
            while (true)
            {
                Console.WriteLine("What object do you want to make?");
                Console.WriteLine("1 - Periphery");
                Console.WriteLine("2 - Monitor");
                Console.WriteLine("3 - Keyboard");
                Console.WriteLine("4 - Print objects");
                Console.WriteLine("5 - Exit");
                inputstr = Console.ReadLine();
                input = int.Parse(inputstr);
                switch (input)
                {
                case 1:
                {   string manufacturer;
                    Periphery el = new Periphery();
                    Console.Write("Enter manufacturer: ");
                    manufacturer = Console.ReadLine();
                    el.Manufacturer = manufacturer;
                    peripheries.Add(el);
                    break;
                }
                case 2:
                {
                    string manufacturer;
                    double screenSize;
                    int width, height, refreshRate;
                    Size res;
                   
                    Console.WriteLine("Enter manufacturer, resolution (in format 'WIDTH HEIGHT')", 
                                    "screen size and refresh rate");

                    manufacturer = Console.ReadLine();
                    inputstr = Console.ReadLine();
                    width = int.Parse(inputstr);
                    inputstr = Console.ReadLine();
                    height = int.Parse(inputstr);
                    inputstr = Console.ReadLine();
                    screenSize = int.Parse(inputstr);
                    inputstr = Console.ReadLine();
                    refreshRate = int.Parse(inputstr);
                    res = new Size(width, height);
                    Monitor.Monitor el_monitor = new Monitor.Monitor(res, refreshRate, screenSize, manufacturer);
                    monitors.Add(el_monitor);                   
                    break;
                }
                case 3:
                {
                    string manufacturer, color;
                    Key keys = 0;
                    Connection connection = 0;
                    bool hasBacklight = false;
                    Console.WriteLine("Enter manufacturer, color, type of keys (membrane, mechanical or optical)",
                                      "connection type (wired or wireless) and whether there is a backlight (1 or 0)");
                    
                    manufacturer = Console.ReadLine();
                    color = Console.ReadLine();
                    inputstr = Console.ReadLine();
                    if (inputstr == "None"||
                        inputstr == "Wired"||
                        inputstr == "Wirelles") connection = 0;
                    Keyboard.Keyboard el_keyboard = new Keyboard.Keyboard(color, keys, connection, hasBacklight);
                    keyboards.Add(el_keyboard);
                    break;
                }
                case 4:
                {
                    int i = 0;
                    while (i < peripheries.Count)
                    {
                        Console.WriteLine($"Базовый элемент номер: {i+1}");
                        peripheries[i].Print();                           
                    }
                    i = 0;
                    while (i < monitors.Count)
                    {
                        Console.WriteLine($"Монитор номер: {i+1}");
                        monitors[i].Print();                           
                    }
                    i = 0;
                    while (i < keyboards.Count)
                            {
                                Console.WriteLine($"Клавиатура номер: {i + 1}");
                                monitors[i].Print();
                            }

                   
                    break;
                }
                case 5:
                        return;
                    
                default:
                    break;
                }

            }


 
        
        }

    }

}