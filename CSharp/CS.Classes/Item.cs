namespace CS.Classes;

abstract class Item
{
    public abstract string GetName();
    public virtual string GetItemCode()
    {
        return "xx-xx-xx";
    }
        
}