#include "monitor.hpp"
#include <iostream>
#include <stdexcept>

Monitor::Monitor(std::string manufacturer, std::vector<int> resolution, float screenSize, int refreshRate) :
    ComputerTechnology{manufacturer}, Resolution{resolution}, ScreenSize{screenSize}, RefreshRate{refreshRate}
{
    if (resolution.size() != 2 || resolution[0] < 1 || resolution[1] < 1)
        throw std::invalid_argument("Resolution must be a vector of two positive integers");
    if (screenSize <= 0)
        throw std::invalid_argument("Screen size must be a positive float number");
    if (refreshRate < 1)
        throw std::invalid_argument("Refresh rate must be a positive integer");
}

void Monitor::Print() const noexcept
{
    std::cout << "Manufacturer: " << Manufacturer << ", resolution: " << Resolution[0] << 'x' << Resolution[1]
        << ", screen size: " << ScreenSize << "\", refresh rate: " << RefreshRate << " Hz" << std::endl;
}

const std::string& Monitor::GetManufacturer() const noexcept
{
    return Manufacturer;
}

void Monitor::SetManufacturer(std::string manufacturer)
{
    Manufacturer = manufacturer;
}

const std::vector<int>& Monitor::GetResolution() const noexcept
{
    return Resolution;
}

void Monitor::SetResolution(std::vector<int> resolution)
{
    if (resolution.size() != 2 || resolution[0] < 1 || resolution[1] < 1)
        throw std::invalid_argument("Resolution must be a vector of two positive integers");

    Resolution = resolution;
}

void Monitor::SetResolution(int width, int height)
{
    if (width < 1 || height < 1)
        throw std::invalid_argument("Resolution consists of two positive integers");

    Resolution = std::vector<int>({width, height});
}

float Monitor::GetScreenSize() const noexcept
{
    return ScreenSize;
}

void Monitor::SetScreenSize(float screenSize)
{
    if (screenSize <= 0)
        throw std::invalid_argument("Screen size must be a positive float number");

    ScreenSize = screenSize;
}

int Monitor::GetRefreshRate() const noexcept
{
    return RefreshRate;
}

void Monitor::SetRefreshRate(int refreshRate)
{
    if (refreshRate < 1)
        throw std::invalid_argument("Refresh rate must be a positive integer");

    RefreshRate = refreshRate;
}