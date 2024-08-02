namespace CS.Generics
{
    public class Pair <Tkey, Tvalue>
    {
        public Tkey Key;
        public Tvalue Value;
        public Pair(Tkey key, Tvalue value)
        {
            this.Key = key;
            this.Value = value;
        }        
    }
}
