#include "computerTechnology.hpp"
#include <iostream>

ComputerTechnology::ComputerTechnology(std::string manufacturer) : Manufacturer{manufacturer}
{ }

void ComputerTechnology::Print() const noexcept
{
	std::cout << "Manufacturer: " << Manufacturer << std::endl;
}

const std::string& ComputerTechnology::GetManufacturer() const noexcept
{
	return Manufacturer;
}

void ComputerTechnology::SetManufacturer(std::string manufacturer)
{
	Manufacturer = manufacturer;
}