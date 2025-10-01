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
        static string CorrectWrite(string print, string error, Func<string, bool> is_correct)
        {
            string? inputstr;
            while (true)
            {
                Console.Write(print);
                inputstr = Console.ReadLine();
                if (is_correct(inputstr ?? "")) return inputstr ?? "";
                else                
                    Console.WriteLine(error);
            }
        }
        static void Main()
        {
            List<Periphery> peripheries = new List<Periphery>();
            string? inputstr = "0";
            int input = 0;
            Console.Clear();
            while (true)
            {
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Write number of object do you want to make:");
                Console.WriteLine("1 - Periphery");
                Console.WriteLine("2 - Monitor");
                Console.WriteLine("3 - Keyboard");
                Console.WriteLine("4 - Print objects");
                Console.WriteLine("5 - Exit");
                Console.WriteLine("________________________________________________");
                Console.SetCursorPosition(44, 1);
                inputstr = Console.ReadLine();
                if (int.TryParse(inputstr, out input))
                {
                    Console.SetCursorPosition(0, 8);
                    switch (input)
                    {

                        case 1:
                            {
                                string manufacturer;
                                Periphery new_base = new Periphery();
                                Console.Write("Enter manufacturer:");

                                manufacturer = Console.ReadLine() ?? "";
                                new_base.Manufacturer = manufacturer;
                                peripheries.Add(new_base);
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                double screenSize = 0;
                                int width = 0, height = 0, refreshRate = 0;
                                string manufacturer, refreshinput, widthInput,
                                       heightInput, sizeInput;

                                Size res;
                                manufacturer = CorrectWrite(
                                "Enter manufacturer: ",
                                "Incorrect input. Please, write something.",
                                inputstr => !string.IsNullOrWhiteSpace(inputstr));

                                widthInput = CorrectWrite(
                                        "Enter screen width: ",
                                        "Incorrect input. Please, enter a positive integer.",
                                        inputstr => int.TryParse(inputstr, out width) && width > 0);

                                heightInput = CorrectWrite(
                                    "Enter screen height: ",
                                    "Incorrect input. Please, enter a positive integer.",
                                    inputstr => int.TryParse(inputstr, out height) && height > 0);

                                res = new Size(width, height);

                                sizeInput = CorrectWrite(
                                    "Enter screen size (inches): ",
                                    "Incorrect input. Please, enter a positive number.",
                                    inputstr => double.TryParse(inputstr, out screenSize) && screenSize > 0);

                                refreshinput = CorrectWrite(
                                    "Enter refresh rate (Hz):",
                                    "Incorrect input. Please, enter a positive integer.",
                                    inputstr => int.TryParse(inputstr, out refreshRate) && refreshRate > 0);

                                Monitor.Monitor el_monitor = new Monitor.Monitor(res, refreshRate, screenSize, manufacturer);
                                peripheries.Add(el_monitor);
                                Console.Clear();
                                break;
                            }
                        case 3:
                            {
                                string manufacturer, color,
                                        connectionInput, keysInput,
                                        backlightInput;
                                Key keys = 0;
                                Connection connection = 0;
                                bool hasBacklight = false;
                                manufacturer = CorrectWrite(
                                "Enter manufacturer: ",
                                "Incorrect input. Please, write something.",
                                input => !string.IsNullOrWhiteSpace(input));

                                color = CorrectWrite(
                                        "Enter color: ",
                                        "Incorrect input. Please, write something.",
                                        inputstr => !string.IsNullOrWhiteSpace(inputstr));


                                connectionInput = CorrectWrite(
                                    "Enter connection type (Wired, Wireless): ",
                                    "Incorrect input. Please, write correct value",
                                    inputstr => Enum.TryParse<Connection>(inputstr, true, out _));
                                connection = (Connection)Enum.Parse(typeof(Connection), connectionInput, true);

                                keysInput = CorrectWrite(
                                    "Enter keyboard type (Membrane, Mechanical, Optical): ",
                                    "Incorrect input. Please, write correct value",
                                    input => Enum.TryParse<Key>(input, true, out _));
                                keys = (Key)Enum.Parse(typeof(Key), keysInput, true);


                                backlightInput = CorrectWrite(
                                    "Does this keyboard have backlight? Write yes/no: ",
                                    "Please enter yes or no (y/n).",
                                    inputstr => inputstr.ToLower() == "yes" || inputstr.ToLower() == "y" ||
                                        inputstr.ToLower() == "no" || inputstr.ToLower() == "n");

                                hasBacklight = (backlightInput.ToLower() == "yes" || backlightInput.ToLower() == "y");

                                Keyboard.Keyboard new_keyboard = new Keyboard.Keyboard(color, keys, connection, hasBacklight, manufacturer);
                                peripheries.Add(new_keyboard);
                                Console.Clear();
                                break;
                            }
                        case 4:
                            {
                                int i = 1;
                                foreach (Periphery peripheral in peripheries)
                                {
                                    Console.WriteLine("=======================");
                                    Console.WriteLine($"Element number: {i}");
                                    peripheral.Print();
                                    i++;
                                    Console.WriteLine();
                                }
                                Console.WriteLine("=======================");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 5:
                            Console.Clear();
                            return;

                        default:
                            Console.Clear();
                            break;
                    }

                }
                

            }
        }

    }

}