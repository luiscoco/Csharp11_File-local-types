MyClass myClass = new MyClass();
MyClass.MyMethod();


//Beginning in C# 11, you can use the "file" access modifier
//to create a type whose visibility is scoped to the source
//file in which it is declared. This feature helps source generator
//authors avoid naming collisions.
file class MyClass
{
    public static void MyMethod()
    {
        Console.WriteLine("Hello from MyMethod!");
    }
}
