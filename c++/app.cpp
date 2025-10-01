#include "monitor.hpp"
#include "keyboard.hpp"
#include <iostream>
#include <list>

int main()
{
    std::list<ComputerTechnology*>* compTechList = new std::list<ComputerTechnology*>();
    int input = 0;

    while (1)
    {
        std::cout << "What object do you want to make?" << std::endl << "1 - Computer technology"
            << std::endl << "2 - Monitor" << std::endl << "3 - Keyboard" << std::endl
            << "4 - Print objects" << std::endl << "5 - Exit" << std::endl;

        std::cin >> input;

        switch (input)
        {
        case 1:
        {
            std::string manufacturer;
            std::cout << "Enter manufacturer: ";
            std::cin >> manufacturer;

            compTechList->push_back(new ComputerTechnology(manufacturer));
            break;
        }
        case 2:
        {
            std::string manufacturer;
            float screenSize;
            int width, height, refreshRate;
            std::cout << "Enter manufacturer, resolution (in format WIDTHxHEIGHT), screen size and refresh rate" << std::endl;
            std::cin >> manufacturer >> width;
            std::cin.ignore(1, 'x');
            std::cin >> height >> screenSize >> refreshRate;

            compTechList->push_back(new Monitor(manufacturer, {width, height}, screenSize, refreshRate));
            break;
        }
        case 3:
        {
            std::string manufacturer, color, keys, connection;
            bool hasBacklight;
            std::cout << "Enter manufacturer, color, type of keys (membrane, mechanical or optical), "
                "connection type (wired or wireless) and whether there is a backlight (1 or 0)" << std::endl;
            std::cin >> manufacturer >> color >> keys >> connection >> hasBacklight;

            compTechList->push_back(new Keyboard(manufacturer, color, keys, connection, hasBacklight));
            break;
        }
        case 4:
        {
            int i = 1;
            for (const ComputerTechnology* item : *compTechList)
            {
                std::cout << i++ << ": ";
                item->Print();
            }
            break;
        }
        case 5:
            for (auto item : *compTechList)
                delete item;
            delete compTechList;
            return 0;
        default:
            break;
        }
    }
}   

