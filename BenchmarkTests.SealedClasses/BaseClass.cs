namespace BenchmarkTests.SealedClasses;

public class BaseClass
{
    public virtual void VoidMethod() {}
    public virtual int IntMethod() => -1;
    public virtual string StringMethod() => string.Empty;

    public static string StaticMethod() => "static";
}