public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized will result in 0 (default value)
        int value = MyProperty; //This will be 0 if not assigned

        Console.WriteLine(value); //Output: 0
    }
}