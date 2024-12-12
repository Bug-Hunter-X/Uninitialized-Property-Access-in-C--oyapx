# Uninitialized Property Access in C#

This repository demonstrates a subtle but common error in C#: accessing a property before it has been assigned a value.

## The Problem

In C#, class properties, if not explicitly initialized, will have their default values. This default value is 0 for integers, null for reference types (like strings), and false for booleans.

Accessing such properties before assignment may lead to unexpected behavior in your application.  The program might proceed without error, but might fail in a later stage.   This is especially tricky if the default value (0, null, false, etc.) is logically valid within the program, making the issue difficult to detect.

The `bug.cs` file shows an example of this.  The `MyProperty` is not explicitly set before it is read in `MyMethod`, leading to an output of 0.

## The Solution

The solution is simple: always initialize properties explicitly or handle cases where they might not be initialized.

The `bugSolution.cs` file shows the same class but with two ways to address the issue.
* One initializes the property with a value at declaration.
* One adds a check before accessing the value to either use a default value or throw an exception. 

## How to Reproduce

1. Clone this repository.
2. Open the solution in Visual Studio.
3. Run the `bug.cs` file.  Observe the output (0).
4. Modify the `MyMethod` to use a different initial value or conditional behavior based on the property value. 
5. Run the `bugSolution.cs` file.  Observe the changes.

This example highlights the importance of clear and explicit initialization for your class properties in C# to prevent such potential problems.