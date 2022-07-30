using DesignPatterns.StrategyPattern;
using DesignPatterns.ObserverPattern;
using DesignPatterns.SingletonPattern;
using DesignPatterns.ProxyPattern;
using DesignPatterns.AdapterPattern;

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

static void LineSeperator()
{
    Console.WriteLine("---------------------------------");
}