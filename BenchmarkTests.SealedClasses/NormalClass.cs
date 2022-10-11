namespace BenchmarkTests.SealedClasses;

public class NormalClass : BaseClass
{
    public override void VoidMethod() {}

    public override int IntMethod() => 1;

    public override string StringMethod() => "normal";
}