#pragma once
#include <string>
class ComputerTechnology
{
protected:
    std::string Manufacturer;
public:
    ComputerTechnology(std::string Manufacturer = "DEXP");
    virtual void Print() const noexcept;
    const std::string& GetManufacturer() const noexcept;
    void SetManufacturer(std::string manufacturer);
};
