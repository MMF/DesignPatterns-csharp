using DesignPatterns.StrategyPattern;
using DesignPatterns.ObserverPattern;
using DesignPatterns.SingletonPattern;
using DesignPatterns.ProxyPattern;
using DesignPatterns.AdapterPattern;
using DesignPatterns.FacadePattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.MediatorPattern;

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

MediatorProgram.Run();
LineSeperator();

static void LineSeperator()
{
    Console.WriteLine("---------------------------------");
}