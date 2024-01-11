


using DesignPatterns.Patterns.Factory.NetworkUtility;
using DesignPatterns.Singleton.Patterns;

#region Singleton Pattern

Singleton object1 = Singleton.Instance();
Singleton object2 = Singleton.Instance();

if(object1 == object2)
{
    Console.WriteLine("These objects are the same");
}

#endregion

#region Factory Pattern

Ping ping = new Ping();

#endregion