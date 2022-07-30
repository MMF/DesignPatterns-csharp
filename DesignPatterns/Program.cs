using DesignPatterns.StrategyPattern;
using DesignPatterns.ObserverPattern;
using DesignPatterns.SingletonPattern;
using DesignPatterns.ProxyPattern;

StrategyProgram.Run();
LineSeperator();

ObserverProgram.Run();
LineSeperator();

SingletonProgram.Run();
LineSeperator();

ProxyProgram.Run();
LineSeperator();

static void LineSeperator()
{
    Console.WriteLine("---------------------------------");
}