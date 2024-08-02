namespace CS.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class VendorInfoAttribute : Attribute
{
    public string CompanyName { get; set; }
    public int ProductVersion { get; set; }
}