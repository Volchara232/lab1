#pragma once
#include "computerTechnology.hpp"
#include <string>

enum class Key { None, Membrane, Mechanical, Optical };
enum class Connection { None, Wired, Wireless };

class Keyboard : public ComputerTechnology
{
    std::string Color;
    Key KeysType;
    Connection ConnectionType;
    bool HasBacklight;
public:
    Keyboard(std::string manufacturer = "Logitech", std::string color = "Black",
        Key keysType = Key::None, Connection connectionType = Connection::None, bool hasBacklight = false);
    Keyboard(std::string manufacturer = "Logitech", std::string color = "Black",
        std::string keysType = "none", std::string connectionType = "none", bool hasBacklight = false);
    void Print() const noexcept override;
    const std::string& GetManufacturer() const noexcept;
    void SetManufacturer(std::string manufacturer);
    const std::string& GetColor() const noexcept;
    void SetColor(std::string color);
    Key GetKeysType() const noexcept;
    void SetKeysType(Key keysType);
    Connection GetConnectionType() const noexcept;
    void SetConnectionType(Connection connectionType);
    bool GetHasBacklight() const noexcept;
    void SetHasBacklight(bool hasBacklight);
};
