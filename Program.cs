using System;

namespace SingletonDesignPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var instance1 = Singleton.Instance();
      var instance2 = Singleton.Instance();
      if (instance1.Equals(instance2))
        Console.WriteLine("Instance 1 and instance 2 are the same instance of Singleton.");
    }
  }
}
