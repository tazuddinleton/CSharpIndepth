namespace CS.Classes;
class Singleton
{

    private static Singleton _instance;
    public static int Count = 0;
    private Singleton()
    {
        Count += 1;
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
            _instance = new Singleton();
        return _instance;
    }
}