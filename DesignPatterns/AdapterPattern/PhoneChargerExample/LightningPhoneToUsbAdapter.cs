namespace DesignPatterns.AdapterPattern.PhoneChargerExample;

public class LightningPhoneToUsbAdapter : IUsbPhone
{
    private bool _isConnected = false;
    private readonly ILightningPhone _lightningPhone;

    public LightningPhoneToUsbAdapter(ILightningPhone lightningPhone)
    {
        _lightningPhone = lightningPhone;
        _lightningPhone.ConnectLightning();
    }

    public void ConnectUsb()
    {
        _isConnected = true;
        Console.WriteLine("Adapter Cable Connected.");
    }

    public void Recharge()
    {
        if (_isConnected)
        {
            _lightningPhone.Recharge();
        }
        else
        {
            Console.WriteLine("Connect the USB cable first.");
        }
    }
}
