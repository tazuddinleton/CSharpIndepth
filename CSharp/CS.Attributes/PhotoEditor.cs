namespace CS.Attributes;

[VendorInfo(CompanyName = "Adobe Corp", ProductVersion = 11)]
public class PhotoEditor
{
    public int MyProperty { get; set; }

    private void PrivateMethod()
    {
        Console.WriteLine("Photo editor private method");
    }

    public void PublicMethod()
    {
        Console.WriteLine("HELLO FROM Photo editor public method");
    }
}