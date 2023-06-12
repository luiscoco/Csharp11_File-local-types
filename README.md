# Csharp_File-local-types

In C# 11, the file-local type feature was introduced to allow the declaration of types that are accessible only within a single source file. This feature helps in encapsulating implementation details and reducing the visibility of types to improve code organization and maintainability.

Here's an example of how you can use the file-local type in C# 11:

```csharp
// File: MyClass.cs
namespace MyNamespace
{
    public partial class MyClass
    {
        // This is a file-local type declaration
        file class FileLocalClass
        {
            public void FileLocalMethod()
            {
                // File-local method implementation
            }
        }

        public void PublicMethod()
        {
            FileLocalClass fileLocalObject = new FileLocalClass();
            fileLocalObject.FileLocalMethod();

            // Accessing the file-local class within the same source file is allowed
        }
    }
}

// File: Program.cs
using MyNamespace;

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();

        // Uncommenting the line below will result in a compilation error
        // myObject.FileLocalClass fileLocalObject = new myObject.FileLocalClass();

        myObject.PublicMethod();

        // The file-local class is not accessible from outside the source file
    }
}
```

In the above example, MyClass is a partial class defined in the MyNamespace. Within the MyClass definition, a file-local class named FileLocalClass is declared. This class is accessible only within the same source file (MyClass.cs) and cannot be accessed from other source files (e.g., Program.cs).

The PublicMethod() in MyClass can create an instance of FileLocalClass and call its FileLocalMethod() method since it's within the same file. However, in the Main() method in Program.cs, attempting to create an instance of FileLocalClass will result in a compilation error because the type is not accessible outside the MyClass.cs file.

Using file-local types can help encapsulate implementation details and prevent unintended access to types that should be limited to a specific file, enhancing code modularity and maintainability.
