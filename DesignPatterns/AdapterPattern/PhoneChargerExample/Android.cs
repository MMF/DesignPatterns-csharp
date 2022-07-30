using System;
using System.Collections.Generic;
using System.Linq;
namespace DesignPatterns.AdapterPattern.PhoneChargerExample;

public class Android : IUsbPhone
{
    private bool _isConnected = false;

    public void ConnectUsb()
    {
        _isConnected = true;
        Console.WriteLine("Andriod phone connected.");
    }

    public void Recharge()
    {
        if (_isConnected)
        {
            Console.WriteLine("Andriod phone recharging.");
        }
        else
        {
            Console.WriteLine("Connect the USB cable first.");
        }
    }
}
