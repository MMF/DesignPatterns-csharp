using DesignPatterns.StrategyPattern;
using DesignPatterns.ObserverPattern;
using DesignPatterns.SingletonPattern;
using DesignPatterns.ProxyPattern;
using DesignPatterns.AdapterPattern;
using DesignPatterns.FacadePattern;

StrategyProgram.Run();
LineSeperator();

ObserverProgram.Run();
LineSeperator();

SingletonProgram.Run();
LineSeperator();

ProxyProgram.Run();
LineSeperator();

AdapterProgram.Run();
LineSeperator();

FacadeProgram.Run();
LineSeperator();

static void LineSeperator()
{
    Console.WriteLine("---------------------------------");
}