using DesignPatterns.StrategyPattern;
using DesignPatterns.ObserverPattern;
using DesignPatterns.SingletonPattern;
using DesignPatterns.ProxyPattern;
using DesignPatterns.AdapterPattern;
using DesignPatterns.FacadePattern;
using DesignPatterns.BuilderPattern;

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

BuilderProgram.Run();
LineSeperator();

static void LineSeperator()
{
    Console.WriteLine("---------------------------------");
}