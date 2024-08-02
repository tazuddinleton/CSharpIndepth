namespace CS.Classes;

class Pen : Item
{
    public override string GetName()
    {
        throw new NotImplementedException();
    }

    public sealed override string GetItemCode()
    {
        return "PEN-xx-xx";
    }

}