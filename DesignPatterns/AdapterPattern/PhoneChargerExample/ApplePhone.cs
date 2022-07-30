namespace DesignPatterns.AdapterPattern.PhoneChargerExample;

public class ApplePhone : ILightningPhone
{
    private bool _isConnected = false;
    public void ConnectLightning()
    {
        _isConnected = true;
        Console.WriteLine("Apple phone connected!");
    }

    public void Recharge()
    {
        if (_isConnected)
        {
            Console.WriteLine("Apple phone recharging.");
        }
        else
        {
            Console.WriteLine("Connect the Lightning cable first.");
        }
    }
}
