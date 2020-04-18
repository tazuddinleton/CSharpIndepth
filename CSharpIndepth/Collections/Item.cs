namespace CSharpIndepth.Collections
{
    public class Item : IGroupable
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        
        public bool IsGroup { get; set; }
    }
}
