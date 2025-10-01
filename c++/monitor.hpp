
#pragma once
#include "computerTechnology.hpp"
#include <string>
#include <vector>

class Monitor : public ComputerTechnology
{
    std::vector<int> Resolution;
    float ScreenSize;
    int RefreshRate;
public:
    Monitor(std::string manufacturer = "Samsung", std::vector<int> resolution = {1920, 1080},
        float screenSize = 23.8, int refreshRate = 60);
    void Print() const noexcept override;
    const std::string& GetManufacturer() const noexcept;
    void SetManufacturer(std::string manufacturer);
    const std::vector<int>& GetResolution() const noexcept;
    void SetResolution(std::vector<int> resolution);
    void SetResolution(int width, int height);
    float GetScreenSize() const noexcept;
    void SetScreenSize(float screenSize);
    int GetRefreshRate() const noexcept;
    void SetRefreshRate(int refreshRate);
};

