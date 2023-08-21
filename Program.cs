using DesignPatterns.Singleton;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            
            MySingleton instance1 = MySingleton.GetInstance();
            MySingleton instance2 = MySingleton.GetInstance();
            MySingleton instance3 = MySingleton.GetInstance();

            #endregion Singleton
        }
    }
}