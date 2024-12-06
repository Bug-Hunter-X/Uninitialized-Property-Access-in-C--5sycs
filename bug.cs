public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a non-initialized variable
        Console.WriteLine(MyProperty);
    }
}