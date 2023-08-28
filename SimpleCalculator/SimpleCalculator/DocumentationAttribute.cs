namespace SimpleCalculator;

[AttributeUsage(AttributeTargets.Class)]
public class DocumentationAttribute : Attribute
{
    public string Description { get; set; }

    public DocumentationAttribute(string description) 
    {
        Description = description;
    }
}

[Documentation("This class does something.")]
public class MyClass
{

}
