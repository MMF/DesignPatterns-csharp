namespace DesignPatterns.AdapterPattern.PhoneChargerExample;

public class PhoneChargerProgram
{
    public static void Run()
    {
        var iphone1 = new ApplePhone();
        iphone1.ConnectLightning();
        iphone1.Recharge();

        var iphone2 = new ApplePhone();
        var usbAdapter = new LightningPhoneToUsbAdapter(iphone2);
        usbAdapter.ConnectUsb();
        usbAdapter.Recharge();
    }
}
