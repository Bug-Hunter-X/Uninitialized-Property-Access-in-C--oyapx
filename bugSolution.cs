public class ExampleClass
{
    // Solution 1: Initialize the property
    public int MyProperty { get; set; } = 10; //Initialized to 10

    // Solution 2: Handle uninitialized cases
    public int MyProperty2 { get; set; }

    public void MyMethod()
    {
        // Check for initialization
        int value = MyProperty;
        Console.WriteLine(value); //Output: 10

        if(MyProperty2 == 0)
        {
            Console.WriteLine("Property MyProperty2 is not initialized. Using default 0");
        }
        else
        {
            Console.WriteLine(MyProperty2); 
        }
    }
} 